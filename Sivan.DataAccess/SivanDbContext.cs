using Microsoft.EntityFrameworkCore;

namespace Sivan.DataAccess
{
    public class SivanDbContext : DbContext
    {
        public SivanDbContext( DbContextOptions<SivanDbContext> options ) : base(options)
        {

        }

        protected override void OnModelCreating( ModelBuilder builder )
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            //optionsBuilder.UseSqlServer(@"Data Source = localhost; Initial Catalog = SMSAsignaciones; Integrated Security = true");
            //optionsBuilder.UseSqlServer(@"Server=sbadesa017;Database=ACADEMY_NET_ANTO;User Id = net_anto; Password=Academy_2022");


            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Database=Sivan; Trusted_Connection=True;"); // JOSE
            //optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Database=sivan; Trusted_Connection=True;"); 
            //optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Database=Sivan; Trusted_Connection=True;");

        }

        //public DbSet<Color> Colores { get; set; }
    }
}
