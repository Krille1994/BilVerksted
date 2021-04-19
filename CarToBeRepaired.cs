using System.Collections.Generic;

namespace BilVerksted
{
    public class CarToBeRepaired : IVehicleToBeRepaired
    {
        public string License { get; set; }
        public string Brand { get; set; }
        public int Model { get; set; }
        public List<string> Damage { get; set; } = new List<string>();

        public CarToBeRepaired(string brand, int model)
        {
            ILicenceMaker carLicense = new CarLicenseMaker();
            License = carLicense.CreateLicense();
            Brand = brand;
            Model = model;
        }

        public void AddProblem(string problemToBeFixed)
        {
            Damage.Add(problemToBeFixed);
        }

        public string GetDescription()
        {
            var output = $"{Model} {Brand} with license {License}\nProblems:";
            foreach (var problem in Damage)
            {
                output += $"\n {problem}";
            }
            return output;
        }
    }
}