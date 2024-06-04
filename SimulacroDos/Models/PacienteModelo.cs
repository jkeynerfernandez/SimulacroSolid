using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SimulacroDos.Models
{
    public class Paciente
    {
        public int Id { get; set; }

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

        [JsonIgnore]
        public List<Cita> Citas { get; set; }
    }
}
