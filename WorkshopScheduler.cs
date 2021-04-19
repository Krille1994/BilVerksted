using System.Collections.Generic;

namespace BilVerksted
{
    public class WorkshopScheduler
    {
        public List<IVehicleToBeRepaired> ListOfVehiclesToBeRepaired = new List<IVehicleToBeRepaired>();

        public void ScheduleVehicle(IVehicleToBeRepaired mose) 
        {
            ListOfVehiclesToBeRepaired.Add(mose);
        }

        public IVehicleToBeRepaired DeliverVehicle()
        { 
            if (ListOfVehiclesToBeRepaired.Count == 0) return null;
            var car = ListOfVehiclesToBeRepaired[0];
            RemoveVehicle(car); 
            return car;
        }
        public void RemoveVehicle(IVehicleToBeRepaired vehicle)
        {
            ListOfVehiclesToBeRepaired.Remove(vehicle);
        }
    }
}