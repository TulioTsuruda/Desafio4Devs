using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4Devs.Models
{
    public class Login
    {
        public int    ID { get; set; }
        public string acesso { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string userId { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string lastName { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string email { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string confEmail { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string password { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string confPass { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string birthDate { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public Gender gender { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string cellPhone { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string address { get; set; }
        public string address2 { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int number { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string neighborhood { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string city { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string state { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string zipCode { get; set; }

    }

    public enum Gender
    {
        Masculino,
        Feminino,
        Outros
    }
}
