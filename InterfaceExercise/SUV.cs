using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
        public SUV
            (
            string logo,
            string country,
            int numberOfWheels,
            double weight,
            double mSRP,
            double mPG,
            int numberOfSeats,
            bool hasAutomaticTrunkClose
            )
        {
            Logo = logo;
            Country = country;
            NumberOfWheels = numberOfWheels;
            Weight = weight;
            MSRP = mSRP;
            MPG = mPG;
            NumberOfSeats = numberOfSeats;
            HasAutomaticTrunkClose = hasAutomaticTrunkClose;
        }
        public int NumberOfSeats { get; set; }
        public bool HasAutomaticTrunkClose { get; set; }
        public string Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Country { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfWheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MSRP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MPG { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CompanyDetails()
        {
            Console.WriteLine($"This SUV is from {Logo}, located in {Country}.");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"It has {NumberOfWheels} wheels, {NumberOfSeats} seats, it weighs {Weight} lbs, and it's MPG is {MPG}.");
            Console.WriteLine($"Does it even have an automatic closing trunk door? {HasAutomaticTrunkClose}");
            Console.WriteLine($"It costs ${MSRP * 1.25} but for you my friend it's ${MSRP * 1.01}. You should buy it.");
        }
    }
}
