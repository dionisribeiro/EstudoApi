using Microsoft.EntityFrameworkCore;
using UsuarioApi.Domain;

namespace UsuarioApi.Infra.Data.UsuarioDbContexto
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options)
            : base(options) 
        {}

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
