using System.Collections.Generic;
using System.Linq;
using VehiTrans.App.Dominio;

namespace VehiTrans.App.Persistencia
{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {

        ///<summary>
        ///Referencia al contexto de Auxiliar
        ///</summary>

        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructos 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioAuxiliar(AppContext appContext)
        {
            _appContext = appContext;
        }


        Auxiliar IRepositorioAuxiliar.AddAuxiliar(Auxiliar auxiliar)
        {
            var AuxiliarAdicionado = _appContext.Auxiliares.Add(auxiliar);
            _appContext.SaveChanges();
            return AuxiliarAdicionado.Entity;
        }

        void IRepositorioAuxiliar.DeleteAuxiliar(int idAuxiliar)
        {

            var AuxiliarEncontrado = _appContext.Auxiliares.FirstOrDefault(p => p.AuxiliarId == idAuxiliar);
            if (AuxiliarEncontrado == null)
                return;
            _appContext.Auxiliares.Remove(AuxiliarEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<Auxiliar> IRepositorioAuxiliar.GetAllAuxiliares()
        {

            return _appContext.Auxiliares;
        }


        Auxiliar IRepositorioAuxiliar.GetAuxiliar(int idAuxiliar)
        {

            return _appContext.Auxiliares.FirstOrDefault(p => p.Id == idAuxiliar);
        }

        Auxiliar IRepositorioAuxiliar.UpdateAuxiliar(Auxiliar auxiliar)
        {
            var AuxiliarEncontrado = _appContext.Auxiliares.FirstOrDefault(p => p.AuxiliarId == auxiliar.AuxiliarId);
            if (AuxiliarEncontrado != null)
            {
                AuxiliarEncontrado.Direccion = auxiliar.Direccion;
                AuxiliarEncontrado.PersonaId = auxiliar.PersonaId;
                AuxiliarEncontrado.Persona = auxiliar.Persona;

                _appContext.SaveChanges();

            }
            return AuxiliarEncontrado;

        }

    }

}