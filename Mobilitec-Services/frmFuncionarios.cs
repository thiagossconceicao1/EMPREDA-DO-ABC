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
    public partial class frmFuncionarios : Form
    {

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
            escolhaSexo();
        }

        public frmFuncionarios(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            txtNome.Text = nome;
            habilitarCamposPesquisa();
            pesquisaPorNomeFuncionarios(txtNome.Text);

        }
        public void habilitarCamposPesquisa()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cbbEstado.Enabled = true;
            cbbSexo.Enabled = true;
            mkbCEP.Enabled = true;
            mkbCPF.Enabled = true;
            mkbTelefone.Enabled = true;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;

            txtNome.Focus();
        }
        public void pesquisaPorNomeFuncionarios(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where nome = '" + nome + "';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mkbCPF.Text = DR.GetString(3);
            mkbTelefone.Text = DR.GetString(4);
            cbbSexo.Text = DR.GetString(5);
            txtEndereco.Text = DR.GetString(6);
            txtNumero.Text = DR.GetString(7);
            mkbCEP.Text = DR.GetString(8);
            txtBairro.Text = DR.GetString(9);
            txtCidade.Text = DR.GetString(10);
            cbbEstado.Text = DR.GetString(11);

            Conexao.fecharConexao();

        }

        public void escolhaSexo()
        {
            cbbSexo.Items.Add("Masculino");
            cbbSexo.Items.Add("Feminino");

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbbEstado.Items.Clear();
            cbbEstado.Text = "";
            cbbSexo.Items.Clear();
            cbbSexo.Text = "";
            mkbCEP.Clear();
            mkbCPF.Clear();
            mkbTelefone.Clear();
            txtNome.Focus();
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
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cbbEstado.Enabled = true;
            cbbSexo.Enabled = true;
            mkbCEP.Enabled = true;
            mkbCPF.Enabled = true;
            mkbTelefone.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
        }

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cbbEstado.Enabled = false;
            cbbSexo.Enabled = false;
            mkbCEP.Enabled = false;
            mkbCPF.Enabled = false;
            mkbTelefone.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || txtEndereco.Text.Equals("")
               || txtNumero.Text.Equals("") || txtBairro.Text.Equals("") || txtCidade.Text.Equals("")
               || mkbCPF.Text.Equals("   .   .   -") || mkbTelefone.Text.Equals("(  )      -")
               || mkbCEP.Text.Equals("     -") || cbbEstado.Text.Equals("") || cbbSexo.Text.Equals(""))
            {
                MessageBox.Show("Não é permitido campo vazio", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else
            {
                cadastrarFuncionarios();
                limparCampos();
                desabilitarCampos();
                btnNovo.Enabled = true;

            }
        }
        public void cadastrarFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionarios (nome,email,cpf,telefone,sexo,endereco,numero,cep,bairro,cidade,estado)" +
                "values(@nome,@email,@cpf,@telefone,@sexo,@endereco,@numero,@cep,@bairro,@cidade,@estado);";

            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mkbCPF.Text;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = mkbTelefone.Text;
            comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = cbbSexo.Text;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mkbCEP.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso!!!");

            Conexao.fecharConexao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarFuncionarios(Convert.ToInt32(txtCodigo.Text));
            desabilitarCampos();
            limparCampos();
        }
        public void alterarFuncionarios(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbFuncionarios set nome = @nome ,email = @email,cpf = @cpf,telefone = @telefone, sexo = @sexo, endereco = @endereco, numero = @numero,cep = @cep, bairro = @bairro, cidade = @cidade, estado = @estado where codFunc = " + codFunc + ";";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mkbCPF.Text;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = mkbTelefone.Text;
            comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 10).Value = cbbSexo.Text;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mkbCEP.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();
            MessageBox.Show("Registro alterado com sucesso.");

            Conexao.fecharConexao();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja excluir?",
                "Mensagem do sistema", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                //Vai excluir

                excluirFuncionarios(Convert.ToInt32(txtCodigo.Text));

                MessageBox.Show("Excluido com sucesso",
                "Mensagem do sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                btnNovo.Enabled = true;

                limparCampos();
                desabilitarCampos();
            }
            else
            {
                txtNome.Focus();
            }
        }

        public void excluirFuncionarios(int codCli)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbFuncionarios where codFunc = @codFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32, 11).Value = codCli;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaFuncionarios abrir = new frmPesquisaFuncionarios();
            abrir.ShowDialog();
            this.Hide();
        }

        private void mkbCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscaCEP(mkbCEP.Text);
                txtNumero.Focus();
            }
        }
        public void buscaCEP(string numCEP)
        {
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();

            WSCorreios.enderecoERP endereco = ws.consultaCEP(numCEP);

            txtEndereco.Text = endereco.end;
            txtBairro.Text = endereco.bairro;
            txtCidade.Text = endereco.cidade;
            cbbEstado.Text = endereco.uf;

        }
    }
}
