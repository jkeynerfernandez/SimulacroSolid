using Microsoft.AspNetCore.Mvc;
using SimulacroDos.DTO;
using SimulacroDos.Services;

namespace SimulacroDos.Controllers
{
    
  
    public class CrearCitaController : ControllerBase
    {
        private readonly ICitaRepository _citaRepository;

        public CrearCitaController(ICitaRepository citaRepository)
        {
            _citaRepository = citaRepository;
        }

        [HttpPost]
          [Route("api/cita/crear")]
        public IActionResult CrearCita([FromBody] CitaCrearDto citaDto)
        {
            _citaRepository.CrearCita(citaDto);
            return Ok("Cita creada exitosamente :p");
        }
    }
}
