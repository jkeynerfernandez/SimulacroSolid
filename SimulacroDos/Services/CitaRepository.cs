using System.Collections.Generic;
using System.Linq;
using SimulacroDos.Data;
using SimulacroDos.DTO;
using SimulacroDos.Models;
using Microsoft.EntityFrameworkCore;

namespace SimulacroDos.Services
{
    public class CitaRepository : ICitaRepository
    {
        private readonly DataContext _context;
        private readonly IEmailService _emailService;

        public CitaRepository(DataContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        public void CrearCita(CitaCrearDto citaDto)
        {
            var cita = new Cita
            {
                MedicoId = citaDto.MedicoId,
                PacienteId = citaDto.PacienteId,
                Fecha = citaDto.Fecha,
                Estado = "atendida" 
            };

            _context.Citas.Add(cita);
            _context.SaveChanges();

            var paciente = _context.Pacientes.Find(citaDto.PacienteId);
            var medico = _context.Medicos.Find(citaDto.MedicoId);

            if (paciente != null && medico != null)
            {
                var subject = "Nueva Cita Programada";
                var mensajePaciente = $"Hola {paciente.Nombres},\nTienes una nueva cita programada para el {cita.Fecha}.";
                var mensajeMedico = $"Hola Dr. {medico.NombreCompleto},\nTienes una nueva cita programada para el {cita.Fecha} con el paciente {paciente.Nombres}.";

                _emailService.SendEmail(paciente.Correo, subject, mensajePaciente);
                _emailService.SendEmail(medico.Correo, subject, mensajeMedico);
            }
        }

        public IEnumerable<Cita> ListarCitas()
        {
            return _context.Citas.Include(c => c.Medico).ThenInclude(m => m.Especialidad)
                         .Include(c => c.Paciente)
                         .ToList();
        }

        public Cita ObtenerCitaPorId(int id)
        {
            return _context.Citas.Include(c => c.Medico).ThenInclude(m => m.Especialidad)
                                 .Include(c => c.Paciente)
                                 .FirstOrDefault(c => c.Id == id);
        }

        public void CambiarEstadoCita(int id)
        {
            var cita = _context.Citas.Find(id);
            if (cita != null)
            {
                cita.Estado = "atendida";  
                _context.SaveChanges();
            }
        }

        //adicionales

        public int ObtenerCantidadCitasPaciente(int pacienteId)
        {
            return _context.Citas.Count(c => c.PacienteId == pacienteId);
        }

        public int ObtenerCantidadCitasDia(DateTime fecha)
        {
            return _context.Citas.Count(c => c.Fecha.Date == fecha.Date);
        }

        public IEnumerable<Cita> ObtenerCitasMedicoDia(int medicoId, DateTime fecha)
        {
            return _context.Citas.Where(c => c.MedicoId == medicoId && c.Fecha.Date == fecha.Date)
                                 .Include(c => c.Paciente)
                                 .ToList();
        }

        public IEnumerable<Cita> ObtenerHistorialMedicoPaciente(int pacienteId)
        {
            return _context.Citas.Where(c => c.PacienteId == pacienteId).ToList();
        }

        public IEnumerable<Paciente> ObtenerPacientesMedico(int medicoId)
        {
            return _context.Citas.Where(c => c.MedicoId == medicoId)
                                 .Select(c => c.Paciente)
                                 .Distinct()
                                 .ToList();
        }
    }
}
