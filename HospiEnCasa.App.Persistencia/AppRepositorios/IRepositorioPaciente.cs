using System.Collections.Generic;
using HospiEnCasa.App.Dominio;


namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPacientes
    {
        IEnumerable<paciente> GetAllPAcientes();
        paciente AddPAciente(paciente paciente);
        paciente UpdatePaciente(paciente idPaciente);

        void DeletePaciente(int idPaciente);
        paciente GetPaciente(int idPaciente);

    }
}