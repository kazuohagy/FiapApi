using FiapStore.Entity;
using FiapStore.Interface;

namespace FiapStore.Repository
{
    public abstract class DapperREpository<T> : IRepository<T> where T : Entidade
    {
        private readonly string _connectionString;

        protected string ConnectionString => _connectionString;
        public DapperREpository(IConfiguration configuration)
        {
            _connectionString = configuration.GetValue<string>("ConnectionString");
        }
        public void AlterarUsuario(T usuario)
        {
            throw new System.NotImplementedException();
        }

        public void CadastrarUsuarioPorId(T usuario)
        {
            throw new System.NotImplementedException();
        }

        public void DeletarUsuario(int id)
        {
            throw new System.NotImplementedException();
        }

        public T ObterUsuarioPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<T> ObterTodosUsuarios()
        {
            throw new System.NotImplementedException();
        }

    }
}
