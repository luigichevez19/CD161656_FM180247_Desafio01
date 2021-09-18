using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CD161656_FM180247_Desafio01.Models
{
    public class transacciones
    {

        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El monto es requerido")]
        public double Monto { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime fechaTransaccion { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime fechaAplicacion { get; set; }

        public int? idCuentaBancaria { get; set; }

        public virtual CuentaBancaria cuenta { get; set; }

        public int? TipoTransaccion { get; set; }

        public virtual TipoTransaccion TipoTran { get; set; }
    }
}