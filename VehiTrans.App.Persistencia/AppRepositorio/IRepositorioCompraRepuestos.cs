using System.Collections.Generic;
using VehiTrans.App.Dominio;


namespace VehiTrans.App.Persistencia
{

    public interface IRepositorioComprarRepuestos
    {

        IEnumerable<ComprarRepuestos> GetAllComprarRepuestos();
        ComprarRepuestos AddComprarRepuestos(ComprarRepuestos ComprarRepuestos);
        ComprarRepuestos UpdateComprarRepuestos(ComprarRepuestos ComprarRepuestos);
        void DeleteComprarRepuestos(int ComprarRepuestosId);
        ComprarRepuestos GetComprarRepuestos(int ComprarRepuestosId);

    }
}