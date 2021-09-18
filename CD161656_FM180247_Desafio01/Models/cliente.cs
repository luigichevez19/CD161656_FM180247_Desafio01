using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CD161656_FM180247_Desafio01.Models
{
    public class cliente
    {

        [Key]
        public int id { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string nombres { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El primerApellido es requerido")]
        public string primerApellido { get; set; }

        [StringLength(100)]
        public string segundoApellido { get; set; }

        [StringLength(9)]
        [Required(ErrorMessage = "El telefono es requerido")]
        public string telefono { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "El correo es requerido")]
        public string correo { get; set; }
    }
}