namespace Lab_3_task2
{
    public abstract class Computer
    {
        public string IPAddress { get; set; }
        public double Power { get; set; }
        public string OSType { get; set; }

        public void SendData(Computer receiver, string data)
        {
            throw new System.NotImplementedException();
        }

        public void ReceiveData(string data)
        {
            throw new System.NotImplementedException();
        }
    }
}