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
        public bool HasExtendedCab { get; set; }
        public bool HasBedLiner { get; set; }
        public string Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Country { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfWheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MSRP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MPG { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CompanyDetails()
        {
            Console.WriteLine($"This truck is from {Logo}, located in {Country}.");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"It has {NumberOfWheels} wheels, it weighs {Weight} lbs, and it's MPG is {MPG}.");
            Console.WriteLine($"Does it even have an extended cab? {HasExtendedCab}");
            Console.WriteLine($"What about a bed liner? {HasBedLiner}");
            Console.WriteLine($"It costs ${MSRP * 1.25} but for you my friend it's ${MSRP * 1.01}. You should buy it.");
        }
    }
}
