using System.Collections.Generic;
using SimulacroDos.DTO;
using SimulacroDos.Models;

namespace SimulacroDos.Services
{
    public interface IPacienteRepository
    {
        void CrearPaciente(PacienteCrearDto pacienteDto);
        void ActualizarPaciente(int id, PacienteActualizarDto pacienteDto);
        void CambiarEstadoPaciente(int id);
        IEnumerable<Paciente> ListarPacientes();
        Paciente ObtenerPacientePorId(int id);
    }
}
