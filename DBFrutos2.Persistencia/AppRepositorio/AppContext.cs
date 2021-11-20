using System;
using Microsoft.EntityFrameworkCore;
using DBFrutos2.Dominio;

namespace DBFrutos2.Persistencia
{
    public class AppContext : DbContext
    {   
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<SolicitudPedidos> SolicitudesPedidos { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Initial Catalog=DataBaseFrutos; Data Source=DESKTOP-AO7R2KJ\\SQLEXPRESS; Integrated Security=true");
            }
        }  
    }
}