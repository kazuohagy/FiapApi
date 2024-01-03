using FiapStore.Entity;

namespace FiapStore.Interface
{
    public class IRepository<T> where T : Entidade
    {
        IList<T> ObterTodosUsuarios();
        T ObterUsuarioPorId(int id);
        void CadastrarUsuarioPorId(T usuario);
        void AlterarUsuario(T usuario);
        void DeletarUsuario(int id);
        
    }
}
