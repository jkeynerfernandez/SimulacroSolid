using Microsoft.AspNetCore.Mvc;
using SimulacroDos.Services;
using SimulacroDos.DTO;

namespace SimulacroDos.Controllers
{
    
    
    public class EspecialidadCrearController : ControllerBase
    {
        private readonly IEspecialidadRepository _repository;

        public EspecialidadCrearController(IEspecialidadRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("api/especialidad/crear")]
        public IActionResult CrearEspecialidad([FromBody] EspecialidadCrearDto especialidadDto)
        {
            _repository.CrearEspecialidad(especialidadDto);
            return Ok();
        }
    }
}
