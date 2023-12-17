using System;

namespace Lab_3_task3
{
    public class Truck: Vehicle, IDriveable
    {
        public void Move()
        {
            Console.WriteLine("Truck is moving.");
        }

        public void Stop()
        {
            Console.WriteLine("Truck has stopped.");
        }
    }
}