using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;

/// 26:29 - tempo que parei

namespace SistemaDeTarefas.Repositorios
{ /* Implementa o metodo propriamente dito do usuario repositorio. Para funcionar o metodo precisa necessariamente ser classe */
    public class UsuarioRepositorio : IUsuarioRepositorio /* chamando as interfaces cria e chama todos os metodos para a utilização desse codigo  */
    {
        private readonly SistemaTarefasDBContex _dbContext;
        public UsuarioRepositorio(SistemaTarefasDBContex sistemaTarefasDBContex) /* Construtor criado para injetar nosso DBContex */
        {
            _dbContext = sistemaTarefasDBContex;
        }

        /* INICIO DOS METODOS DE BUSCA */
        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        /* FIM DOS METODOS DE BUSCA */

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }



        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {

            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }

            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Email = usuario.Email;

            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync(); 
            
            return usuarioPorId;

        }

        public async Task<bool> Apagar(int id)
        {

            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
