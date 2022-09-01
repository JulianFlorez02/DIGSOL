using System.Collections.Generic;
using TransporteCiclo3.App.Dominio;


namespace TransporteCiclo3.App.Persistencia
{

    public interface IRepositorioSeguro
    {

        IEnumerable<Seguro> GetAllSeguros();
        Seguro AddSeguro(Seguro VSeguro);
        Seguro UpdateSeguro(Seguro VSeguro);
        void DeleteSeguro(int SeguroId);
        Seguro GetSeguro(int SeguroId);

    }
}