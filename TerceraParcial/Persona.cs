using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje.Shared.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ser un correo valido")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "La calificacion es obligatoria")]
        [Range(0, int.MaxValue, ErrorMessage = "Ingresa un número entre 1 y 10")]
        public string? Calificacion { get; set; }
    }
}
