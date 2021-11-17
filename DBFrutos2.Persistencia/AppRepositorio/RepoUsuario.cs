using System.Collections.Generic;
using System.Linq;
using DBFrutos2.Dominio;
using Microsoft.EntityFrameworkCore;

namespace DBFrutos2.Persistencia
{
    public class RepoUsuario : IRepoUsuario
    {
        private readonly AppContext _appContext=new AppContext();

        Usuario IRepoUsuario.AddUsuario(Usuario usuario)
        {
            var usuarioadicionado = _appContext.Usuarios.Add(usuario);
            _appContext.SaveChanges();
            return usuarioadicionado.Entity;
        }
        void IRepoUsuario.DeleteUsuario(int idUsuario)
        {
            var usuarioencontrado = _appContext.Usuarios.Find(idUsuario);
            if (usuarioencontrado == null)
            return;
            _appContext.Usuarios.Remove(usuarioencontrado);

        }
    }
}