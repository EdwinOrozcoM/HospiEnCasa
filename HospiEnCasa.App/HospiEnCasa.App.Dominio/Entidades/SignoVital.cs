using System;

namespace HospiEnCasa.App.Dominio
{
    public class SignoVital
    {
            public int Id{get;set;}
            //public paciente objPaciente{get;set;} // preguntar como see aque pacientes pertenecen los signos 
            public DateTime FechaHora{get;set;}
            public float Valor  {get;set;}
            public TipoSigno Signo {get;set;}


    }
}