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

namespace Mobilitec_Services
{
    public partial class frmUsuarios : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmUsuarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmUsuarios(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            txtNome.Text = nome;
            habilitarCamposPesquisa();
            pesquisaPorNomeUsuarios(txtNome.Text);

        }
        public void habilitarCamposPesquisa()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtRedefineSenha.Enabled = true;


            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;

            txtNome.Focus();
        }

        public void pesquisaPorNomeUsuarios(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where nomeUsu = '" + nome + "';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            txtSenha.Text = DR.GetString(2);

            Conexao.fecharConexao();

        }
        public void pesquisaPorCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codUsu+1 from tbusuarios order by codUsu desc;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();         

            Conexao.fecharConexao();

        }
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtRedefineSenha.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }


        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            pesquisaPorCodigo();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();
            txtNome.Focus();
        }
        public void habilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtRedefineSenha.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
        }
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtRedefineSenha.Clear();
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtSenha.Text.Equals("") || txtRedefineSenha.Text.Equals(""))
            {
                MessageBox.Show("Não é permitido campo vazio", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
                txtNome.Focus();
            }
            else
            {

                string nomeUsu = txtNome.Text;

                if (validaUsuario(nomeUsu))
                {
                    MessageBox.Show("Nome de usuário já existe.", "Mensagem do Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else

                if (txtSenha.Text.Equals(txtRedefineSenha.Text))
                {
                    int codUsu = Convert.ToInt32(txtCodigo.Text);
                    cadastrarUsuarios(codUsu);
                    limparCampos();
                    desabilitarCampos();
                    btnNovo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Senha não confere", "Mensagem do Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limparCamposSenha();

                }
            }
        }

        public void limparCamposSenha()
        {
            txtSenha.Clear();
            txtRedefineSenha.Clear();
            txtSenha.Focus();
        }


        public void cadastrarUsuarios(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbusuarios(nomeUsu, senhaUsu, codfunc)values(@nomeUsu,@senhaUsu,@codFunc);";

            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeUsu", MySqlDbType.VarChar, 30).Value = txtNome.Text;
            comm.Parameters.Add("@senhaUsu", MySqlDbType.VarChar, 20).Value = txtSenha.Text;
            comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 20).Value = codFunc;



            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso!!!");

            Conexao.fecharConexao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarUsuarios(Convert.ToInt32(txtCodigo.Text));
            desabilitarCampos();
            limparCampos();
        }
        public void alterarUsuarios(int codUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbUsuarios set nomeUsu = @nomeUsu ,senhaUsu = @senhaUsu where codUsu = " + codUsu + ";";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeUsu", MySqlDbType.VarChar, 30).Value = txtNome.Text;
            comm.Parameters.Add("@senhaUsu", MySqlDbType.VarChar, 20).Value = txtSenha.Text;

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();
            MessageBox.Show("Registro alterado com sucesso.");

            Conexao.fecharConexao();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuarios abrir = new frmPesquisaUsuarios();
            abrir.ShowDialog();
            this.Hide();
        }

        public bool validaUsuario(string nomeUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbusuarios where nomeUsu = @nomeUsu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nomeUsu", MySqlDbType.VarChar, 20).Value = nomeUsu;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            bool resultado = DR.HasRows;

            return resultado;

            Conexao.fecharConexao();

        }
    }
}
