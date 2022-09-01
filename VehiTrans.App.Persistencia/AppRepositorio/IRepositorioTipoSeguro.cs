using System.Collections.Generic;
using TransporteCiclo3.App.Dominio;


namespace TransporteCiclo3.App.Persistencia
{

    public interface IRepositorioTipoSeguro
    {

        IEnumerable<TipoSeguro> GetAllTipoSeguros();
        TipoSeguro AddTipoSeguro(TipoSeguro Vtiposeguro);
        TipoSeguro UpdateTipoSeguro(TipoSeguro Vtiposeguro);
        void DeleteTipoSeguro(int TipoSeguroId);
        TipoSeguro GetTipoSeguro(int TipoSeguroId);

    }
}