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
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _cliRepository;

        public ClienteService()
        {
            _cliRepository = new ClienteRepository();
        }

        public void addCliente(Cliente addCli)
        {
            _cliRepository.insertCliente(addCli);
        }

        public void getCliente(Cliente cliente)
        {
            _cliRepository.searchCliente(cliente);
        }

        public void setCategoria(Cliente categoria)
        {
            _cliRepository.insertCategoria(categoria);
        }
    }
}
