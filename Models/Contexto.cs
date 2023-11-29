using Microsoft.EntityFrameworkCore;

namespace LoginPederneiras.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Fornecedor> Fornecedor { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<EntradaProduto> EntradaProduto { get; set; }

        public DbSet<SaidaProduto> SaidaProduto { get; set; }


    }
}
