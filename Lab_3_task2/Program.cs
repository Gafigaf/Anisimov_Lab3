using System;
using System.Collections.Generic;

namespace Lab_3_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Network network = new Network
            {
                Devices = new List<Computer>
                {
                    new Server { IPAddress = "192.168.1.1", Power = 1000, OSType = "Linux", MaxConnections = 100 },
                    new Workstation { IPAddress = "192.168.1.2", Power = 500, OSType = "Windows", WorkstationType = "Desktop" },
                    new Router { IPAddress = "192.168.1.3", Power = 200, OSType = "Cisco", PortNumber = 4 }
                }
            };
            
            foreach (var device in network.Devices)
            {
                if (device is IConnectable connectableDevice)
                {
                    foreach (var otherDevice in network.Devices)
                    {
                        if (otherDevice != device)
                        {
                            connectableDevice.Connect(otherDevice);
                        }
                    }
                }
            }
            
            if (network.Devices[0] is Computer sender && network.Devices[1] is Computer receiver)
            {
                network.SimulateDataTransfer(sender, receiver, "Hello, World!");
            }
        }
    }
}
