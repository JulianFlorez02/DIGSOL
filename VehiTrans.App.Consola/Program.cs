using System;
using VehiTrans.App.Dominio;
using VehiTrans.App.Persistencia;

namespace VehiTrans.App.Consola
{
    class Program
    {
      /* Referencia a RepositorioUsuario a traves de la interfaz*/
        private static IRepositorioUsuario _repoUsuario = new RepositorioUsuario(new Persistencia.AppContext());

        static void Main(string[] args)

        {
            Console.WriteLine("Hello, World!");
            //AddUsuario();
            BuscarUsuario(1);
        }
        private static void AddUsuario()
        {
            var Usuario = new Usuario
            {
                Documento = "1012932121",
                Nombre = "Mathias",
                Apellidos = "Velasco Piña",
                Correo = "mathias231@gmail.com",
                Rol = Rol.JefeOperaciones,
                Contraseña = "Barcelona123",
            };

            _repoUsuario.AddUsuario(Usuario);

        }

        private static void BuscarUsuario(int idUsuario)
        {
            var Usuario = _repoUsuario.GetUsuario(idUsuario);
            Console.WriteLine(Usuario.Nombre+" "+Usuario.Apellidos);
        }


    }


}