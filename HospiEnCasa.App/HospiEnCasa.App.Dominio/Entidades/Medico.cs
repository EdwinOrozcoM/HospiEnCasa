using System;

namespace HospiEnCasa.App.Dominio
{
    public class Medico : Persona
    {
             
            public string Especialidad{get;set;} 
            public string Codigo{get;set;} //Codigo único del medico  
            public string RegistroRethus{get;set;}    //Registro Unico Nacional del Talento Humano
    }
}
