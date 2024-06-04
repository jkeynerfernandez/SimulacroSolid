using Microsoft.AspNetCore.Mvc;
using SimulacroDos.Services;
using System;

namespace SimulacroDos.Controllers
{
    
   
    public class MedicoCambiarEstadoController : ControllerBase
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoCambiarEstadoController(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        [HttpPut]
        [Route("api/medico/eliminar/{id}")]
        public IActionResult EliminarMedico(int id)
        {
            try
            {
                _medicoRepository.CambiarEstadoMedico(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al eliminar el médico: {ex.Message}");
            }
        }
    }
}
