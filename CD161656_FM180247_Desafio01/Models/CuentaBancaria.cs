using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CD161656_FM180247_Desafio01.Models
{
    public class CuentaBancaria
    {
        [Key]
        public int id { get; set; }

        [StringLength(100)]
        public string Moneda { get; set; }

        public int? idCliente { get; set; }

        public virtual cliente clientes { get; set; }

        public int? idTipo { get; set; }

        public virtual TipoCuentaBancaria Tipo { get; set; }
    }
}