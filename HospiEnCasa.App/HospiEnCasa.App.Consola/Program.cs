using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    public class Program
    {
        private static IRepositorioPacientes _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Entity Framework");
            //AddPaciente();//Se comenta para que no me ingrese mas veces el pacientes
            BuscarPAciente(1);
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente(){
                Nombre="Nicolay",
                Apellido="Perez",
                NumeroTelefono="602589",
                Genero=Genero.Masculino,
                Direccion="Calle siempre viva",
                Longitud=5.0632F,
                Latitud=-85.693F,
                Ciudad ="Calarca-Quindio",
                FechaNacimento= new DateTime(1989,05,23)
            };
            _repoPaciente.AddPAciente(paciente);
            

        }
        private static void BuscarPAciente(int IdPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(IdPaciente);
            Console.WriteLine("Nombre: "+paciente.Nombre+" Apellido: "+paciente.Apellido);
        }
    }
}

