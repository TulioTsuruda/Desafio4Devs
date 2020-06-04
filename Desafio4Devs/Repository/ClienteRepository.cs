using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio4Devs.Models;
using Desafio4Devs.Repository.Interface;

namespace Desafio4Devs.Repository
{
    public class ClienteRepository : IClienteRepository
    {

        private static List<Cliente> ListClientes = new List<Cliente>
        {
            new Cliente
            {
                ID = 1,
                nomeCliente = "cliente A",
                cnpj = "12345678/1234-12",
                categoria = Indicador.Nenhuma
            },
            new Cliente
            {
                ID = 2,
                nomeCliente = "cliente B",
                cnpj = "12345678/0000-12",
                categoria = Indicador.Nenhuma
            },
            new Cliente
            {
                ID = 3,
                nomeCliente = "cliente C",
                cnpj = "000000000/1234-12",
                categoria = Indicador.Nenhuma
            },
            new Cliente
            {
                ID = 4,
                nomeCliente = "cliente D",
                cnpj = "0000000/0001-12",
                categoria = Indicador.Nenhuma
            },
        };

        public ClienteRepository()
        {
        }

        public void insertCategoria(Cliente addCateg)
        {   
            Cliente newCateg = ListClientes.Find(x => x.ID == addCateg.ID);
            newCateg.categoria = addCateg.categoria;
            //Estudar como adicionar somente um registro em uma tabela ou List
            ListClientes.Add(newCateg);
        }

        public void insertCliente(Cliente insert)
        {
            ListClientes.Add(insert);
        }

        public void searchCliente(Cliente search)
        {
            ListClientes.Find(x => x.ID == search.ID);
        }
    }
}
