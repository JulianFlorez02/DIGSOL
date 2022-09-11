using System;
using System.ComponentModel.DataAnnotations;
namespace VehiTrans.App.Dominio
{
    public class Conductor
    {
        [Key]
        public int ConductorId { get; set; }
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
        public string? Licencia { get; set; }
        [Required,StringLength(50)]
        public string? Direccion { get; set; }
        [Required,StringLength(50)]
        public string? NivelEstudio {get;set;}
    }
}