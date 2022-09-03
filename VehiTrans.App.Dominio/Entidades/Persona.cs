using System;
namespace VehiTrans.App.Dominio
{
    public class Persona
    {
        [Key]
        public int PersonaId { get; set; }
        public string? Documento { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Telefono {get;set;}
        public DateTime? FechaNacimiento {get;set;}
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
    }
}