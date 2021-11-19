using System.Collections.Generic;
using System.Linq;
using DBFrutos2.Dominio;
using Microsoft.EntityFrameworkCore;

namespace DBFrutos2.Persistencia
{
    public class RepoUsuario : IRepoUsuario
    {
        private readonly AppContext _appContext = new AppContext();

        Usuario IRepoUsuario.AddUsuario(Usuario usuario)
        {
            var usuarioAgregado = _appContext.Usuarios.Add(usuario);
            _appContext.SaveChanges();
            return usuarioAgregado.Entity;
        }

        void IRepoUsuario.DeleteUsuario(int idUsuario)
        {
            var usuarioEncontrado = _appContext.Usuarios.Find(idUsuario);
            if(usuarioEncontrado==null)
                return;
            _appContext.Usuarios.Remove(usuarioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Usuario> IRepoUsuario.GetAllUsuarios()
        {
            return _appContext.Usuarios;
        }

        Usuario IRepoUsuario.GetUsuario(int idUsuario)
        {
            return _appContext.Usuarios.Find(idUsuario);
        }

        Usuario IRepoUsuario.UpdateUsuario(Usuario usuario)
        {
            var usuarioEncontrado = _appContext.Usuarios.Find(usuario.Id);
            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.TipoUsuario = usuario.TipoUsuario;
                usuarioEncontrado.Nombre = usuario.Nombre;
                usuarioEncontrado.Documento = usuario.Documento;
                usuarioEncontrado.Telefono = usuario.Telefono;
                usuarioEncontrado.Direccion = usuario.Direccion;
                usuarioEncontrado.Email = usuario.Email;
                usuarioEncontrado.Ciudad = usuario.Ciudad;
                _appContext.SaveChanges();
            }
            return usuarioEncontrado;
        }
    }
}