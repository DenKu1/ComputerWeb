using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.WEB.Models;
using Microsoft.Owin.Security;
using System;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace ComputerNet.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mp;

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        public AccountController(IMapper mapper, IUserService userService)
        {
            _userService = userService;
            _mp = mapper;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLoginVM userLoginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(userLoginVM);
            }

            UserLoginDTO userLoginDTO = _mp.Map<UserLoginDTO>(userLoginVM);

            ClaimsIdentity claim;

            try
            {
                claim = _userService.Login(userLoginDTO);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(userLoginVM);
            }
                                
            AuthenticationManager.SignOut();
            AuthenticationManager.SignIn(new AuthenticationProperties { IsPersistent = true }, claim);

            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserRegisterVM userRegisterVM)
        {
            if (!ModelState.IsValid)
            {
                return View(userRegisterVM);
            }

            var userRegisterDTO = _mp.Map<UserRegisterDTO>(userRegisterVM);

            try
            {
                _userService.CreateUser(userRegisterDTO);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(userRegisterVM);
            }

            return RedirectToAction("Login", "Account");
        }

        [AllowAnonymous]
        public ActionResult Logout()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Login", "Account");
        }

    }
}