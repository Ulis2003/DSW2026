using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AppDemo.Models
{
    public class Usuario
    {
        //Atributos con validaciones, getters y setters.
        public int Id { get; set; }

        //Validaciones especificas para el tipo de atributo y proposito.
        [Required(ErrorMessage = "El combre es Obligatorio")]
        [StringLength(50, ErrorMessage =  "El nombre puede no superar los 50 caracteres.")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El correo es Obligatorio")]
        [StringLength(50, ErrorMessage = "El correo puede no superar los 50 caracteres.")]
        [EmailAddress(ErrorMessage = "Correo Electronico Invalido.")]

        [Display(Name = "Correo")]
        public string correo { get; set;}

        [Required(ErrorMessage = "La contraseña es Obligatorio")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "El contraseña puede tener menos 4 ni mas de 50 caracteres.")]
        [DataType(DataType.Password)]

        [Display(Name = "Contraseña")]
        public string clave { get; set; }

        [Display(Name = "Fecha Registro")]
        public DateTime fechaRegistro { get; set;}
        }
}
