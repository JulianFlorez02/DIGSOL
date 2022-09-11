using System;
using System.ComponentModel.DataAnnotations;

namespace VehiTrans.App.Dominio
{
    public class VehiculoTipo
    {
        public int VehiculoTipoId  { get; set; }
        [Required,StringLength(50)]
        public string? Descripcion { get; set; }
        
    }
}