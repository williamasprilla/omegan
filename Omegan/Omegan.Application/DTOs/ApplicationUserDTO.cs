namespace Omegan.Application.DTOs
{
    public class ApplicationUserDTO
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
