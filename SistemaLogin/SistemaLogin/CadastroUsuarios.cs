using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios = 
        {
            new Usuario(){Nome= "Gabriele", Senha= "abc123"},
            new Usuario(){Nome= "Arya", Senha="gata1"},
            new Usuario(){Nome= "Lisa", Senha="gata2"},
            new Usuario(){Nome= "Bart", Senha="gato3"}
        };

        private static Usuario _userLogado = null; // no inicio não tem nenhum usuário logado

        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach(Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
