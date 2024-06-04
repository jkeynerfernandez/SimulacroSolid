using SimulacroDos.Models;
using SimulacroDos.DTO;
using System.Collections.Generic;
using System.Linq;
using SimulacroDos.Data;

namespace SimulacroDos.Services
{
    public class EspecialidadRepository : IEspecialidadRepository
    {
        private readonly DataContext _context;

        public EspecialidadRepository(DataContext context)
        {
            _context = context;
        }

        public void CrearEspecialidad(EspecialidadCrearDto especialidadDto)
        {
            var especialidad = new Especialidad
            {
                Nombre = especialidadDto.Nombre,
                Description = especialidadDto.Description,
                Estado = "activo"  //por defecto
            };

            _context.Especialidades.Add(especialidad);
            _context.SaveChanges();
        }

       public void ActualizarEspecialidad(EspecialidadActualizarDto especialidadDto, int id)
        {
            var especialidad = _context.Especialidades.Find(id);
            if (especialidad != null)
            {
                especialidad.Nombre = especialidadDto.Nombre;
                especialidad.Description = especialidadDto.Description;
                
                _context.SaveChanges();
            }
        }

        public void CambiarEstadoEspecialidad(int id)
        {
            var especialidad = _context.Especialidades.Find(id);
            if (especialidad != null)
            {
                especialidad.Estado = "eliminado";
                _context.SaveChanges();
            }
        }

        public IEnumerable<Especialidad> ListarEspecialidades()
        {
            return _context.Especialidades.ToList();
        }

        public Especialidad ObtenerEspecialidadPorId(int id)
        {
            return _context.Especialidades.Find(id);
        }

        

        
    }
}
