using System;
using System.ComponentModel.DataAnnotations;

namespace VehiTrans.App.Dominio
{
    public class Vehiculo
    {
        public int VehiculoId  { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int UsuarioIdPropietario { get; set; }
        public int UsuarioIdConductor { get; set; }
        public int UsuarioIdMecanico { get; set; }
    }
}