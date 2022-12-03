﻿namespace Omegan.Application.Models.Identity
{
    public class RegistrationRequest
    {
        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string RolName { get; set; } = string.Empty;

    }
}
