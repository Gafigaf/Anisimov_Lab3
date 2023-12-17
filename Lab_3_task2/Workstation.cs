using System;

namespace Lab_3_task2
{
    public class Workstation: Computer, IConnectable
    {
        public string WorkstationType { get; set; }

        public void Connect(Computer device)
        {
            Console.WriteLine($"Workstation connected to {device.IPAddress}.");
        }

        public void Disconnect(Computer device)
        {
            Console.WriteLine($"Workstation disconnected from {device.IPAddress}.");
        }

        public void SendData(Computer device, string data)
        {
            Console.WriteLine($"Workstation sent data to {device.IPAddress}.");
        }

        public void ReceiveData(string data)
        {
            Console.WriteLine("Workstation received data.");
        }
    }
}