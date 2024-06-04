using Microsoft.AspNetCore.Mvc;
using SimulacroDos.DTO;
using SimulacroDos.Models;
using SimulacroDos.Services;

namespace SimulacroDos.Controllers
{
    
    
    public class TratamientosListarController : ControllerBase
    {
        private readonly ITratamientoRepository _tratamientoRepository;

        public TratamientosListarController(ITratamientoRepository tratamientoRepository)
        {
            _tratamientoRepository = tratamientoRepository;
        }

        
        [HttpGet]
        [Route("api/tratamientos/listar")]
        public IActionResult ListarTratamientos()
        {
            var tratamientos = _tratamientoRepository.ListarTratamientos();
            return Ok(tratamientos);
        }

        // GET: api/Tratamientos/5
        [HttpGet]
        [Route("api/tratamiento/{id}")]
        public IActionResult GetTratamiento(int id)
        {
            var tratamiento = _tratamientoRepository.ObtenerTratamientoPorId(id);
            if (tratamiento == null)
            {
                return NotFound();
            }
            return Ok(tratamiento);
        }
    }
}
