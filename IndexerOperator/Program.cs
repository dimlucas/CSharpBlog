using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            testGarage();
            Console.ReadKey();
        }

        private static void testGarage()
        {
            Garage garage = new Garage();
            garage.Add(new Car()
            {
                Make = "Porsche",
                Model = "Carrera GT",
                Year = 2011,
                Clean = true,
                DamageAmount = 27
            });
            garage.Add(new Car()
            {
                Make = "Toyota",
                Model = "Yaris",
                Year = 2015,
                Clean = true,
                DamageAmount = 0
            });
            garage.Add(new Car()
            {
                Make = "Ford",
                Model = "Mustang GT",
                Year = 2010,
                Clean = false,
                DamageAmount = 68
            });
            Car cityCar = garage[1];
            Console.WriteLine(String.Format("{0} {1}", cityCar.Make, cityCar.Model));
        }
    }
}
