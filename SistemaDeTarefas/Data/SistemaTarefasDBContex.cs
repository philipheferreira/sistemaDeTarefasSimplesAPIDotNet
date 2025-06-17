using Microsoft.EntityFrameworkCore; /* Adiciona a extensão baixada pelo nuggets */
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    public class SistemaTarefasDBContex : DbContext
    {

        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options) : base(options) 
        {
            
            

        }

        public DbSet<UsuarioModel> Usuarios { get; set; } /* Pega as variaveis dentro da pasta model sobre o UsuarioModel que foi criado como base */

    }
}
