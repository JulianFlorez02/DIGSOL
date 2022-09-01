using System.Collections.Generic;
using TransporteCiclo3.App.Dominio;


namespace TransporteCiclo3.App.Persistencia
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