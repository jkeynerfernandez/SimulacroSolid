using System.Collections.Generic;
using SimulacroDos.DTO;
using SimulacroDos.Models;

namespace SimulacroDos.Services
{
    public interface ICitaRepository
    {
        void CrearCita(CitaCrearDto citaDto);
        void CambiarEstadoCita(int id);
        IEnumerable<Cita> ListarCitas();
        Cita ObtenerCitaPorId(int id);

        //adicionales 
        int ObtenerCantidadCitasPaciente(int pacienteId);

        int ObtenerCantidadCitasDia(DateTime fecha);

        IEnumerable<Cita> ObtenerCitasMedicoDia(int medicoId, DateTime fecha);

        IEnumerable<Cita> ObtenerHistorialMedicoPaciente(int pacienteId);

        IEnumerable<Paciente> ObtenerPacientesMedico(int medicoId);
    }
}
