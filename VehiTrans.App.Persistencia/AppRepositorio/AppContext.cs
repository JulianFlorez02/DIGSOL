using Microsoft.EntityFrameworkCore;
using VehiTrans.App.Dominio;

namespace VehiTrans.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Usuario>? usuarios { get; set; }

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