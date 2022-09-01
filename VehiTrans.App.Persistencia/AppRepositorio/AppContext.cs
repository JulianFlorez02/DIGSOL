using Microsoft.EntityFrameworkCore;
using VehiTrans.App.Dominio;

namespace VehiTrans.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Usuario>? usuarios { get; set; }
        public DbSet<TipoSeguro> Tiposeguros { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Seguro> Seguros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = VehiTrans.Data");
            }


        }
    }
}