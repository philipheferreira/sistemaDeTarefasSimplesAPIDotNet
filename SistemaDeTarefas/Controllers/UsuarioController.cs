using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")] /* O endeço de acesso para essa api é a porta e o IP de acesso para essa API + api/controller */
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return Ok();
        }
    }
}
