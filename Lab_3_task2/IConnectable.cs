namespace Lab_3_task2
{
    public interface IConnectable
    {
        void Connect(Computer device);
        void Disconnect(Computer device);
        void SendData(Computer device, string data);
        void ReceiveData(string data);
    }
}