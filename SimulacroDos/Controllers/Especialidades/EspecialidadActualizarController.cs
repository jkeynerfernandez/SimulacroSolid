using Microsoft.AspNetCore.Mvc;
using SimulacroDos.Services;
using SimulacroDos.DTO;

namespace SimulacroDos.Controllers
{
    
    public class EspecialidadActualizarController : ControllerBase
    {
        private readonly IEspecialidadRepository _repository;

        public EspecialidadActualizarController(IEspecialidadRepository repository)
        {
            _repository = repository;
        }

        [HttpPut]
        [Route("api/especialidad/actualizar/{id}")]
        public IActionResult ActualizarEspecialidad(int id, [FromBody] EspecialidadActualizarDto especialidadDto)
        {
            _repository.ActualizarEspecialidad(especialidadDto, id);
            return Ok();
        }
    }
}
