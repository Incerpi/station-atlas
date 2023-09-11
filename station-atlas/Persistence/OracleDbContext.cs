using station_atlas.Models;
using Microsoft.EntityFrameworkCore;

namespace station_atlas.Persistence
{
    public class OracleDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Pagamento> Pagamento { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Pedido> Pedido { get; set; }


        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options) { }
    }
}
