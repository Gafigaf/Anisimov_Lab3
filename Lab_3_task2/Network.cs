using System.Collections.Generic;

namespace Lab_3_task2
{
    public class Network
    {
        public List<Computer> Devices { get; set; }

        public void SimulateDataTransfer(Computer sender, Computer receiver, string data)
        {
            sender.SendData(receiver, data);
            receiver.ReceiveData(data);
        }
    }
}