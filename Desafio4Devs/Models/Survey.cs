using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4Devs.Models
{
    public class Survey
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string nomeCliente { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string nomeContato { get; set; }
        public string cnpj { get; set; }
        public string data { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int scale { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string motivo { get; set; }
        //public Indicador categoria { get; set; }
        public string userID { get; set; }

    }

    //public enum Indicador
    //{
    //    Promotor,
    //    Neutro,
    //    Detrator,
    //    Nenhuma
    //}
}
