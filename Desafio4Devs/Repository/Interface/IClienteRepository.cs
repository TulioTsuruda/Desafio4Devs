using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio4Devs.Models;

namespace Desafio4Devs.Repository.Interface
{
    public interface IClienteRepository
    {
        void insertCliente(Cliente insert);
        void searchCliente(Cliente search);
        void insertCategoria(Cliente addCateg);
    }
}
