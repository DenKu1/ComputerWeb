using System;

namespace ComputerNet.BLL.Interfaces
{
    public interface INetworkService : IDisposable
    {
        bool CheckIPRange(int computerId, long adress);
    }
}
