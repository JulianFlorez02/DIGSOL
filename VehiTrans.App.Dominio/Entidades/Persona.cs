using System;
namespace VehiTrans.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string? Documento { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }
        public Rol Rol { get; set; }
        public string? Contraseña { get; set; }
    }
}