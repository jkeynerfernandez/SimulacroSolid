using System.Text.Json.Serialization;

namespace SimulacroDos.Models
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public string Estado { get; set; }
        [JsonIgnore]
        public List<Medico> Medico{ get; set; } 

    }
}