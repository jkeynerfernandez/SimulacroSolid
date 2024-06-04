using Microsoft.AspNetCore.Mvc;
using SimulacroDos.Services;
using SimulacroDos.Models;
using System;
using System.Collections.Generic;

namespace SimulacroDos.Controllers
{
    
    
    public class MedicoConsultarController : ControllerBase
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoConsultarController(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        [HttpGet]
        [Route("api/medicos/lista")]
        public ActionResult<IEnumerable<Medico>> ListarMedicos()
        {
            try
            {
                var medicos = _medicoRepository.ListarMedicos();
                return Ok(medicos);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener la lista de médicos: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("api/medico/{id}")]
        public ActionResult<Medico> ObtenerMedicoPorId(int id)
        {
            try
            {
                var medico = _medicoRepository.ObtenerMedicoPorId(id);
                if (medico == null)
                {
                    return NotFound($"Médico con id {id} no encontrado");
                }

                return Ok(medico);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener el médico: {ex.Message}");
            }
        }
    }
}
