using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false; // criar uma propriedade para fechar e não confundir com outro Close()
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (CadastroUsuarios.Login(nome,senha)) // caso o usuário tenha passado pelo login
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado!"); // limpar os campos caso o usuário não tenha passado pelo login
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
