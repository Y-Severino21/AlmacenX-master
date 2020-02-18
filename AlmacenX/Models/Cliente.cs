using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlmacenX.Models
{
    public class Cliente
    {
        [Key] 
        public int ClienteID { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(20, MinimumLength = 12, ErrorMessage = "Ingrese una Cedula valida")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Ingrese un nombre valido")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Correo Electronico")]
        public string Correo { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Direccion { get; set; }
        [Column(TypeName = "varchar(2)")]
        public string Genero { get; set; }
        public bool Estado { get; internal set; }
    }
}
