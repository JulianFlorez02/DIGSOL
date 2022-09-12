using System;
using System.ComponentModel.DataAnnotations;

namespace VehiTrans.App.Dominio
{
    public class Vehiculo
    {
        public int VehiculoId  { get; set; }
<<<<<<< HEAD
        [Required]
        //[MaxLength(7),MinLength(1)]
        public string Placa { get; set; }
        [Required]
        //[MaxLength(30),MinLength(1)]
        public string Marca { get; set; }
        //[MaxLength(30),MinLength(1)]
        public int Modelo { get; set; }
        public int VehiculoTipoId  { get; set; }
        public VehiculoTipo? VehiculoTipo { get; set; }
        [Required]
=======
        [Required,StringLength(50)]
        public string? Placa { get; set; }
        [Required,StringLength(50)]
        public string? Marca { get; set; }
        [Required,StringLength(50)]
        public string? Modelo { get; set; }
        public int VehiculoTipoId  { get; set; }
        public VehiculoTipo? VehiculoTipo { get; set; }
        [Required,StringLength(50)]
>>>>>>> c61c4e093cf095855e8d856cb3a82ff796f32a33
        public int CantidadPasajeros { get; set; }
        [Required,StringLength(50)]
        public int CilindrajeMotor { get; set; }
        [Required,StringLength(50)]
        public int PropietarioId { get; set; }
        public Propietario? Propietario { get; set; }
        public int ConductorId { get; set; }
        public Conductor? Conductor { get; set; }
        public int MecanicoId { get; set; }
        public Mecanico? Mecanico { get; set; }
    }
}