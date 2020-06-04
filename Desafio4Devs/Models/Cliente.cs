using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4Devs.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string nomeCliente { get; set; }
        public string cnpj { get; set; }
        public Indicador categoria { get; set; }

    }

    public enum Indicador
    {
        Nenhuma,
        Detrator,
        Neutro,
        Promotor,
    }
}
