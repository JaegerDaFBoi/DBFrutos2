using System.Collections.Generic;
using DBFrutos2.Dominio;


namespace DBFrutos2.Persistencia
{
    public interface IRepoTipoUsuario
    {
        TipoUsuario AddRol(TipoUsuario tipoUsuario);
        void DeleteRol(int idTipoUsuario);
        TipoUsuario GetRol(int idTipoUsuario);
    }
}