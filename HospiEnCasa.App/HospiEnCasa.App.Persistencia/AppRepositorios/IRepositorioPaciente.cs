using System.Collections.Generic;
using HospiEnCasa.App.Dominio;


namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPacientes
    {
        IEnumerable<Paciente> GetAllPAcientes();
        Paciente AddPAciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente idPaciente);

        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);

    }
}