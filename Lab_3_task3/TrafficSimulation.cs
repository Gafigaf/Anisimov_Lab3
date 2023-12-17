using System.Collections.Generic;

namespace Lab_3_task3
{
    public class TrafficSimulation
    {
        public List<Vehicle> Vehicles { get; set; }
        public List<Road> Roads { get; set; }

        public void SimulateTraffic()
        {
            foreach (var vehicle in Vehicles)
            {
                if (vehicle is IDriveable driveableVehicle)
                {
                    driveableVehicle.Move();
                    driveableVehicle.Stop();
                }
            }
        }
    }
}