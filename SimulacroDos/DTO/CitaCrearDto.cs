using System;
using System.ComponentModel.DataAnnotations;

namespace SimulacroDos.DTO
{
    public class CitaCrearDto
    {
        [Required]
        public int MedicoId { get; set; }

        [Required]
        public int PacienteId { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
    }
}
