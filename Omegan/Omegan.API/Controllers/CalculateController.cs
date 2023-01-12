using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompany;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementByCompanyStateQuery;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementsById;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using Omegan.Application.Features.Companies.Queries.GetCountries;
using Omegan.Application.Features.TRM.Queries;
using Omegan.Application.Utils;
using Omegan.Domain;
using System.Linq;

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
            var queryCompanies = new GetAllCompanyAnnouncementsQuery(2);
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


            return new OkObjectResult(new ResultResponse(lstRound) { Message = string.Format(ResultResponse.ENTITY_GET, lstRound) });
        }





        private List<PreapprovedData> CalculoRound1(List<PreapprovedData> preaprobadoInicial, List<TrmDTO> ValueTableTrm)
        {
            List<PreapprovedData> lstPreaprobado = new List<PreapprovedData>();
            double Excedentes = 0;
            double SumaTotal = 0;

            foreach (var item in preaprobadoInicial)
            {
               //item.Amount += item2.Residue;
               if (item.Amount >= ValueTableTrm.First().InitialDivision)  //
               {
                  item.Amount = ValueTableTrm.First().InitialDivision;
                }
               else 
               {
                  item.Amount = item.Amount;
                    //SumaTotal = SumaTotal + item.Amount;
                }


                var aprovved = new PreapprovedData()
                {
                    Company = item.Company,
                    Amount = item.Amount,
                    //Excedentes = 
                    Percent = item.Percent,
                };

                SumaTotal = SumaTotal + item.Amount;
                lstPreaprobado.Add(aprovved);

            }


            lstRound.TotalRound1 = SumaTotal;
            lstRound.Excedente1 = (ValueTableTrm.First().MonthlyBudget - Convert.ToDouble(lstRound.TotalRound1));
            

            return lstPreaprobado;

        }


        private Round CeroUno(Round lstRound)
        {
            List<PreapprovedData> lstpreaprobado = new List<PreapprovedData>();
            List<PreapprovedData> lstRound1 = new List<PreapprovedData>();

            lstpreaprobado = (List<PreapprovedData>)lstRound.lstPreapproved!;

            lstRound1 = (List<PreapprovedData>)lstRound.lstRound1!;

            //for(int i = 0; i <= lstpreaprobado.Count; i++)
            //{
            //    /lstRound1.FindIndex
            //}



            if(lstpreaprobado.First().Amount == lstRound1.First().Amount)
            {
                lstRound1.First().CeroUnoCol = 0;
            }
            else
            {
                lstRound1.First().CeroUnoCol = 1;
            }


            

            return lstRound;

        }



        private List<PreapprovedData> Round2(List<PreapprovedData> preaprobadoInicial, List<TrmDTO> ValueTableTrm)
        {
            List<PreapprovedData> lstPreaprobado = new List<PreapprovedData>();
            double SumaTotal = 0;

            foreach (var item in preaprobadoInicial)
            {
                //item.Amount += item2.Residue;
                if (item.Amount >= ValueTableTrm.First().InitialDivision)  //
                {
                    item.Amount = ValueTableTrm.First().InitialDivision;
                    //item.Residue = 0;
                    //item.Percent = 100;
                    //item.Alert = false;
                    //item2.Residue = item.Amount - ValueTableTrm.First().InitialDivision;
                    SumaTotal = SumaTotal + ValueTableTrm.First().InitialDivision;
                }
                else
                {
                    //item.Amount += item2.Residue;
                    item.Amount = item.Amount;
                    //item.Residue = 0;
                    //item.Percent = 100;
                    //item.Alert = false;
                    //item2.Residue = item.Amount;
                    SumaTotal = SumaTotal + item.Amount;
                }



                
                var aprovved = new PreapprovedData()
                {
                    Company = item.Company,
                    Amount = item.Amount,
                    //Residue = item.Residue,
                    Percent = item.Percent,
                    //Alert = true

                };

                lstPreaprobado.Add(aprovved);

                aprovved.datosTotales!.SumaTotalRound1 = SumaTotal;
                
                //lstPreaprobado.Add(new PreapprovedData() { Company = "Total", sumaTotal = SumaTotal });
            }




            return lstPreaprobado;

        }



        //private List<PreapprovedData> Round1(List<PreapprovedData> preaprobadoInicial, List<TrmDTO> ValueTableTrm)
        //{
        //    //return new PreapprovedData() { };

        //    foreach (var item in preaprobadoInicial)
        //    {
        //        if (item.Alert)// Se ubica la compañia a la que se le debe sumar valores
        //        {
        //            foreach (var item2 in preaprobadoInicial) //Se recorre de nuevo para ubicar de donde sumarle a la compañia que le falta
        //            {
        //                //item.Amount += item2.Residue;
        //                if (item.Amount >= ValueTableTrm.First().InitialDivision)  //
        //                {

        //                    item.Amount = ValueTableTrm.First().InitialDivision;
        //                    item.Residue = 0;
        //                    item.Percent = 100;
        //                    item.Alert = false;
        //                    //item2.Residue = item.Amount - ValueTableTrm.First().InitialDivision;
        //                }
        //                else
        //                {
        //                    //item.Amount += item2.Residue;
        //                    item.Amount = ValueTableTrm.First().InitialDivision;
        //                    item.Residue = 0;
        //                    item.Percent = 100;
        //                    item.Alert = false;
        //                    //item2.Residue = item.Amount;


        //                }

        //            }
        //        }
        //    }

        //    return preaprobadoInicial;

        //}

    }
}
