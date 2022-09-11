using System;
using System.ComponentModel.DataAnnotations;

namespace VehiTrans.App.Dominio
{
    public class CompraRepuestos
    {
        [Key]
        public int CompraRepuestosId  { get; set; }
        [Required,StringLength(50)]
        public string? Valor { get; set; }
        public DateTime FechaCompra { get; set; }
        [Required,StringLength(50)]
        public string? Justificacion { get; set; } 
        [Required,StringLength(50)]            
        public int RepuestosId{ get; set; }
        [Required,StringLength(50)]
        public Repuestos? Repuestos {get;set;}
        [Required,StringLength(50)]
        public int RevisionId{get;set;}
        public Revision? revision{get;set;}
    }
}