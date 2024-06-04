using Microsoft.AspNetCore.Mvc;
using SimulacroDos.Services;

namespace SimulacroDos.Controllers
{
    
    public class PacienteCambiarEstadoController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteCambiarEstadoController(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        [HttpPut]
        [Route("api/paciente/eliminar/{id}")]
        public IActionResult CambiarEstadoPaciente(int id)
        {
            _pacienteRepository.CambiarEstadoPaciente(id);
            return NoContent();
        }
    }
}
