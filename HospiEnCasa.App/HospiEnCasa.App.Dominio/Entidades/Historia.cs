using System;

namespace HospiEnCasa.App.Dominio
{
    public class Historia
    {
            public int Id{get;set;}
            //public paciente objPaciente{get;set;}// no se pone para validar implementacion  duda 
            public string Diagnostico{get;set;}
            public string Entorno{get;set;}//Descripcion de la casa y habitacion del paciente
            public  List<SugerenciaCuidado> Sugerencias{get;set;}//Listado hay que ver si es una listaSugernciaCuidados
            
    }
}