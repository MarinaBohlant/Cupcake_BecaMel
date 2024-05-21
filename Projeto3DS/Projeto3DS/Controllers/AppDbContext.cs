using Microsoft.EntityFrameworkCore;
using Projeto3DS.Models;

namespace Projeto3DS.Controllers
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cupcake> Cupcake { get; set; }
    }
}
