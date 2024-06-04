using SimulacroDos.DTO;
using SimulacroDos.Models;
using System.Collections.Generic;

namespace SimulacroDos.Services
{
    public interface IEspecialidadRepository
    {
        void CrearEspecialidad(EspecialidadCrearDto especialidad);
        void ActualizarEspecialidad(EspecialidadActualizarDto especialidad, int id);
        void CambiarEstadoEspecialidad(int id);
        IEnumerable<Especialidad> ListarEspecialidades();
        Especialidad ObtenerEspecialidadPorId(int id);

       
    }
}
