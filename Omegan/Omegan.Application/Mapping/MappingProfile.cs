using AutoMapper;
using Omegan.Application.DTOs;
using Omegan.Application.Features.Companies.Commands.CreateCompany;
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

        }
    }
}
