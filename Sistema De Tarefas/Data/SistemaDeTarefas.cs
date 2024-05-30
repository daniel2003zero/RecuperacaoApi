using Microsoft.EntityFrameworkCore;
using Sistema_De_Tarefas.Models;

namespace Sistema_De_Tarefas.Data
{

    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options)
        : base(options) 
            {
 
            }

        public DbSet<UsuarioModel> usuarios { get; set; }   

        public DbSet<TarefaModel> tarefa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

}

