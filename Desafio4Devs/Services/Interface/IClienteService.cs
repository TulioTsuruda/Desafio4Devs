using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio4Devs.Models;

namespace Desafio4Devs.Services.Interface
{
    public interface IClienteService
    {
        void addCliente (Cliente add);
        void getCliente (Cliente cliente);
        void setCategoria(Cliente categoria);
    }
}
