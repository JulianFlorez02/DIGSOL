using System;
using System.ComponentModel.DataAnnotations;
namespace VehiTrans.App.Dominio
{
    public class Propietario
    {
        [Key]
        public int PropietarioId { get; set; }
        [Required,StringLength(50)]
        public string? Documento { get; set; }
        [Required,StringLength(50)]
        public string? Nombre { get; set; }
        [Required,StringLength(50)]
        public string? Apellidos { get; set; }
        [Required,StringLength(50)]
        public string? Telefono {get;set;}
        public DateTime? FechaNacimiento {get;set;}
        [Required,StringLength(50)]
        public string? Usuario { get; set; }
        [Required,StringLength(50)]
        public string? Contraseña { get; set; }
        [Required,StringLength(50)]
        public string? Ciudad { get; set; }
        [Required,StringLength(50)]
        public string? Correo {get;set;}
    }
}