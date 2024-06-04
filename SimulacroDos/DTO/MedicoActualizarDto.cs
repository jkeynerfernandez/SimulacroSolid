using System.ComponentModel.DataAnnotations;

namespace SimulacroDos.DTO
{
    public class MedicoActualizarDto
    {
        [Required]
        public string NombreCompleto { get; set; }

        [Required]
        public string Correo { get; set; }

        [Required]
        public string Telefono { get; set; }
    }
}