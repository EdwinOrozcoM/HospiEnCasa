using System;

namespace HospiEnCasa.App.Dominio
{
    public class paciente : persona
    {
            public int Id{get;set;}
            public string Direccion{get;set;}
            public float latitude{get;set;}
            public float Longitude{get;set;}
            public string Ciudad{get;set;}
            public DateTime FechaNacimento{get;set;}
            public familiarDesignado Familiar{get;set;}
            public enfermera Enfermera{get;set;}
            public medico Medico{get;set;}
            public historia Historia{get;set;}
            public System.Collections.Generic.List<signoVital> SignosVitales{get;set;} 

    }
}
