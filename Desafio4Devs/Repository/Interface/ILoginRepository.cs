using Desafio4Devs.Models;

namespace Desafio4Devs.Repository.Interface
{
    public interface ILoginRepository
    {
        bool GetSignIn(Login signin);

        void InsertRegister(Login signup);
    }
}
