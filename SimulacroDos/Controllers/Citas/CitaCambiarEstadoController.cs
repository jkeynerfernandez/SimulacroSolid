using Microsoft.AspNetCore.Mvc;
using SimulacroDos.Services;

namespace SimulacroDos.Controllers
{
    
    public class CitaCambiarEstadoController : ControllerBase
    {
        private readonly ICitaRepository _repository;

        public CitaCambiarEstadoController(ICitaRepository repository)
        {
            _repository = repository;
        }

        [HttpPatch]
        [Route("api/citas/cambiarEstado/{id}")]
        public IActionResult CambiarEstadoCita(int id)
        {
            _repository.CambiarEstadoCita(id);
            return Ok();
        }
    }
}