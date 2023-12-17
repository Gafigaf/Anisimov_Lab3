using System;
using System.Collections.Generic;

namespace Lab_3_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficSimulation simulation = new TrafficSimulation
            {
                Vehicles = new List<Vehicle>
                {
                    new Car { Speed = 60, Size = 5, Type = "Car" },
                    new Truck { Speed = 50, Size = 10, Type = "Truck" },
                },
                Roads = new List<Road>
                {
                    new Road { Length = 1000, Width = 10, Lanes = 2, TrafficLevel = 0.5 },
                    new Road { Length = 2000, Width = 20, Lanes = 4, TrafficLevel = 0.7 },
                    new Road { Length = 3000, Width = 30, Lanes = 6, TrafficLevel = 0.9 }
                }
            };
            
            foreach (var vehicle in simulation.Vehicles)
            {
                if (vehicle is IDriveable driveableVehicle)
                {
                    foreach (var road in simulation.Roads)
                    {
                        Console.WriteLine(
                            $"Vehicle of type {vehicle.Type} is driving on the road with length {road.Length}.");
                        driveableVehicle.Move();
                        if (road.TrafficLevel > 0.8)
                        {
                            Console.WriteLine("Traffic level is high. Vehicle is stopping.");
                            driveableVehicle.Stop();
                        }
                        else
                        {
                            Console.WriteLine("Traffic level is low. Vehicle is continuing to move.");
                        }
                    }
                }
            }
        }
    }
}