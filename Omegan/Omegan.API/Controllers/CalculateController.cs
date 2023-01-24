﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.DTOs;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompany;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompanyStateQuery;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementsById;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using Omegan.Application.Features.Companies.Queries.GetCountries;
using Omegan.Application.Features.Compensation.Querys.GetCompensationByCompanyStateQuery;
using Omegan.Application.Features.Compensation.Querys.GetCompensationById;
using Omegan.Application.Features.TRM.Queries;
using Omegan.Application.Utils;
using Omegan.Domain;
using System.Collections.Generic;
using System.Linq;
using static Omegan.Application.Utils.Enumeraciones;

namespace Omegan.API.Controllers
{
   
    public class CalculateController : ApiControllerBase
    {
        private IMediator _mediator;
        Round lstRound = new Round();

        public CalculateController(IMediator mediator)
        {   
            _mediator = mediator;
        }

        [HttpGet("GetPreaprobado")]
        public async Task<IActionResult> GetPreaprobado()
        {
            double TotalCompany = 0;
            double AddAnnouncementCountry = 0;
            List<PreapprovedData> lstPreaprobado = new List<PreapprovedData>();

            decimal percent = 0;
            
            double SumaTotal = 0;
            Totales totales = new Totales();
            PreapprovedData preapprovedData= new PreapprovedData();

            //Datos Tabla TRM para calculos
            var querytrm = new GetTRMListQuery();
            List<TrmDTO> trm = await _mediator.Send(querytrm);
            int contcompany = 0;

            //Obtener compañias activas
            var queryCompanies = new GetAllCompanyAnnouncementsQuery((int)EstadosCompanies.AprobadaConvenio);
            List<CompanyAnnouncementsDTO> company = await _mediator.Send(queryCompanies);
            Round round = new Round();
            
            foreach (var _company in company) 
            {
                
                //Datos del pais
                var querycountry = new GetAllCountriesQuery();
                var country = await _mediator.Send(querycountry);


                var query = new GetAnnouncementByCompanyStateQuery(_company.Id, 2);
                var announcement = await _mediator.Send(query);

                foreach (var co in country)
                {
                    //var query = new GetAnnouncementByCompanyStateQuery(_company.Id, 2);
                    //var announcement = await _mediator.Send(query);
                    foreach(var ann in announcement)
                    {
                       if(co.Id == ann.IdDestinationCountry)
                       {
                            foreach(var product in ann.ProductsList!)
                            {
                                //AddAnnouncementCountry += (trm.First().TRMValue * (co.CurrentValue/1000) * Convert.ToDouble(product.Kilogram));
                                AddAnnouncementCountry += (co.CurrentValue / 1000) * Convert.ToDouble(product.Kilogram);
                            }

                       }
                    }

                    AddAnnouncementCountry = (AddAnnouncementCountry * trm.First().TRMValue);

                    TotalCompany +=  Math.Round(AddAnnouncementCountry,2);
                    AddAnnouncementCountry = 0;
                }

                //Si el total anunciado por la compañia es menor o igual al total asignado para el mes
                if(TotalCompany <= trm.First().InitialDivision)
                {
                    //decimal porcentaje = Convert.ToDecimal(((TotalCompany * 100) / trm.First().InitialDivision));
                    percent = decimal.Round(100, 2);

                    SumaTotal = SumaTotal + TotalCompany;
                  
                    var aprovved = new PreapprovedData()
                    {
                        Company = _company.NameCompany,
                        Amount = TotalCompany,
                        Percent = percent
                        
                    };

                    lstPreaprobado.Add(aprovved);

                }
                else
                {
                    decimal porcentaje = Convert.ToDecimal(((TotalCompany * 100) / trm.First().InitialDivision));
                    percent = decimal.Round(porcentaje, 2);

                    SumaTotal = SumaTotal + TotalCompany;

                    var aprovved = new PreapprovedData()
                    {
                        Company = _company.NameCompany,
                        Amount = TotalCompany,
                        //Residue = 0,
                        Percent = percent
                        
                    };

                    lstPreaprobado.Add(aprovved);
                }



                lstRound.lstPreapproved = lstPreaprobado;
                
                TotalCompany = 0;
                contcompany += 1;


            }

            lstRound.TotalPreaprobado = SumaTotal;

           

            lstRound.lstRound1 = CalculoRound1(lstPreaprobado, trm);


            lstRound = CeroUno(lstRound);


            lstRound.lstRound2 = CalculoRound2(lstRound, trm);

            lstRound.LstExcedentes = Excedentes(lstRound);

            lstRound.lstFinal = CalculoFinal(lstRound);

            return new OkObjectResult(new ResultResponse(lstRound) { Message = string.Format(ResultResponse.ENTITY_GET, lstRound) });
        }



        [HttpGet("GetCompensation")]
        public async Task<IActionResult> GetCompensation()
        {
            List<LiquidationCompensationOutputDTO> lstLiquidatinCompensation = new List<LiquidationCompensationOutputDTO>();

            //Datos Tabla TRM para calculos
            var querytrm = new GetTRMListQuery();
            List<TrmDTO> trm = await _mediator.Send(querytrm);

            var queryCompanies = new GetAllCompanyAnnouncementsQuery((int)EstadosCompanies.AprobadaConvenio);
            List<CompanyAnnouncementsDTO> company = await _mediator.Send(queryCompanies);
            List<ProductkDTO> lstProducts = new List<ProductkDTO>();
            foreach (var _company in company)
            {
                var query = new GetCompensationByCompanyStateQuery(_company.Id, (int)EstadosCompanies.RadicacionDocExportacion);
                List<CompensationDTO> compensation = await _mediator.Send(query);

                if (compensation.Count > 0)
                {

                    var llstProducts = compensation[0].ProductsList!;

                    for(int i = 0; i< llstProducts.Count; i++)
                    {
                        var _compensation = new LiquidationCompensationOutputDTO
                        {
                            CompanyId = _company.Id,
                            AnnouncementNumber = Convert.ToInt32(compensation[0].AnnouncementNumber),
                            Id = compensation[0].Id,
                            TRM = trm.First().TRMValue,
                            FilingDate = compensation[0].CreatedDate,
                            liquidationDate = DateTime.Now.ToShortDateString(),
                            Exporter = _company.NameCompany,
                            ProductCompensated = llstProducts[i].Description,
                            TariffItem= llstProducts[i].OffsetKilogram.ToString(),
                            Agreement = _company.Id.ToString(),
                            ExporterDate = compensation[0].ExporterDate,
                            DestinationCountry = compensation[0].DestinationCountry,
                            MonthCompensate = DateTime.Now.ToString("MMMM"),
                            KilogramsExported = llstProducts[i].Kilogram,
                            OffsetKilogram = llstProducts[i].OffsetKilogram,
                            OffsetValueKilogram = (trm.First().TRMValue * llstProducts[i].OffsetKilogram),
                            CompensationValue = (llstProducts[i].OffsetKilogram) * (trm.First().TRMValue * llstProducts[i].OffsetKilogram)

                        };

                        lstLiquidatinCompensation.Add(_compensation);
                    }

                }
            }

            return new OkObjectResult(new ResultResponse(lstLiquidatinCompensation) { Message = string.Format(ResultResponse.ENTITY_GET, lstLiquidatinCompensation) });
        }




        private List<PreapprovedData> CalculoRound1(List<PreapprovedData> preaprobadoInicial, List<TrmDTO> ValueTableTrm)
        {
            //List<PreapprovedData> lstPreaprobado = new List<PreapprovedData>();
            List<PreapprovedData> LstRound1 = new List<PreapprovedData>();
            //LstRound1 = null;
            //double Excedentes = 0;
            double amountRound1 = 0;
            double SumaTotal = 0;

            foreach (var item in preaprobadoInicial)
            {
               //item.Amount += item2.Residue;
               if (item.Amount >= ValueTableTrm.First().InitialDivision)  //
               {
                    //item.Amount = ValueTableTrm.First().InitialDivision;
                    amountRound1 = ValueTableTrm.First().InitialDivision;
                }
               else 
               {
                    amountRound1 = item.Amount;
                    //SumaTotal = SumaTotal + item.Amount;
                }


                var aprovved = new PreapprovedData()
                {
                    Company = item.Company,
                    Amount = amountRound1,
                    //Excedentes = 
                    Percent = item.Percent,
                };

                SumaTotal = SumaTotal + amountRound1;  // item.Amount;
                LstRound1!.Add(aprovved);

            }


            lstRound.TotalRound1 = SumaTotal;
            lstRound.Excedente1 = (ValueTableTrm.First().MonthlyBudget - Convert.ToDouble(lstRound.TotalRound1));
            

            return LstRound1!;

        }


        private Round CeroUno(Round lstRound)
        {
            int contador = 0;
            List<PreapprovedData> lstpreaprobado = new List<PreapprovedData>();
            List<PreapprovedData> lstRound1 = new List<PreapprovedData>();

            lstpreaprobado = (List<PreapprovedData>)lstRound.lstPreapproved!;

            lstRound1 = (List<PreapprovedData>)lstRound.lstRound1!;

            for (int i = 0; i < lstpreaprobado.Count; i++)
            {

                if (lstpreaprobado[i].Amount == lstRound1[i].Amount)
                {
                    //lstRound1.First().CeroUnoCol = 0;
                    contador += 0;
                }
                else
                {
                    contador += 1;
                }

                lstRound.NumEmpresasExcede = contador;

            }

            return lstRound;

        }



        private List<PreapprovedData> CalculoRound2(Round lstData, List<TrmDTO> ValueTableTrm)
        {
            List<PreapprovedData> LstRound2 = new List<PreapprovedData>();
            //LstRound1 = null;
            //double Excedentes = 0;
            double amountRound2 = 0;
            double SumaTotal = 0;

            List<PreapprovedData> lstPreaprobado = new List<PreapprovedData>();
            List<PreapprovedData> lstRound1 = new List<PreapprovedData>();

            lstPreaprobado = (List<PreapprovedData>)lstData.lstPreapproved!;
            lstRound1 = (List<PreapprovedData>)lstData.lstRound1!;


            for (var i=0; i < lstPreaprobado.Count; i++ )
            {
                
                if (lstPreaprobado[i].Amount  == lstRound1[i].Amount)
                {
                    amountRound2 = lstRound1[i].Amount;
                }
                else 
                  if(lstPreaprobado[i].Amount > lstRound1[i].Amount)
                  {
                    amountRound2 = lstRound1[i].Amount + 0;    //lstData.Excedente1;
                    //SumaTotal = SumaTotal + item.Amount;
                  }


                var aprovved = new PreapprovedData()
                {
                    Company = lstPreaprobado[i].Company,
                    Amount = amountRound2,
                    //Excedentes = 
                    Percent = lstPreaprobado[i].Percent,
                };

                SumaTotal = SumaTotal + amountRound2;  // item.Amount;
                LstRound2!.Add(aprovved);

            }


            lstRound.TotalRound1 = SumaTotal;
            lstRound.Excedente1 = (ValueTableTrm.First().MonthlyBudget - Convert.ToDouble(lstRound.TotalRound1));
            lstRound.ExcedenteIndivd = Convert.ToDouble(lstRound.Excedente1) - Convert.ToDouble(lstRound.NumEmpresasExcede);


            return LstRound2!;

        }


        private List<double> Excedentes(Round lstData)
        {
            List<double> LstExcedente = new List<double>();
            double excedente = 0;

            List<PreapprovedData> lstPreaprobado = new List<PreapprovedData>();
            List<PreapprovedData> lstRound2 = new List<PreapprovedData>();

            lstPreaprobado = (List<PreapprovedData>)lstData.lstPreapproved!;
            lstRound2 = (List<PreapprovedData>)lstData.lstRound2!;


            for (var i = 0; i < lstPreaprobado.Count; i++)
            {
                if (lstPreaprobado[i].Amount == lstRound2[i].Amount)
                {
                    excedente = (lstPreaprobado[i].Amount - lstRound2[i].Amount) * (-1);
                    LstExcedente.Add(excedente);
                }
            }

            return LstExcedente!;

        }



        private List<double> Excedentes1(Round lstData)
        {
            List<double> LstExcedente = new List<double>();
            List<double> LstExcedente1 = new List<double>();
            double excedente = 0;
            double excedente1 = 0;

            List<PreapprovedData> lstPreaprobado = new List<PreapprovedData>();
            List<PreapprovedData> lstRound2 = new List<PreapprovedData>();

            lstPreaprobado = (List<PreapprovedData>)lstData.lstPreapproved!;
            lstRound2 = (List<PreapprovedData>)lstData.lstRound2!;


            for (var i = 0; i < lstPreaprobado.Count; i++)
            {

                if (lstPreaprobado[i].Amount == lstRound2[i].Amount)
                {

                    excedente = (lstPreaprobado[i].Amount - lstRound2[i].Amount) * (-1);
                    if (excedente > 0)
                    {
                        excedente1 = excedente;
                    }
                    else
                    {
                        excedente1 = 0;
                    }
                   
                    LstExcedente1.Add(excedente1);

                }

            }

            return LstExcedente!;

        }


        private List<PreapprovedData> CalculoFinal(Round lstData)
        {
            List<PreapprovedData> LstFinal = new List<PreapprovedData>();
            double amountFinal = 0;
            double SumaTotalFinal = 0;

            List<PreapprovedData> lstPreaprobado = new List<PreapprovedData>();
            List<PreapprovedData> lstRound2 = new List<PreapprovedData>();

            lstPreaprobado = (List<PreapprovedData>)lstData.lstPreapproved!;
            lstRound2 = (List<PreapprovedData>)lstData.lstRound2!;


            for (var i = 0; i < lstPreaprobado.Count; i++)
            {

                if (lstRound2[i].Amount < lstPreaprobado[i].Amount)
                {
                    amountFinal = (lstRound2[i].Amount + Convert.ToDouble(lstData.ExcedenteIndivd));
                }
                else
                {
                    amountFinal = lstPreaprobado[i].Amount;
                }
                    


                var aprovved = new PreapprovedData()
                {
                    Company = lstPreaprobado[i].Company,
                    Amount = amountFinal,
                    Percent = lstPreaprobado[i].Percent,
                };

                SumaTotalFinal = SumaTotalFinal + amountFinal;
                LstFinal!.Add(aprovved);

            }

            lstRound.TotalFinal = SumaTotalFinal;

            return LstFinal!;

        }

    }
}
