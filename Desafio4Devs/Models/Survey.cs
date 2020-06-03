using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4Devs.Models
{
    public class Survey
    {
        public int ID { get; set; }
        public string nomeCliente { get; set; }
        public string nomeContato { get; set; }
        public string cnpj { get; set; }
        public string data { get; set; }
        public int scale { get; set; }
        public string motivo { get; set; }

    }

}
