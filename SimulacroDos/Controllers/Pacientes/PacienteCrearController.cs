using Microsoft.AspNetCore.Mvc;
using SimulacroDos.DTO;
using SimulacroDos.Models;
using SimulacroDos.Services;

namespace SimulacroDos.Controllers
{
    
    
    public class PacienteCrearController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteCrearController(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        [HttpPost]
        [Route("api/paciente/crear")]
        public ActionResult<Paciente> CrearPaciente(PacienteCrearDto pacienteDto)
        {
            _pacienteRepository.CrearPaciente(pacienteDto);
            return Ok(pacienteDto);
        }
    }
}
