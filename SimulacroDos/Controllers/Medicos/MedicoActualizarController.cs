using Microsoft.AspNetCore.Mvc;
using SimulacroDos.DTO;
using SimulacroDos.Services;
using SimulacroDos.Models;
using System;

namespace SimulacroDos.Controllers
{
    
    
    public class MedicoActualizarController : ControllerBase
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoActualizarController(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        [HttpPut]
        [Route("api/medico/actualizar/{id}")]
        public ActionResult<Medico> ActualizarMedico(int id, MedicoActualizarDto medicoDto)
        {
            try
            {
                _medicoRepository.ActualizarMedico(medicoDto, id);
                return Ok(medicoDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al actualizar el médico: {ex.Message}");
            }
        }
    }
}
