using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

//comentário de linha

namespace Mobilitec_Services
{
    //isso é uma classe do sistema
    public partial class frmLogin : Form
    {

        public string nome;

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        //comentário de linha
        public frmLogin()
        {
            InitializeComponent();

        }
        /*
         * autor:
         * data:
         * comentário de bloco
         * 
         * */

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool validaUsuario(string nomeUsu, string senhaUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbusuarios where nomeUsu = @nomeUsu and senhaUsu = @senhaUsu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nomeUsu", MySqlDbType.VarChar, 20).Value = nomeUsu;
            comm.Parameters.Add("@senhaUsu", MySqlDbType.VarChar, 20).Value = senhaUsu;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            bool resultado = DR.HasRows;

            return resultado;

            Conexao.fecharConexao();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario, senha;

            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if (validaUsuario(usuario, senha))
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}