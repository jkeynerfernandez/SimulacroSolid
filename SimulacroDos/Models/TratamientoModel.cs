using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimulacroDos.Models
{
    public class Tratamiento
    {
        public int Id { get; set; }

        [Required]
        public int CitaId { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public string Estado { get; set; }

        // Relación con la tabla Citas
        [ForeignKey("CitaId")]
        public Cita Cita { get; set; }
    }
}
