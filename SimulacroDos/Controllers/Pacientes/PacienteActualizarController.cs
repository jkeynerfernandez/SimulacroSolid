using Microsoft.AspNetCore.Mvc;
using SimulacroDos.DTO;
using SimulacroDos.Models;
using SimulacroDos.Services;

namespace SimulacroDos.Controllers
{
    
    
    public class PacienteActualizarController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteActualizarController(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        [HttpPut]
        [Route("api/paciente/actualizar/{id}")]
        public ActionResult<Paciente> ActualizarPaciente(int id, PacienteActualizarDto pacienteDto)
        {
            _pacienteRepository.ActualizarPaciente(id, pacienteDto);
            return Ok(pacienteDto);
        }
    }
}
