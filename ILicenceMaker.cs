using System;

namespace BilVerksted
{
    public interface ILicenceMaker
    {
        public Random Jhonny { get; set; }
        public string CreateLicense();

        public string GenerateCharacters(int numberOfCharacters);
        public string GenerateNumbers(int numberOfNumbers);
    }
}