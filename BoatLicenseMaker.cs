using System;

namespace BilVerksted
{
    public class BoatLicenseMaker : ILicenceMaker
    {
        public Random Jhonny { get; set; } = new Random();

        public string CreateLicense()
        {
            var output = String.Empty;
            output += GenerateCharacters(3);
            output += GenerateNumbers(3);
            return output;
        }

        public string GenerateCharacters(int numberOfCharacters)
        {
            var output = String.Empty;
            for (var i = 0; i < numberOfCharacters; i++)
            {
                output += (char)Jhonny.Next(65, 91);
            }
            return output;
        }

        public string GenerateNumbers(int numberOfNumbers)
        {
            var output = String.Empty;
            for (var i = 0; i < numberOfNumbers; i++)
            {
                output += Jhonny.Next(0, 10);
            }
            return output;
        }
    }

}