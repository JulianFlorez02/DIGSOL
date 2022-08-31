using System.Collections.Generic;
using VehiTrans.App.Dominio;


namespace VehiTrans.App.Persistencia
{

    public interface IRepositorioUsuario
    {

        IEnumerable<Usuario> GetAllUsuarios();
        Usuario AddUsuario(Usuario usuario);
        Usuario UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int idUsuario);
        Usuario GetUsuario(int idUsuario);

    }
}