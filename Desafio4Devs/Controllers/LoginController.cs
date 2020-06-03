using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio4Devs.Models;
using Desafio4Devs.Services;
using Desafio4Devs.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Desafio4Devs.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController()
        {
            _loginService = new LoginService();
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Signin()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        // POST: 
        [HttpPost]
        public bool Login(Login signin)
        {
            try
            {
                return _loginService.GetLogin(signin);
            }
            catch 
            {
                return false;
            }
        }

        [HttpPost]
        public bool Register(Login signup)
        {
            try
            {
                _loginService.SetRegister(signup);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
