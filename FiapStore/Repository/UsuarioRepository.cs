﻿using FiapStore.Entidade;
using FiapStore.Interface;
using System.Linq;

namespace FiapStore.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private IList<Usuario> _usuario = new List<Usuario>();

        public IList<Usuario> ObterTodosUsuarios()
        {
            return _usuario;
        }

        public Usuario ObterUsuarioPorId(int id)
        {
            return _usuario.FirstOrDefault(Usuario => Usuario.Id == id);
        }
        public void CadastrarUsuarioPorId(Usuario usuario)
        {
            _usuario.Add(usuario);
        }
        public void AlterarUsuario(Usuario usuario)
        {
            var usuarioParaAlterar = ObterUsuarioPorId(usuario.Id);
            if (usuarioParaAlterar != null)
            {
                usuarioParaAlterar.Nome = usuario.Nome;
            }
        }

        public void DeletarUsuario(int id)
        {
            _usuario.Remove(ObterUsuarioPorId(id));
        }


    }
}
