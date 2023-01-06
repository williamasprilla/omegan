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
            Round lstRound = new Round();
            decimal percent = 0;
            double Residue = 0;
            bool _warning = false;

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

                foreach(var co in country)
                {
                    var query = new GetAnnouncementByCompanyStateQuery(_company.Id, 2);
                    var announcement = await _mediator.Send(query);
                    foreach(var ann in announcement)
                    {
                       if(co.Id == ann.IdDestinationCountry)
                       {
                            foreach(var product in ann.ProductsList!)
                            {
                                AddAnnouncementCountry += (trm.First().TRMValue * (co.CurrentValue/1000) * Convert.ToDouble(product.Kilogram));
                            }

                       }
                    }
                
                    TotalCompany +=  Math.Round(AddAnnouncementCountry,2);
                    AddAnnouncementCountry = 0;
                }

                //Si el total anunciado por la compañia es menor o igual al total asignado para el mes
                if(TotalCompany <= trm.First().InitialDivision)
                {
                    //decimal porcentaje = Convert.ToDecimal(((TotalCompany * 100) / trm.First().InitialDivision));
                    percent = decimal.Round(100, 2);

                   
                    Residue += (trm.First().InitialDivision - TotalCompany);

                  
                    var aprovved = new PreapprovedData()
                    {
                        Company = _company.NameCompany,
                        Amount = TotalCompany,
                        Residue = Residue,
                        Percent = percent,
                        Alert = false

                    };

                    lstPreaprobado.Add(aprovved);

                    //_warning

                }
                else
                {
                    //_warning = true;
                    decimal porcentaje = Convert.ToDecimal(((TotalCompany * 100) / trm.First().InitialDivision));
                    percent = decimal.Round(porcentaje, 2);


                    Residue += (trm.First().InitialDivision - TotalCompany);


                    var aprovved = new PreapprovedData()
                    {
                        Company = _company.NameCompany,
                        Amount = TotalCompany,
                        Residue = 0,
                        Percent = percent,
                        Alert= true

                    };

                    lstPreaprobado.Add(aprovved);


                }



                lstRound.lstRound1 = lstPreaprobado;
                

                TotalCompany = 0;
                contcompany += 1;
            }

            if(_warning)
            {
                //se debe calcular round 1
                Round1(lstPreaprobado, trm);

            }

            return new OkObjectResult(new ResultResponse(lstRound) { Message = string.Format(ResultResponse.ENTITY_GET, lstRound) });
        }

        




        private List<PreapprovedData> Round1(List<PreapprovedData> preaprobadoInicial, List<TrmDTO> ValueTableTrm)
        {
            //return new PreapprovedData() { };

            foreach(var item in preaprobadoInicial)
            {
                if(item.Alert)// Se ubica la compañia a la que se le debe sumar valores
                {
                    foreach(var item2 in preaprobadoInicial ) //Se recorre de nuevo para ubicar de donde sumarle a la compañia que le falta
                    {
                        item.Amount += item2.Residue;
                        if(item.Amount >= ValueTableTrm.First().InitialDivision)  //
                        {

                            item.Amount = ValueTableTrm.First().InitialDivision;
                            item.Residue=0;
                            item.Percent = 100;
                            item.Alert = false;
                            item2.Residue = item.Amount - ValueTableTrm.First().InitialDivision;
                        }
                        else
                        {
                            //item.Amount += item2.Residue;
                            item.Amount = ValueTableTrm.First().InitialDivision;
                            item.Residue = 0;
                            item.Percent = 100;
                            item.Alert = false;
                            item2.Residue = item.Amount;


                        }

                    }
                }
            }

            return preaprobadoInicial;

        }

    }
}
