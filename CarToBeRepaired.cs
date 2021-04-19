namespace BilVerksted
{
    public class CarToBeRepaired : ICarToBeRepaired
    {
        public string License { get; set; }
        public string Brand { get; set; }
        public int Model { get; set; }
        public string Damage { get; set; }

        public CarToBeRepaired(string brand, int model, string damage)
        {
            ILicenceMaker carLicense = new CarLicenseMaker();
            License = carLicense.CreateLicense();
            Brand = brand;
            Model = model;
            Damage = damage;
        }
    }
}