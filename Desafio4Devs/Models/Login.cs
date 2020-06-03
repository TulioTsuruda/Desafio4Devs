using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4Devs.Models
{
    public class Login
    {
        public int    ID { get; set; }
        public string acesso { get; set; }
        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string confEmail { get; set; }
        public string CPF { get; set; }
        public string password { get; set; }
        public string confPass { get; set; }
        public string birthDate { get; set; }
        public Gender gender { get; set; }
        public string cellPhone { get; set; }
        public string Phone { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public int number { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }

    }

    public enum Gender
    {
        Masculino,
        Feminino,
        Outros
    }
}
