using System;

namespace Lab_3_task2
{
    public class Router: Computer, IConnectable
    {
        public int PortNumber { get; set; }

        public void Connect(Computer device)
        {
            Console.WriteLine($"Router connected to {device.IPAddress}.");
        }

        public void Disconnect(Computer device)
        {
            Console.WriteLine($"Router disconnected from {device.IPAddress}.");
        }

        public void SendData(Computer device, string data)
        {
            Console.WriteLine($"Router sent data to {device.IPAddress}.");
        }

        public void ReceiveData(string data)
        {
            Console.WriteLine("Router received data.");
        }
    }
}