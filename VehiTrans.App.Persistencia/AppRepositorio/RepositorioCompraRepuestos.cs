using System.Collections.Generic;
using System.Linq;
using VehiTrans.App.Dominio;

namespace VehiTrans.App.Persistencia
{
    public class RepositorioCompraRepuestos : IRepositorioCompraRepuestos
    {

        ///<summary>
        ///Referencia al contexto de CompraRepuestos
        ///</summary>

        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructos 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioCompraRepuestos(AppContext appContext)
        {
            _appContext = appContext;
        }


        CompraRepuestos IRepositorioCompraRepuestos.AddCompraRepuestos(CompraRepuestos CompraRepuestos)
        {
            var CompraRepuestosAdicionado = _appContext.Tiposeguros.Add(CompraRepuestos);
            _appContext.SaveChanges();
            return CompraRepuestosAdicionado.Entity;
        }

        void IRepositorioCompraRepuestos.DeleteCompraRepuestos(int IdCompraRepuestos)
        {

            var CompraRepuestosEncontrado = _appContext.Tiposeguros.FirstOrDefault(p => p.IdCompraRepuestos == IdCompraRepuestos);
            if (CompraRepuestosEncontrado == null)
                return;
            _appContext.Tiposeguros.Remove(CompraRepuestosEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<CompraRepuestos> IRepositorioCompraRepuestos.GetAllCompraRepuestoss()
        {

            return _appContext.Comprarepuestos;
        }


        CompraRepuestos IRepositorioCompraRepuestos.GetCompraRepuestos(int IdCompraRepuestos)
        {
            return _appContext.Tiposeguros.FirstOrDefault(p => p.IdCompraRepuestos == IdCompraRepuestos);
        }

        CompraRepuestos IRepositorioCompraRepuestos.UpdateCompraRepuestos(CompraRepuestos CompraRepuestos)
        {
            var CompraRepuestosEncontrado = _appContext.Tiposeguros.FirstOrDefault(p => p.IdCompraRepuestos == CompraRepuestos.IdCompraRepuestos);
            if (CompraRepuestosEncontrado != null)
            {
                IdCompraRepuestosEncontrado.Descripcion = IdCompraRepuestos.Descripcion;
                
                _appContext.SaveChanges();

            }
            return CompraRepuestosEncontrado;

        }

    }

}