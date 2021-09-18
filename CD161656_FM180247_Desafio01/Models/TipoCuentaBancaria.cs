using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CD161656_FM180247_Desafio01.Models
{
    public class TipoCuentaBancaria
    {
        [Key]
        public int id { get; set; }

        [StringLength(100)]
        public string TipoCuentaBan { get; set; }

        public bool Activo { get; set; }
    }
}