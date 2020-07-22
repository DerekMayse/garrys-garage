using System;

namespace garys_garage
{


public class Cessna : Vehicle {  // Propellor light aircraft
    public double FuelCapacity { get; set; }


    public void RefuelTank () {  }

        public override void Drive () {
        Console.WriteLine("Zoooooom!");
    }

    public override void Turn(){
        Console.WriteLine("Making a right instead");
    }

    public override void Stop(){
        Console.WriteLine("Running that stop sign!!!");
    }
}
}