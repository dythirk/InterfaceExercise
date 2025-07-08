using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {
        public Truck(string logo,
            string country,
            int numberOfWheels,
            double weight,
            double mSRP,
            double mPG,
            bool hasExtendedCab,
            bool hasBedLiner
           )
        {
            Logo = logo;
            Country = country;
            NumberOfWheels = numberOfWheels;
            Weight = weight;
            MSRP = mSRP;
            MPG = mPG;
            HasExtendedCab = hasExtendedCab;
            HasBedLiner = hasBedLiner;
        }
        public bool HasExtendedCab { get; set; } = false;
        public bool HasBedLiner { get; set; } = false;
        public string Logo { get; set; } = "Oldsmobile";
        public string Country { get; set; } = "Solomon Islands";
        public int NumberOfWheels { get; set; } = 4;
        public double Weight { get; set; } = 3500;
        public double MSRP { get; set; } = 314159;
        public double MPG { get; set; } = 21.3;
        public void CompanyDetails()
        {
            Console.WriteLine($"This truck is from {Logo}, located in {Country}.");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"It has {NumberOfWheels} wheels, it weighs {Weight} lbs, and it's MPG is {MPG}.");
            Console.WriteLine($"Does it even have an extended cab? {HasExtendedCab}");
            Console.WriteLine($"What about a bed liner? {HasBedLiner}");
            Console.WriteLine($"It costs ${MSRP * 1.25:F2} but for you my friend it's discounted at ${MSRP * 1.01:F2}. You should buy it.\n");
        }
    }
}
