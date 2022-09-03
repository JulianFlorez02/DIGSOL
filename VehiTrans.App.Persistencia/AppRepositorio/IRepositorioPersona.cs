using System.Collections.Generic;
using VehiTrans.App.Dominio;


namespace VehiTrans.App.Persistencia
{

    public interface IRepositorioPersona
    {

        IEnumerable<Persona> GetAllPersonas();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int idPersona);
        Persona GetPersona(int idPersona);

    }
}