using System;
using System.Collections.Generic;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero zeroCar = new Zero()
            {
                MainColor = "red",
                BatteryKWh = 7.5,
                MaximumOccupancy = "two",

            };

            Tesla teslaCar = new Tesla()
            {
                MainColor = "blue",
                BatteryKWh = 8.7,
                MaximumOccupancy = "three",
            };

            Ram ramCar = new Ram()
            {
                MainColor = "yellow",
                MaximumOccupancy = "four",
                FuelCapacity = 4.3,

            };

            Cessna cessnaCar = new Cessna()
            {
                MainColor = "violet",
                MaximumOccupancy = "twenty-three",
                FuelCapacity = 10.7,
            };

            List<Vehicle> garage = new List<Vehicle>();
            garage.Add(cessnaCar);
            garage.Add(ramCar);
            garage.Add(teslaCar);
            garage.Add(zeroCar);



            cessnaCar.Drive();
            ramCar.Drive();
            teslaCar.Drive();
            zeroCar.Drive();

            cessnaCar.Turn();
            ramCar.Turn();
            teslaCar.Turn();
            zeroCar.Turn();

            cessnaCar.Stop();
            ramCar.Stop();
            teslaCar.Stop();
            zeroCar.Stop();








        }
    }
}
