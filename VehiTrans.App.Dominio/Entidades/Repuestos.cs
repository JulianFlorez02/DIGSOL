using System;
using System.ComponentModel.DataAnnotations;

namespace VehiTrans.App.Dominio
{
    public class Repuestos
    {
        [Key]
        public int RepuestosId {get;set; }
        [Required,StringLength(150)]
        public string? Descripcion { get; set; }
    }
}