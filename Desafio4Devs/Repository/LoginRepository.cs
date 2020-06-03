using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio4Devs.Models;
using Desafio4Devs.Repository.Interface;

namespace Desafio4Devs.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private static List<Login> UserList = new List<Login>
        {
            //Criado registro local até ser criado um banco de dados
            //Usuário para fazer testes de Login
            new Login
            {
                ID            = 01,
                //acesso        = "",
                userId        = "tulio",
                firstName     = "Tulio",
                lastName      = "Tsuruda",
                email         = "tulio@email.com",
                //confEmail     = "",
                CPF           = "012345678911",
                password      = "1234",
                //confPass      = "",
                birthDate     = "1987-08-17",
                //gender        = "Masculino",
                cellPhone     = "00 99999-0000",
                Phone         = "000 3698-8523",
                address       = "Rua",
                address2      = "complemento",
                number        = 0001,
                neighborhood  = "Portão",
                city          = "curitiba",
                state         = "parana",
                zipCode       = "810700-000"

            },


        };

        public LoginRepository()
        {
        }

        public bool GetSignIn(Login signin)
        {
            try
            {
                return UserList.Exists(x => x.userId == signin.acesso);
            }
            catch
            {
                try
                {
                    return UserList.Exists(x => x.CPF == signin.acesso);
                }
                catch (Exception)
                {
                    try
                    {
                        return UserList.Exists(x => x.email == signin.acesso);

                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

        }

        public void InsertRegister(Login signup)
        {
            UserList.Add(signup);
        }
    }
}
