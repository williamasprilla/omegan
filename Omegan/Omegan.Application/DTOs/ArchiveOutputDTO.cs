using AutoMapper;
using Omegan.Domain;

namespace Omegan.Application.DTOs
{
    [AutoMap(typeof(Archive), ReverseMap = true)]
    public class ArchiveOutputDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Base64 { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public bool Status { get; set; }

        public bool Active { get; set; }
    }
}
