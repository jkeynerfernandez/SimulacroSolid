using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimulacroDos.Models
{
    public class Cita
    {
        public int Id { get; set; }

        public int MedicoId { get; set; }
        public Medico Medico { get; set; }

        [Required]
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Estado { get; set; }
    }
}
