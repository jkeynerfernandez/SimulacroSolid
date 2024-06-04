using Microsoft.AspNetCore.Mvc;
using SimulacroDos.DTO;
using SimulacroDos.Services;

namespace SimulacroDos.Controllers
{
    
    
    public class TratamientosController : ControllerBase
    {
        private readonly ITratamientoRepository _tratamientoRepository;

        public TratamientosController(ITratamientoRepository tratamientoRepository)
        {
            _tratamientoRepository = tratamientoRepository;
        }

        
        [HttpPost]
        [Route("api/tratamiento/crear")]
        public IActionResult CrearTratamiento(TratamientoCrearDTO tratamientoDto)
        {
            _tratamientoRepository.CrearTratamiento(tratamientoDto);
            return Ok(tratamientoDto);
        }
    }
}
