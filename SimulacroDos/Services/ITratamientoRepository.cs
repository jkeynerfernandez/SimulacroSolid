using System.Collections.Generic;
using SimulacroDos.DTO;
using SimulacroDos.Models;

namespace SimulacroDos.Services
{
    public interface ITratamientoRepository
    {
        void CrearTratamiento(TratamientoCrearDTO tratamientoDto);
        IEnumerable<Tratamiento> ListarTratamientos();
        Tratamiento ObtenerTratamientoPorId(int id);
    }
}
