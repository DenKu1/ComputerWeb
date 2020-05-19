using ComputerNet.BLL.DTO;
using System;
using System.Security.Claims;

namespace ComputerNet.BLL.Interfaces
{
    public interface IUserService : IDisposable
    {       
        void CreateUser(UserRegisterDTO data);
        ClaimsIdentity Login(UserLoginDTO data);
    }
}
