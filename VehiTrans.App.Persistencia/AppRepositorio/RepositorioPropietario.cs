using System.Collections.Generic;
using System.Linq;
using VehiTrans.App.Dominio;

namespace VehiTrans.App.Persistencia
{
    public class RepositorioPropietario : IRepositorioPropietario
    {

        ///<summary>
        ///Referencia al contexto de Propietario
        ///</summary>

        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructos 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioPropietario(AppContext appContext)
        {
            _appContext = appContext;
        }


        Propietario IRepositorioPropietario.AddPropietario(Propietario propietario)
        {
            var PropietarioAdicionado = _appContext.Propietario.Add(propietario);
            _appContext.SaveChanges();
            return PropietarioAdicionado.Entity;
        }

        void IRepositorioPropietario.DeletePropietario(int idPropietario)
        {

            var PropietarioEncontrado = _appContext.Propietario.FirstOrDefault(p => p.Id == idPropietario);
            if (PropietarioEncontrado == null)
                return;
            _appContext.Propietario.Remove(PropietarioEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietario()
        {

            return _appContext.Propietario;
        }


        Propietario IRepositorioPropietario.GetPropietario(int idPropietario)
        {

            return _appContext.Propietario.FirstOrDefault(p => p.Id == idPropietario);
        }

        Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietario)
        {
            var PropietarioEncontrado = _appContext.Propietario.FirstOrDefault(p => p.Id == Propietario.Id);
            if (PropietarioEncontrado != null)
            {
                PropietarioEncontrado.Ciudad = propietario.Ciudad;
                PropietarioEncontrado.Correo = propietario.Correo;
                PropietarioEncontrado.PersonaId = propietario.PersonaId;
                PropietarioEncontrado.Persona = propietario.Persona;

                _appContext.SaveChanges();

            }
            return PropietarioEncontrado;

        }

    }

}