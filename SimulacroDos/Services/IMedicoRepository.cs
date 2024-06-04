using SimulacroDos.DTO;
using SimulacroDos.Models;
using System.Collections.Generic;

namespace SimulacroDos.Services
{
    public interface IMedicoRepository
    {
        void CrearMedico(MedicoCrearDto medicoDto);
        void ActualizarMedico(MedicoActualizarDto medicoDto, int id);
        void CambiarEstadoMedico(int id);
        IEnumerable<Medico> ListarMedicos();
        Medico ObtenerMedicoPorId(int id);
    }
}
