namespace ComputerNet.BLL.Interfaces
{
    public interface INetworkService
    {
        bool CheckIPRange(int computerId, long adress);
    }
}
