using System;
using System.ComponentModel.DataAnnotations;

namespace VehiTrans.App.Dominio
{
    public class VehiculoOpcionales
    {
        public int VehiculoOpcionalesId  { get; set; }
        [Required,StringLength(50)]
        public string? PaisOrigen { get; set; }
        [Required,StringLength(50)]
        public string? AireAcondicionado { get; set; }
        [Required,StringLength(50)]
        public string? Televisor { get; set; }
        [Required,StringLength(50)]
        public string? Otros { get; set; }
        [Required,StringLength(50)]
        public int VehiculoId { get; set; }  //* foranea a Vehiculo *//
        public Vehiculo? Vehiculo { get; set; }
        
    }
}