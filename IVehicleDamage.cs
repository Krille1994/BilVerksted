using System.Collections.Generic;

namespace BilVerksted
{
    public interface IVehicleDamage
    {
        public List<string> Damage { get; set; }
        public void AddProblem(string problemToBeFixed);
    }
}