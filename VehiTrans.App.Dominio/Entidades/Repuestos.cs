using System;
using System.ComponentModel.DataAnnotations;

namespace VehiTrans.App.Dominio
{
    public class Repuestos
    {
        [Key]
        public int IdRepuestos {get;set; }
        public int Codigo { get; set; }
        public string Cantidad { get; set; }
        public string CorreoProveedor { get; set; }
        public Responsable Rol { get; set; }
        public string AprobadoPor {get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInstalacion {get; set; }
        public DateTime FechaCambio {get; set; }
        public string PlacaVehiculo {get; set; }
    }
}