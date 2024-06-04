using System;
using System.ComponentModel.DataAnnotations;

namespace SimulacroDos.DTO
{
    public class PacienteActualizarDto
    {
        [Required]
        public string Nombres { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Estado { get; set; }
    }
}
