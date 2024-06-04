using Microsoft.AspNetCore.Mvc;
using SimulacroDos.Services;

namespace SimulacroDos.Controllers
{
   
    public class EspecialidadLeerController : ControllerBase
    {
        private readonly IEspecialidadRepository _repository;

        public EspecialidadLeerController(IEspecialidadRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("api/especialidad/listar")]
        public IActionResult ListarEspecialidades()
        {
            var especialidades = _repository.ListarEspecialidades();
            return Ok(especialidades);
        }

        [HttpGet]
        [Route("api/especialidad/listar/{id}")]
        public IActionResult ObtenerEspecialidadPorId(int id)
        {
            var especialidad = _repository.ObtenerEspecialidadPorId(id);
            if (especialidad != null)
            {
                return Ok(especialidad);
            }

            return NotFound();
        }
    }
}
