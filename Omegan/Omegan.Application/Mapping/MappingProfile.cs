using AutoMapper;
using Omegan.Application.DTOs;
using Omegan.Application.Features.Announcements.Commands;
using Omegan.Application.Features.Announcements.Commands.UpdateAnnouncement;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementById;
using Omegan.Application.Features.Archives.Commands.CreateArchive;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
using Omegan.Application.Features.Companies.Commands.UpdateCompany;
using Omegan.Application.Features.Companies.Queries.GetAllCompanyAnnouncements;
using Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives;
using Omegan.Application.Features.Companies.Queries.GetCompanyByUserId;
using Omegan.Application.Features.Companies.Queries.GetCountries;
using Omegan.Application.Features.Compensation.Commands.CreateCompensation;
using Omegan.Application.Features.Compensation.Commands.UpdateCompensation;
using Omegan.Application.Features.Compensation.Querys;
using Omegan.Application.Features.Countries.Commands.CreateCountry;
using Omegan.Application.Features.Countries.Commands.DeleteCountry;
using Omegan.Application.Features.Countries.Commands.UpdateCountry;
using Omegan.Application.Features.Products.Queries.GetProductList;
using Omegan.Application.Features.TRM.Commands.CreateTRM;
using Omegan.Application.Features.TRM.Commands.UpdateTRM;
using Omegan.Application.Features.TRM.Queries;
using Omegan.Domain;
using System.Reflection;

namespace Omegan.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            CreateMap<CreateCompanyCommandMapper, Company>()
                .ForMember(p => p.UserId, x=> x.MapFrom(y => y.UserId))
                .ForMember(p => p.Archives, x => x.MapFrom(y => y.Archives));

            CreateMap<CreateAnnouncementCommandMapper, Announcement>()
                .ForMember(x => x.ProductAnnouncements, options => options.MapFrom(MapProductAnnouncement));


            CreateMap<Announcement, AnnouncementOuputDTO>()
            .ForMember(x => x.ProductsList, options => options.MapFrom(MapProductList));



            CreateMap<CreateCompensationCommandMapper, Compensation>()
                .ForMember(x => x.ProductCompensation, options => options.MapFrom(MapProductCompensation));




            //Archive
            CreateMap<Archive, ArchivesByCompanyDTO>();
            CreateMap<CreateCountryCommandMapper, Country>();
            CreateMap<UpdateCountryCommandMapper, Country>();
            CreateMap<DeleteCountryCommandMapper, Country>();

            //Country
            CreateMap<Country, GetCountriesDTO>();
            CreateMap<UpdateCompanyCommandMapper, Company>();
            CreateMap<CreateArchiveCommandMapper, Archive>();
            CreateMap<UpdateAnnouncementCommandMapper, Announcement>();

            //TRM
            CreateMap<Trm, TrmDTO>();
            CreateMap<CreateTRMCommandMapper, Trm>();
            CreateMap<UpdateTRMCommandMapper, Trm>();

            //Compensation
            CreateMap<Compensation, CompensationCompanyDTO>();
            CreateMap<CreateCompensationCommandMapper, Compensation>();
            CreateMap<UpdateCompensationCommandMapper, Compensation>();

            //Announcement
            CreateMap<Announcement, AnnouncementDTO>()
           .ForMember(x => x.ProductsList, options => options.MapFrom(MapProductList1));

            CreateMap<Announcement, AnnouncementDTO>()
          .ForMember(x => x.ProductsList, options => options.MapFrom(MapProductList1));



        }

        private object MapProductList(Announcement announcement, AnnouncementOuputDTO announcementOuputDTO)
        {
            var result = new List<ProductkDTO>();

            if (announcementOuputDTO == null) { return result; }

            foreach (var product in announcement.ProductAnnouncements!)
            {
                result.Add(new ProductkDTO() { Id = product.ProductId, TariffItem = product.Product!.TariffItem, Description = product.Product.Description, Kilogram = product.Kilogram });
            }

            return result;
        }



        private object MapProductList1(Announcement announcement, AnnouncementDTO announcementDTO)
        {
            var result = new List<ProductkDTO>();

            if (announcementDTO == null) { return result; }

            foreach (var product in announcement.ProductAnnouncements!)
            {
                result.Add(new ProductkDTO() { Id = product.ProductId, TariffItem = product.Product!.TariffItem, Description = product.Product.Description, Kilogram = product.Kilogram });
            }

            return result;
        }



        //private List<ProductoDTO> MapProductList(Announcement announcement , AnnouncementOuputDTO announcementOuputDTO)
        //{
        //    var result = new List<ProductoDTO>();

        //    if (announcementOuputDTO == null) { return result; }

        //    foreach (var product in announcement.ProductAnnouncements)
        //    {
        //        result.Add(new ProductoDTO() { Id = product.ProductId, TariffItem = product.Product.TariffItem , Description = product.Product.Description });
        //    }

        //    return result;
        //}


        private List<ProductAnnouncement> MapProductAnnouncement(CreateAnnouncementCommandMapper createAnnouncementCommandMapper,
            Announcement announcement)
        {
            var result = new List<ProductAnnouncement>();

            if(createAnnouncementCommandMapper.ProductsAnnouncement == null)
            {
                return result;
            }

            foreach(var product in createAnnouncementCommandMapper.ProductsAnnouncement)
            {
                result.Add(new ProductAnnouncement() { ProductId = product.ProductId, Kilogram = product.Kilogram });
            }

            return result;
        }


        private List<ProductCompensation> MapProductCompensation(CreateCompensationCommandMapper createCompensationCommandMapper,
           Compensation compensation)
        {
            var result = new List<ProductCompensation>();

            if (createCompensationCommandMapper.ProductsCompensation == null)
            {
                return result;
            }

            foreach (var product in createCompensationCommandMapper.ProductsCompensation)
            {
                result.Add(new ProductCompensation() { ProductId = product.ProductId, KilogramsExported = product.KilogramsExported, OffsetKilogram = product.OffsetKilogram, Subtotal=product.Subtotal });
            }

            return result;
        }

    }
}
