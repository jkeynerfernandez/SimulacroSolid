using Microsoft.AspNetCore.Mvc;
using SimulacroDos.Models;
using SimulacroDos.Services;

namespace SimulacroDos.Controllers
{
       public class PacienteConsultarController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteConsultarController(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        [HttpGet]
        [Route("api/pacientes/")]
        public ActionResult<IEnumerable<Paciente>> ListarPacientes()
        {
            var pacientes = _pacienteRepository.ListarPacientes();
            return Ok(pacientes);
        }

        [HttpGet]
        [Route("api/paciente/{id}")]
        public ActionResult<Paciente> ObtenerPacientePorId(int id)
        {
            var paciente = _pacienteRepository.ObtenerPacientePorId(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return Ok(paciente);
        }
    }
}
