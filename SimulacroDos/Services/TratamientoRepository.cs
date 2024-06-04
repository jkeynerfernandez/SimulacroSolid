using System.Collections.Generic;
using System.Linq;
using SimulacroDos.Data;
using SimulacroDos.DTO;
using SimulacroDos.Models;
using Microsoft.EntityFrameworkCore;

namespace SimulacroDos.Services
{
    public class TratamientoRepository : ITratamientoRepository
    {
        private readonly DataContext _context;

        public TratamientoRepository(DataContext context)
        {
            _context = context;
        }

        public void CrearTratamiento(TratamientoCrearDTO tratamientoDto)
        {
            var tratamiento = new Tratamiento
            {
                CitaId = tratamientoDto.CitaId,
                Descripcion = tratamientoDto.Descripcion,
                Estado = "activo" // Por defecto se establece como activo al crear un tratamiento
            };

            _context.Tratamientos.Add(tratamiento);
            _context.SaveChanges();
        }

        public IEnumerable<Tratamiento> ListarTratamientos()
        {
            return _context.Tratamientos.Include(t => t.Cita).ToList();
        }

        public Tratamiento ObtenerTratamientoPorId(int id)
        {
            return _context.Tratamientos.Include(t => t.Cita).FirstOrDefault(t => t.Id == id);
        }
    }
}
