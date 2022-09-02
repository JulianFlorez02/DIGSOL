using System;
using System.ComponentModel.DataAnnotations;

namespace VehiTrans.App.Dominio
{
    public class CompraRepuestos
    {
        [Key]
        public int IdCompraRepuestos  { get; set; }
        public int RepuestosIdRepuestos{ get; set; }
        public string Nombre { get; set; }
        public string costo { get; set; }
        public int RevisionIdRevision { get; set; }
        public string Texto { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaCambio { get; set; }
        public string PlacaVehiculo { get; set; }
    }
}