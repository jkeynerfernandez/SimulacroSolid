using Microsoft.AspNetCore.Mvc;
using SimulacroDos.Services;

namespace SimulacroDos.Controllers
{
    
    public class EspecialidadEliminarController : ControllerBase
    {
        private readonly IEspecialidadRepository _repository;

        public EspecialidadEliminarController(IEspecialidadRepository repository)
        {
            _repository = repository;
        }

        [HttpPut]
        [Route("api/especialidad/eliminar/{id}")]
        public IActionResult CambiarEstadoEspecialidad(int id)
        {
            _repository.CambiarEstadoEspecialidad(id);
            return Ok();
        }
    }
}
