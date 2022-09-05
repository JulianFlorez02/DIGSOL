using System.Collections.Generic;
using System.Linq;
using VehiTrans.App.Dominio;

namespace VehiTrans.App.Persistencia
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {

        ///<summary>
        ///Referencia al contexto de Vehiculo
        ///</summary>

        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructos 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioVehiculo(AppContext appContext)
        {
            _appContext = appContext;
        }


        Vehiculo IRepositorioVehiculo.AddVehiculo(Vehiculo vvehiculo)
        {
            var vvehiculoAdicionado = _appContext.Vehiculos.Add(vvehiculo);
            _appContext.SaveChanges();
            return vvehiculoAdicionado.Entity;
        }

        void IRepositorioVehiculo.DeleteVehiculo(int vVehiculoId)
        {

            var vvehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(p => p.VehiculoId == vVehiculoId);
            if (vvehiculoEncontrado == null)
                return;
            _appContext.Vehiculos.Remove(vvehiculoEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllVehiculos()
        {
            return _appContext.Vehiculos;
        }


        Vehiculo IRepositorioVehiculo.GetVehiculo(int VehiculoId)
        {
            return _appContext.Vehiculos.FirstOrDefault(p => p.VehiculoId == VehiculoId);
        }

        Vehiculo IRepositorioVehiculo.UpdateVehiculo(Vehiculo vvehiculo)
        {
            var vvehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(p => p.VehiculoId == vvehiculo.VehiculoId);
            if (vvehiculoEncontrado != null)
            {
                vvehiculoEncontrado.Placa = vvehiculo.Placa;
                vvehiculoEncontrado.Marca = vvehiculo.Marca;
                vvehiculoEncontrado.Modelo = vvehiculo.Modelo;
                vvehiculoEncontrado.VehiculoTipoId = vvehiculo.VehiculoTipoId;
                vvehiculoEncontrado.CantidadPasajeros = vvehiculo.CantidadPasajeros;
                vvehiculoEncontrado.CilindrajeMotor = vvehiculo.CilindrajeMotor;
                vvehiculoEncontrado.PropietarioId = vvehiculo.PropietarioId;
                vvehiculoEncontrado.ConductorId = vvehiculo.ConductorId;
                vvehiculoEncontrado.MecanicoId = vvehiculo.MecanicoId;

                
                _appContext.SaveChanges();

            }
            return vvehiculoEncontrado;

        }

    }

}