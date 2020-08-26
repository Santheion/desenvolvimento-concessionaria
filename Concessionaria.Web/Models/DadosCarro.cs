using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Concessionaria.Web.Models
{
    public class DadosCarro
    {
        [DisplayName("Nome do carro: ")]
        [Required]
        [MaxLength(80, ErrorMessage = "Nome do carro deve possuir no maximo 80 caracteres")]
        [MinLength(3, ErrorMessage = "Nome do carro deve possuir no minimo 3 caracteres")]
        public string NomeCarro { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
    }
}