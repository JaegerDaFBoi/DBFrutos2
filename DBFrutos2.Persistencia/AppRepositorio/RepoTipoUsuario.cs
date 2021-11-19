using System.Collections.Generic;
using System.Linq;
using DBFrutos2.Dominio;
using Microsoft.EntityFrameworkCore;

namespace DBFrutos2.Persistencia
{
    public class RepoTipoUsuario : IRepoTipoUsuario
    {
        private readonly AppContext _appContext = new AppContext();

        TipoUsuario IRepoTipoUsuario.AddRol(TipoUsuario tipoUsuario)
        {
            var rolAgregado = _appContext.TiposUsuario.Add(tipoUsuario);
            _appContext.SaveChanges();
            return rolAgregado.Entity;
        }

        void IRepoTipoUsuario.DeleteRol(int idTipoUsuario)
        {
            var rolEncontrado = _appContext.TiposUsuario.Find(idTipoUsuario);
            if(rolEncontrado==null)
            return;
            _appContext.TiposUsuario.Remove(rolEncontrado);
            _appContext.SaveChanges();
        }

        TipoUsuario IRepoTipoUsuario.GetRol(int idTipoUsuario)
        {
            return _appContext.TiposUsuario.Find(idTipoUsuario);
        }
    }
}