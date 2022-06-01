using AlunoWebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace AlunoWebApi.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Endereco>()
                .HasOne(endereco => endereco.Aluno)
                .WithOne(aluno => aluno.Endereco)
                .HasForeignKey<Aluno>(aluno => aluno.idEndereco); 
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
