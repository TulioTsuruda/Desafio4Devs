using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio4Devs.Models;

namespace Desafio4Devs.Services.Interface
{
    public interface ILoginService
    {
        bool GetLogin(Login signin);
        void SetRegister(Login signup);
    }
}
