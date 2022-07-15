using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public static int NumberOfCars = 0;
    }
}
