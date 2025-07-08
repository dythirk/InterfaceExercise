using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public double Weight { get; set; }
        public double MSRP { get; set; }
        public double MPG { get; set; }

        public void DisplayDetails();
    }
}
