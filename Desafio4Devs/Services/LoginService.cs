using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio4Devs.Models;
using Desafio4Devs.Repository;
using Desafio4Devs.Repository.Interface;
using Desafio4Devs.Services.Interface;

namespace Desafio4Devs.Services
{
    public class LoginService : ILoginService
    {

        private readonly ILoginRepository _repository;

        public LoginService()
        {
            _repository = new LoginRepository();
        }

        public bool GetLogin(Login signin)
        {
            return _repository.GetSignIn(signin);
        }

        public void SetRegister(Login signup)
        {
            _repository.InsertRegister(signup);
        }
    }
}
