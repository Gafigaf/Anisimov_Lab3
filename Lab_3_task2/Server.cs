using System;

namespace Lab_3_task2
{
    public class Server : Computer, IConnectable
    {
        public int MaxConnections { get; set; }

        public void Connect(Computer device)
        {
            Console.WriteLine($"Server connected to {device.IPAddress}.");
        }

        public void Disconnect(Computer device)
        {
            Console.WriteLine($"Server disconnected from {device.IPAddress}.");
        }

        public void SendData(Computer device, string data)
        {
            Console.WriteLine($"Server sent data to {device.IPAddress}.");
        }

        public void ReceiveData(string data)
        {
            Console.WriteLine("Server received data.");
        }
    }
}