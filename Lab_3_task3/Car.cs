using System;

namespace Lab_3_task3
{
    public class Car: Vehicle, IDriveable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving.");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped.");
        }
    }
}