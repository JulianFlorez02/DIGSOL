using System;
using System.ComponentModel.DataAnnotations;

namespace VehiTrans.App.Dominio
{
    public class TipoSeguro
    {
        [Key]
        public int TipoSeguroId  { get; set; }
        [Required,StringLength(50)]
        public string? Descripcion { get; set; }
    }
}