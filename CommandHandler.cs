using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace BilVerksted
{
    public class CommandHandler
    {
        private Workshop _workshop;

        public CommandHandler(Workshop workshop)
        {
            _workshop = workshop;
        }

        public void DisplayCommands()
        {
            Console.WriteLine("\nAddVehicle = add a vehicle to the schedule\nWorkOnVehicle = Work on vehicle\nListSchedule = List vehicles in schedule\n");
        }

        public void HandleCommand(string command)
        {
            command = command.ToLower();
            if (command == "addvehicle")
            {
                AddCar();
            }
            if (command == "workonvehicle")
            {
                WorkOnVehicle();
            }
            if (command == "listschedule")
            {
                ListSchedule();
            }
            else return;
        }

        private void ListSchedule()
        {
            _workshop.ListSchedule();
        }

        private void WorkOnVehicle()
        {
            _workshop.GetVehicle();
        }

        private void AddCar()
        {
            var brand = GetVehicleInfo("what is the vehicle brand?");
            var model = Int32.Parse(GetVehicleInfo("what is the vehicle modelyear?"));
            IVehicleToBeRepaired vehicle = new CarToBeRepaired(brand, model);
            GetVehicleProblems(vehicle);
            ShowRecieptForAddedVehicle(vehicle);
            _workshop.AddVehicle(vehicle);
        }

        private void ShowRecieptForAddedVehicle(IVehicleToBeRepaired vehicle)
        {
            Console.WriteLine($"{vehicle.Brand} {vehicle.Model} {vehicle.License}");
            foreach (var damage in vehicle.Damage)
            {
                Console.WriteLine(damage);
            }
        }

        private string GetVehicleInfo(string InfoNeeded)
        {
            Console.WriteLine(InfoNeeded);
            return Console.ReadLine();
        }

        private void GetVehicleProblems(IVehicleToBeRepaired vehicle)
        {
            var problems = new List<string>();
            var problem = "hallo";
            while (problem != "")
            {
                problem = AskForProblem();
                if (problem != "")
                {
                    vehicle.AddProblem(problem);
                }
            }
        }

        private string AskForProblem()
        {
            Console.WriteLine("Write one problem, then hit enter. If you don't have anymore problems hit enter.");
            return Console.ReadLine();
        }

    }
}