using System;
using System.Security.Claims;
using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.DAL.Interfaces;
using ComputerNet.DAL.Entities;
using Microsoft.AspNet.Identity;

namespace ComputerNet.BLL.Services
{
    public class UserService : IUserService
    {
        protected readonly IMapper _mp;
        protected readonly IUnitOfWork _db;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _db = unitOfWork;
            _mp = mapper;
        }

        public void CreateUser(UserRegisterDTO userRegisterDTO)
        {
            if (userRegisterDTO == null)
            {
                throw null;
            }

            if ( _db.UserManager.FindByEmail(userRegisterDTO.Email) != null)
            {
                throw new Exception("User with this email already exists");
            }

            if (_db.UserManager.FindByName(userRegisterDTO.UserName) != null)
            {
                throw new Exception("User with this username already exists");
            }

            User user = new User
            {
                UserName = userRegisterDTO.UserName,
                Email = userRegisterDTO.Email
            };

            _db.UserManager.Create(user, userRegisterDTO.Password);
        }      

        public ClaimsIdentity Login(UserLoginDTO userLoginDTO)
        {
            User user = _db.UserManager.Find(userLoginDTO.UserName, userLoginDTO.Password);

            if (user == null)
            {
                throw new Exception("Incorrect username or password");
            }

            ClaimsIdentity identityClaim = _db.UserManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
            
            return identityClaim;
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
