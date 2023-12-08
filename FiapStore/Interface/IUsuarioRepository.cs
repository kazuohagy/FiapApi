using FiapStore.Entidade;

namespace FiapStore.Interface
{
    public interface IUsuarioRepository
    {
        IList<Usuario> ObterTodosUsuarios();

        Usuario ObterUsuarioPorId(int id);

        void CadastrarUsuarioPorId(Usuario usuario);

        void AlterarUsuario(Usuario usuario);

        void DeletarUsuario(int id);

    }
}
