using Microsoft.AspNetCore.Mvc;
using SimulacroDos.DTO;
using SimulacroDos.Services;
using SimulacroDos.Models;
using System;

namespace SimulacroDos.Controllers
{
    
    
    public class MedicoCrearController : ControllerBase
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoCrearController(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        [HttpPost]
        [Route("api/medico/crear")]
        public ActionResult<Medico> CrearMedico(MedicoCrearDto medicoDto)
        {
            try
            {
                _medicoRepository.CrearMedico(medicoDto);
                return Ok(medicoDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al crear el médico: {ex.Message}");
            }
        }
    }
}
