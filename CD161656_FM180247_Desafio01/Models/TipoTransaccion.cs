using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CD161656_FM180247_Desafio01.Models
{
    public class TipoTransaccion
    {

        [Key]
        public int id { get; set; }

        [StringLength(150)]
        public string tipo_transaccion { get; set; }
    }
}