using mf_apiwebserv.Model;
using Microsoft.EntityFrameworkCore;

namespace mf_apiwebserv.Models
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
    }
}
