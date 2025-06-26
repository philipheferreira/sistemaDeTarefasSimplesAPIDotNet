using Microsoft.EntityFrameworkCore; /* Adiciona a extensão baixada pelo nuggets */
using SistemaDeTarefas.Models;

/* Dentro do codigo o ORM serve para facilitar a criação das funcionalidades em um banco de dados */

namespace SistemaDeTarefas.Data
{
    public class SistemaTarefasDBContex : DbContext /* A funcionalidade DBContex é um ambiente que funciona todas as configurações gerais de um banco de dados */
    {

        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options) : base(options) 
        {
            
            

        }

        public DbSet<UsuarioModel> Usuarios { get; set; } /* A UsuarioModel representa a funcionalidade de uma tabela dentro do banco de dados */
        public DbSet<TerafaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
