using System;
using VehiTrans.App.Dominio;
using VehiTrans.App.Persistencia;

namespace VehiTrans.App.Consola
{
    class Program
    {
      /* Referencia a RepositorioPersona a traves de la interfaz*/
        private static IRepositorioPersona _repoPersona= new RepositorioPersona(new Persistencia.AppContext());

        static void Main(string[] args)

        {
            Console.WriteLine("Hello, World!");
            AddPersona();
            //BuscarPersona(1);
        }
        private static void AddPersona()
        {
            var Persona = new Persona
            {
                Documento = "1012932121",
                Nombre = "Mathias",
                Apellidos = "Velasco Piña",
                Telefono = "mathias231@gmail.com",
                Usuario = "Mathias1012",
                Contraseña = "Barcelona123",
            };

            _repoPersona.AddPersona(Persona);

        }

        private static void BuscarPersona(int idPersona)
        {
            var Persona = _repoPersona.GetPersona(idPersona);
            Console.WriteLine(Persona.Nombre+" "+Persona.Apellidos);
        }


    }


}