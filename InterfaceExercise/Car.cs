using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public Car
            (
            string logo,
            string country,
            int numberOfWheels,
            double weight,
            double mSRP,
            double mPG,
            bool hasTrunk,
            bool has2Doors
           )
        {
            Logo = logo;
            Country = country;
            NumberOfWheels = numberOfWheels;
            Weight = weight;
            MSRP = mSRP;
            MPG = mPG;
            HasTrunk = hasTrunk;
            Has2Doors = has2Doors;
        }
        public bool HasTrunk { get; set; } = true;
        public bool Has2Doors { get; set; } = false;
        public string Logo { get; set; } = "Plymouth";
        public string Country { get; set; } = "Kiribati";
        public int NumberOfWheels { get; set; } = 4;
        public double Weight { get; set; } = 2500;
        public double MSRP { get; set; } = 30000;
        public double MPG { get; set; } 35.4;
        public void CompanyDetails()
        {
            Console.WriteLine($"This car is from {Logo}, located in {Country}.");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"It has {NumberOfWheels} wheels, it weighs {Weight} lbs, and it's MPG is {MPG}.");
            Console.WriteLine($"Is it a coupe? {Has2Doors}");
            Console.WriteLine($"Does it have a trunk? {HasTrunk}");
            Console.WriteLine($"It costs ${MSRP * 1.25} but for you my friend it's ${MSRP * 1.01}. You should buy it.");
        }
    }
}
