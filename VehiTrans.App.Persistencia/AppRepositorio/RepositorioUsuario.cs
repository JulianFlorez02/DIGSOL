using System.Collections.Generic;
using System.Linq;
using VehiTrans.App.Dominio;

namespace VehiTrans.App.Persistencia
{
    public class RepositorioUsuario : IRepositorioUsuario
    {

        ///<summary>
        ///Referencia al contexto de Usuario
        ///</summary>

        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructos 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioUsuario(AppContext appContext)
        {
            _appContext = appContext;
        }


        Usuario IRepositorioUsuario.AddUsuario(Usuario usuario)
        {
            var usuarioAdicionado = _appContext.usuarios.Add(usuario);
            _appContext.SaveChanges();
            return usuarioAdicionado.Entity;
        }

        void IRepositorioUsuario.DeleteUsuario(int idUsuario)
        {

            var usuarioEncontrado = _appContext.usuarios.FirstOrDefault(p => p.Id == idUsuario);
            if (usuarioEncontrado == null)
                return;
            _appContext.usuarios.Remove(usuarioEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuarios()
        {

            return _appContext.usuarios;
        }


        Usuario IRepositorioUsuario.GetUsuario(int idUsuario)
        {

            return _appContext.usuarios.FirstOrDefault(p => p.Id == idUsuario);
        }

        Usuario IRepositorioUsuario.UpdateUsuario(Usuario usuario)
        {
            var usuarioEncontrado = _appContext.usuarios.FirstOrDefault(p => p.Id == usuario.Id);
            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Documento = usuario.Documento;
                usuarioEncontrado.Nombre = usuario.Nombre;
                usuarioEncontrado.Apellidos = usuario.Apellidos;
                usuarioEncontrado.Correo = usuario.Correo;
                usuarioEncontrado.Rol = usuario.Rol;
                usuarioEncontrado.Contraseña = usuario.Contraseña;

                _appContext.SaveChanges();

            }
            return usuarioEncontrado;

        }

    }

}