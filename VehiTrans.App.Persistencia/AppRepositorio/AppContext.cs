using Microsoft.EntityFrameworkCore;
using VehiTrans.App.Dominio;

namespace VehiTrans.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona>? Personas { get; set; }
        public Dbset<Auxiliar>? Auxiliares {get;set;}
        public Dbset<Conductor>? Conductores {get;set;}
        public Dbset<JefeOperaciones>? JefeOperaciones {get;set;}
        public Dbset<Mecanico>? Mecanicos {get;set;}
        public Dbset<Propietario>? Propietarios {get;set;}
        public DbSet<TipoSeguro> Tiposeguros { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<TipoSeguro> TipoSeguros { get; set; }
        public DbSet<Revision> Revisiones {get; set;}
        public DbSet<CompraRepuestos> ComprasRepuestos {get; set;}
        public DbSet<Repuestos> Repuestos {get; set;}

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