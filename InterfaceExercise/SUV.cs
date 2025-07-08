using System;

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
        public int NumberOfSeats { get; set; } = 5;
        public bool HasAutomaticTrunkClose { get; set; } = false;
        public string Logo { get; set; } = "Pontiac";
        public string Country { get; set; } = "Guam";
        public int NumberOfWheels { get; set; } = 4;
        public double Weight { get; set; } = 5000;
        public double MSRP { get; set; } = 314159;
        public double MPG { get; set; } = 13.5;

        public void CompanyDetails()
        {
            Console.WriteLine($"This SUV is from {Logo}, located in {Country}.");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"It has {NumberOfWheels} wheels, {NumberOfSeats} seats, it weighs {Weight} lbs, and it's MPG is {MPG}.");
            Console.WriteLine($"Does it even have an automatic closing trunk door? {HasAutomaticTrunkClose}");
            Console.WriteLine($"It costs ${MSRP * 1.25:F2} but for you my friend it's discounted at ${MSRP * 1.01:F2}. You should buy it.\n");
        }
    }
}
