using AutoMapper;
using Omegan.Application.DTOs;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Companies.Queries.GetCompanyByIdWithArchives
{
    [AutoMap(typeof(Company), ReverseMap = true)]
    public class ArchivesByCompanyDTO
    {

        public string Name { get; set; } = string.Empty;

        public string Base64 { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public bool State { get; set; }

        public int CompanyId { get; set; }

        public virtual Company? Company { get; set; }

    }

    
}
