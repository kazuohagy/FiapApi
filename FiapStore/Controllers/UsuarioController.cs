using FiapStore.Entidade;
using FiapStore.Interface;
using FiapStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FiapStore.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        [HttpGet("obterUsuario")]
        public IActionResult ObterUsuario() {
            return Ok(_usuarioRepository.ObterTodosUsuarios());
        }
        [HttpGet("obter-por-usuario-id/{id}")]
        public IActionResult ObterUsuarioId(int id) {
            return Ok(_usuarioRepository.ObterUsuarioPorId(id));
        }
        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            _usuarioRepository.CadastrarUsuarioPorId(usuario);
            return Ok("cadastar usuario sucesso");
        }
        [HttpPut]
        public IActionResult AlterarUsuario (Usuario usuario)
        {
            _usuarioRepository.AlterarUsuario(usuario);
            return Ok("Usuario alterado sucesso");
        }
        [HttpDelete]
        public IActionResult DeletarUsuario(int id)
        {
            _usuarioRepository.DeletarUsuario(id);
            return Ok("Usuario deletado sucesso");
        }

    }
}
