using Microsoft.EntityFrameworkCore;
using Sivan.Models.Entities;

namespace Sivan.DataAccess
{
    public class SivanDbContext : DbContext
    {
        //public SivanDbContext( DbContextOptions<SivanDbContext> options ) : base(options)
        //{

        //}

        protected override void OnModelCreating( ModelBuilder builder )
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            //optionsBuilder.UseSqlServer(@"Data Source = localhost; Initial Catalog = SMSAsignaciones; Integrated Security = true");
            //optionsBuilder.UseSqlServer(@"Server=sbadesa017;Database=ACADEMY_NET_ANTO;User Id = net_anto; Password=Academy_2022");


            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Database=Sivan; Trusted_Connection=True;"); // JOSE
            //optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Database=sivan; Trusted_Connection=True;"); // ANTO
            //optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Database=Sivan; Trusted_Connection=True;");

        }

        public DbSet<CarritoItem> CarritoItems { get; set; }
        public DbSet<CompraSesion> CrompraSesiones { get; set; }
        public DbSet<Descuento> Descuentos { get; set; }
        public DbSet<Imagenes> ImagenesProducto { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<OrdenDetalle> OrdenDetalles { get; set; }
        public DbSet<OrdenItem> OrdenItems { get; set; }
        public DbSet<PagoDetalle> PagoDetalles { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoCategoria> ProductoCategorias { get; set; }
        public DbSet<ProductoInventario> ProductoInventarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioDireccion> UsuarioDirecciones { get; set; }
        public DbSet<UsuarioPagos> UsuarioPagoes { get; set; }
    }
}
