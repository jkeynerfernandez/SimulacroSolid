using SimulacroDos.Data;
using SimulacroDos.DTO;
using SimulacroDos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimulacroDos.Services
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly DataContext _context;

        public MedicoRepository(DataContext context)
        {
            _context = context;
        }

        public void CrearMedico(MedicoCrearDto medicoDto)
        {
            var medico = new Medico
            {
                NombreCompleto = medicoDto.NombreCompleto,
                Correo = medicoDto.Correo,
                Telefono = medicoDto.Telefono,
                Estado = "activo",  // por defecto
                EspecialidadID = medicoDto.EspecialidadID
            };

            _context.Medicos.Add(medico);
            _context.SaveChanges();
        }

        public void ActualizarMedico(MedicoActualizarDto medicoDto, int id)
        {
            var medico = _context.Medicos.Find(id);
            if (medico != null)
            {
                medico.NombreCompleto = medicoDto.NombreCompleto;
                medico.Correo = medicoDto.Correo;
                medico.Telefono = medicoDto.Telefono;
                
                _context.SaveChanges();
            }
        }

        public void CambiarEstadoMedico(int id)
        {
            var medico = _context.Medicos.Find(id);
            if (medico != null)
            {
                medico.Estado = "eliminado";
                _context.SaveChanges();
            }
        }

        public IEnumerable<Medico> ListarMedicos()
        {
            return _context.Medicos.Include(m => m.Especialidad).ToList();
        }
        public Medico ObtenerMedicoPorId(int id)
        {
            return _context.Medicos.Include(m => m.Especialidad).FirstOrDefault(m => m.Id == id);
        }
    }
}
