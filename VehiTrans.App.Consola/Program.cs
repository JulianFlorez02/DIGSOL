using System;
using VehiTrans.App.Dominio;
using VehiTrans.App.Persistencia;

namespace VehiTrans.App.Consola
{
    class Program
    {
      /* Referencia a RepositorioMecanico a traves de la interfaz*/
        private static IRepositorioMecanico _repoMecanico= new RepositorioMecanico(new Persistencia.AppContext());

        static void Main(string[] args)

        {
            Console.WriteLine("Hello, World!");
            AddMecanico();
            //BuscarMecanico(1);
        }
        private static void AddMecanico()
        {
            var Mecanico = new Mecanico
            {
                Documento = "1012932121",
                Nombre = "Mathias",
                Apellidos = "Velasco Piña",
                Telefono = "mathias231@gmail.com",
                Usuario = "Mathias1012",
                Contraseña = "Barcelona123",
            };

            _repoMecanico.AddMecanico(Mecanico);

        }

        private static void BuscarMecanico(int idMecanico)
        {
            var Mecanico = _repoMecanico.GetMecanico(idMecanico);
            Console.WriteLine(Mecanico.Nombre+" "+Mecanico.Apellidos);
        }


    }


}