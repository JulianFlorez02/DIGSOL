using System.Collections.Generic;
using System.Linq;
using VehiTrans.App.Dominio;

namespace VehiTrans.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {

        ///<summary>
        ///Referencia al contexto de Persona
        ///</summary>

        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructos 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }


        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var PersonaAdicionado = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return PersonaAdicionado.Entity;
        }

        void IRepositorioPersona.DeletePersona(int idPersona)
        {

            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
            if (PersonaEncontrado == null)
                return;
            _appContext.Personas.Remove(PersonaEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {

            return _appContext.Personas;
        }


        Persona IRepositorioPersona.GetPersona(int idPersona)
        {

            return _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.PersonaId == persona.PersonaId);
            if (PersonaEncontrado != null)
            {
                PersonaEncontrado.Documento = persona.Documento;
                PersonaEncontrado.Nombre = persona.Nombre;
                PersonaEncontrado.Apellidos = persona.Apellidos;
                PersonaEncontrado.Telefono = persona.Telefono;
                PersonaEncontrado.FechaNacimiento = persona.FechaNacimiento;
                PersonaEncontrado.Usuario = persona.Usuario;
                PersonaEncontrado.Contraseña = persona.Contraseña;

                _appContext.SaveChanges();

            }
            return PersonaEncontrado;

        }

    }

}