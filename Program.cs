using System;

namespace BilVerksted
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new CarLicenseMaker();
            Console.WriteLine(i.CreateLicense());
            Console.WriteLine(i.CreateLicense());
            Console.WriteLine(i.CreateLicense());
            Console.WriteLine(i.CreateLicense());
            Console.WriteLine(i.CreateLicense());
            Console.WriteLine(i.CreateLicense());
            Console.WriteLine(i.CreateLicense());
            Console.WriteLine(i.CreateLicense());
        }
    }
}
