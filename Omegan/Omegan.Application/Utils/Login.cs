namespace Omegan.Application.Utils
{
    public class Login
    {
        public async Task<string> PasswordGenerate()
        {
            string passwordRandom = string.Empty;
            Random rdn = new Random();
            char letter;
            
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "1234567890";
            string characters = "-*";

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
