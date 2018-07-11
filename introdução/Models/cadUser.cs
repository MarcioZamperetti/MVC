using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoASPNET_VazioComCRUD_EF62.Models
{
    public class cadUser
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string endereço { get; set; }
        [MinLength(11)]
        [StringLength(11)]
        public string cpf { get; set; }
        public string celular { get; set; }
        public DateTimeOffset nascimento { get; set; }
    }
}