using Microsoft.AspNetCore.Mvc;
using SimulacroDos.Services;

namespace SimulacroDos.Controllers
{
    
    public class CitaController : ControllerBase
    {
        private readonly ICitaRepository _repository;

        public CitaController(ICitaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("api/citas")]
        public IActionResult ListarCitas()
        {
            var citas = _repository.ListarCitas();
            return Ok(citas);
        }

        [HttpGet]
        [Route("api/cita/{id}")]
        public IActionResult ObtenerCitaPorId(int id)
        {
            var cita = _repository.ObtenerCitaPorId(id);
            if (cita == null)
            {
                return NotFound();
            }
            return Ok(cita);
        }

        //adicionales 
         [HttpGet]
         [Route("api/cita/pacientes/{pacienteId}/cantidad-citas")]
        public IActionResult ObtenerCantidadCitasPaciente(int pacienteId)
        {
            var cantidadCitas = _repository.ObtenerCantidadCitasPaciente(pacienteId);
            return Ok(cantidadCitas);
        }

        [HttpGet]
        [Route("api/cita/cantidad-dia/{fecha}")]
        public IActionResult ObtenerCantidadCitasDia(DateTime fecha)
        {
            var cantidadCitas = _repository.ObtenerCantidadCitasDia(fecha);
            return Ok(cantidadCitas);
        }

        [HttpGet]
        [Route("api/cita/medicos/{medicoId}/citas-dia/{fecha}")]

        public IActionResult ObtenerCitasMedicoDia(int medicoId, DateTime fecha)
        {
            var citasMedicoDia = _repository.ObtenerCitasMedicoDia(medicoId, fecha);
            return Ok(citasMedicoDia);
        }

        [HttpGet]
        [Route("api/cita/pacientes/{pacienteId}/historial-medico")]
        public IActionResult ListarHistorialMedicoPaciente(int pacienteId)
        {
            var historialMedico = _repository.ObtenerHistorialMedicoPaciente(pacienteId);
            if (historialMedico == null)
            {
                return NotFound();
            }
            return Ok(historialMedico);
        }

        [HttpGet]
        [Route("api/cita/medicos/{medicoId}/pacientes")]
        public IActionResult ListarPacientesMedico(int medicoId)
        {
            var pacientes = _repository.ObtenerPacientesMedico(medicoId);
            return Ok(pacientes);
        }

    }
}
