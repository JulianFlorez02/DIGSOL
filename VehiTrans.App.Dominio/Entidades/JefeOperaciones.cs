using System;
using System.ComponentModel.DataAnnotations;
namespace VehiTrans.App.Dominio
{
    public class JefeOperaciones
    {
        [Key]
        public int JefeOperacionesId { get; set; }
        public string? Correo {get;set;}
        public int PersonaId {get;set;}
        public Persona Persona {get;set;}
    }
}