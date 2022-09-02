using System.Collections.Generic;
using VehiTrans.App.Dominio;


namespace VehiTrans.App.Persistencia
{

    public interface IRepositorioVehiculo
    {

        IEnumerable<Vehiculo> GetAllVehiculos();
        Vehiculo AddVehiculo(Vehiculo VVehiculo);
        Vehiculo UpdateVehiculo(Vehiculo VVehiculo);
        void DeleteVehiculo(int VehiculoId);
        Vehiculo GetVehiculo(int VehiculoId);

    }
}