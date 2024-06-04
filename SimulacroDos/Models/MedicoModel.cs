using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SimulacroDos.Models
{
    public class Medico
    {
        
        public int Id { get; set; }
        [Required]
        public string NombreCompleto { get; set; }
        
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Estado { get; set; }


        [Required]
        public int EspecialidadID { get; set; }
        public Especialidad Especialidad { get; set; }

        [JsonIgnore]
        public Cita Citas { get; set; }

        
    }
}