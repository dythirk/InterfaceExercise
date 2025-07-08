using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public Car(
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
        public bool HasTrunk { get; set; }
        public bool Has2Doors { get; set; }
        public string Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Country { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfWheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MSRP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MPG { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CompanyDetails()
        {
            throw new NotImplementedException();
        }
        public void DisplayDetails()
        {
            throw new NotImplementedException();
        }
    }
}
