using Microsoft.Extensions.Configuration;

namespace Omegan.Application.Utils
{
    public class Login
    {
        private readonly IConfiguration _configuration;

        public Login(IConfiguration configuration) {
            _configuration = configuration;
        }

        public async Task<string> PasswordGenerate()
        {
            string passwordRandom = string.Empty;
            Random rdn = new Random();
            char letter;
            
            string lowercase = _configuration.GetSection("PasswordGenerate")["lowercase"];
            string uppercase = _configuration.GetSection("PasswordGenerate")["uppercase"];
            string numbers = _configuration.GetSection("PasswordGenerate")["numbers"];
            string characters = _configuration.GetSection("PasswordGenerate")["characters"];

            int lengthLowercaseString = lowercase.Length;
            int lengthLowercase = 4;            
            for (int i = 0; i < lengthLowercase; i++)
            {
                letter = lowercase[rdn.Next(lengthLowercaseString)];
                passwordRandom += letter.ToString();
            }

            int lengthUppercaseString = uppercase.Length;
            int lengthUppercase = 4;
            for (int i = 0; i < lengthUppercase; i++)
            {
                letter = uppercase[rdn.Next(lengthUppercaseString)];
                passwordRandom += letter.ToString();
            }

            int lengthNumbersString = numbers.Length;
            int lengthNumbers = 3;
            for (int i = 0; i < lengthNumbers; i++)
            {
                letter = numbers[rdn.Next(lengthNumbersString)];
                passwordRandom += letter.ToString();
            }

            int lengthCharactersString = characters.Length;
            int lengthCharacters = 1;
            for (int i = 0; i < lengthCharacters; i++)
            {
                letter = characters[rdn.Next(lengthCharactersString)];
                passwordRandom += letter.ToString();
            }

            return passwordRandom;
        }
    }
}
