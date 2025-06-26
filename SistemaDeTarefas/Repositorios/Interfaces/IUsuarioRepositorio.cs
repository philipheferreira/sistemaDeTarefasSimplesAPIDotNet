using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    { /* Dentro da nossa interface vai ter alguns contratos de usuario. Alguns como buscar usuario,adicionar usuario, remover usuario conforme a necessidade */

        Task<List<UsuarioModel>> BuscarTodosUsuarios(); /* Como eu quero tudo assincrono eu quero utilizar a Task */
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);

    }
}
