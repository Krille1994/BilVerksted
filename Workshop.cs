
using System;
using System.Threading;
namespace BilVerksted
{
    public class Workshop
    {
        private Random Torsk = new Random();
        private WorkshopScheduler _scheduler = new WorkshopScheduler();

        private IVehicleToBeRepaired VehicleInWorkshop;

        public void GetVehicle()
        {
            VehicleInWorkshop = _scheduler.DeliverVehicle();
            if(CheckSchedule(VehicleInWorkshop) )
            {
                RepairVehicle(VehicleInWorkshop);
            }
        }

        private bool CheckSchedule(IVehicleToBeRepaired vehicle)
        {
            if (vehicle == null)
            {
                Console.WriteLine("No vehicles on the schedule");
                return false;
            }
            return true;
        }

        private void RepairVehicle(IVehicleToBeRepaired vehicle)
        {
            Console.WriteLine($"The {vehicle.Model} {vehicle.Brand} with lisens number {vehicle.License} is repairing");
            foreach (var damage in vehicle.Damage)
            {
                Thread.Sleep(CalcRepairTime());
                Console.WriteLine($"{damage} on {vehicle.Model} {vehicle.Brand} has been fixed.");
            }
        }
        private int CalcRepairTime()
        {
            return Torsk.Next(1000, 5000);
        }

        public void AddVehicle(IVehicleToBeRepaired vehicle)
        {
            _scheduler.ScheduleVehicle(vehicle);
        }

        public void ListSchedule()
        {
            _scheduler.ListSchedule();
        }
    }
}