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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();

            // caso o usuário não logou/cadastrou a tela vai voltar a reabrir
            while (CadastroUsuarios.UsuarioLogado == null)
            {
                Visible = false; // torna o formulario invisível
                f.ShowDialog();

                if (FormLogin.Cancelar) // caso for verdadeiro
                {
                    Application.Exit(); //finaliza a aplicação
                    return;
                }
            }

            label_BoasVindas.Text = "Bem-Vindo(a) \n" + CadastroUsuarios.UsuarioLogado.Nome;
            Visible = true;
        }
    }
}
