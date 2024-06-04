using System.ComponentModel.DataAnnotations;

namespace SimulacroDos.DTO
{
    public class MedicoCrearDto
    {
        [Required]
        public string NombreCompleto { get; set; }

        [Required]
        public string Correo { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public int EspecialidadID { get; set; }
    }
}