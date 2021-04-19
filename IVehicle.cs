namespace BilVerksted
{
    public interface IVehicle
    {
        public string License { get; set; }
        public string Brand { get; set; }
        public int Model { get; set; }
    }
}