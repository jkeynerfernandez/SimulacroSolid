using System;
using System.Collections.Generic;
using System.Linq;
using SimulacroDos.Data;
using SimulacroDos.DTO;
using SimulacroDos.Models;

namespace SimulacroDos.Services
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly DataContext _context;

        public PacienteRepository(DataContext context)
        {
            _context = context;
        }

        public void CrearPaciente(PacienteCrearDto pacienteDto)
        {
            var paciente = new Paciente
            {
                Nombres = pacienteDto.Nombres,
                Apellidos = pacienteDto.Apellidos,
                FechaNacimiento = pacienteDto.FechaNacimiento,
                Correo = pacienteDto.Correo,
                Telefono = pacienteDto.Telefono,
                Direccion = pacienteDto.Direccion,
                Estado = "activo" 
            };

            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
        }

        public void ActualizarPaciente(int id, PacienteActualizarDto pacienteDto)
        {
            var pacienteExistente = _context.Pacientes.Find(id);
            if (pacienteExistente != null)
            {
                pacienteExistente.Nombres = pacienteDto.Nombres;
                pacienteExistente.Apellidos = pacienteDto.Apellidos;
                pacienteExistente.FechaNacimiento = pacienteDto.FechaNacimiento;
                pacienteExistente.Correo = pacienteDto.Correo;
                pacienteExistente.Telefono = pacienteDto.Telefono;
                pacienteExistente.Direccion = pacienteDto.Direccion;
                pacienteExistente.Estado = pacienteDto.Estado;

                _context.SaveChanges();
            }
        }

        public void CambiarEstadoPaciente(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if (paciente != null)
            {
                paciente.Estado = "eliminado";
                _context.SaveChanges();
            }
        }

        public IEnumerable<Paciente> ListarPacientes()
        {
            return _context.Pacientes.ToList();
        }

        public Paciente ObtenerPacientePorId(int id)
        {
            return _context.Pacientes.Find(id);
        }
    }
}
