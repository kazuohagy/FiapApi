using FiapStore.Entity;
using FiapStore.Interface;
using System.Linq;

namespace FiapStore.Repository
{
    public class UsuarioRepository : DapperREpository<Usuario>,IUsuarioRepository
    {
        public UsuarioRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void AlterarUsuario(Usuario usuario)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("UPDATE Usuario SET Nome = @Nome WHERE Id = @Id", usuario);
            }
        }

        public void CadastrarUsuarioPorId(Usuario usuario)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("INSERT INTO Usuario (Nome) VALUES (@Nome)", usuario);
            }
        }

        public void DeletarUsuario(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Execute("DELETE FROM Usuario WHERE Id = @Id", new { Id = id });
            }
        }

        public Usuario ObterUsuarioPorId(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                return connection.Query<Usuario>("SELECT * FROM Usuario WHERE Id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

        public IList<Usuario> ObterTodosUsuarios()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                return connection.Query<Usuario>("SELECT * FROM Usuario").ToList();
            }



        }
}
