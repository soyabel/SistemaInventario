using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SistemaInventario.Modelos;
using System.Data;
using System.Reflection;


namespace SistemaInventario.AccesoDatos.Data
{
    //IdentityDbContext: es una extensión de DbContext proporcionada por ASP.NET Core Identity, que incluye configuraciones y funcionalidades específicas para la gestión de usuarios, roles y seguridad en la aplicació
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bodega> Bodegas { get; set; }
        public DbSet<Categoria> Categorias {  get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); //Llamamos al método OnModelCreating de la clase base(IdentityDbContext)
        //builder: Es una instancia de ModelBuilder, que se utiliza para configurar el modelo de datos de Entity Framework Core.
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        // Este método escanea el ensamblado actual(Assembly.GetExecutingAssembly()) en busca de todas
        // las clases que implementan IEntityTypeConfiguration<T> y aplica sus configuraciones al modelo.
        }
    }
}
