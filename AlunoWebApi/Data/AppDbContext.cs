using AlunoWebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace AlunoWebApi.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}
