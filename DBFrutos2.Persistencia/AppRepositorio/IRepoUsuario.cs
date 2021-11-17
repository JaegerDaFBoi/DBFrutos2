using System.Collections.Generic;
using DBFrutos2.Dominio;

namespace DBFrutos2.Persistencia
{
    public interface IRepoUsuario
    {
        IEnumerable<Usuario> GetUsuarios();
        Usuario AddUsuario(Usuario usuario);
        Usuario UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int idUsuario);
        Usuario GetUsuario(int idUsuario);
    }
}