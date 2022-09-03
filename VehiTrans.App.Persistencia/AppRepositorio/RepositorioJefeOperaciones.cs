using System.Collections.Generic;
using System.Linq;
using VehiTrans.App.Dominio;

namespace VehiTrans.App.Persistencia
{
    public class RepositorioJefeOperaciones : IRepositorioJefeOperaciones
    {

        ///<summary>
        ///Referencia al contexto de JefeOperaciones
        ///</summary>

        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructos 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioJefeOperaciones(AppContext appContext)
        {
            _appContext = appContext;
        }


        JefeOperaciones IRepositorioJefeOperaciones.AddJefeOperaciones(JefeOperaciones jefeOperaciones)
        {
            var JefeOperacionesAdicionado = _appContext.JefeOperaciones.Add(jefeOperaciones);
            _appContext.SaveChanges();
            return JefeOperacionesAdicionado.Entity;
        }

        void IRepositorioJefeOperaciones.DeleteJefeOperaciones(int idJefeOperaciones)
        {

            var JefeOperacionesEncontrado = _appContext.JefeOperaciones.FirstOrDefault(p => p.Id == idJefeOperaciones);
            if (JefeOperacionesEncontrado == null)
                return;
            _appContext.JefeOperaciones.Remove(JefeOperacionesEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<JefeOperaciones> IRepositorioJefeOperaciones.GetAllJefeOperaciones()
        {

            return _appContext.JefeOperaciones;
        }


        JefeOperaciones IRepositorioJefeOperaciones.GetJefeOperaciones(int idJefeOperaciones)
        {

            return _appContext.JefeOperaciones.FirstOrDefault(p => p.Id == idJefeOperaciones);
        }

        JefeOperaciones IRepositorioJefeOperaciones.UpdateJefeOperaciones(JefeOperaciones jefeOperaciones)
        {
            var JefeOperacionesEncontrado = _appContext.JefeOperaciones.FirstOrDefault(p => p.JefeOperacionesId == jefeOperaciones.JefeOperacionesId);
            if (JefeOperacionesEncontrado != null)
            {
                JefeOperacionesEncontrado.Correo = jefeOperaciones.Correo;
                JefeOperacionesEncontrado.PersonaId = jefeOperaciones.PersonaId;
                JefeOperacionesEncontrado.Persona = jefeOperaciones.Persona;

                _appContext.SaveChanges();

            }
            return JefeOperacionesEncontrado;

        }

    }

}