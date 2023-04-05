using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mobilitec_Services
{
    public partial class frmPesquisaUsuarios : Form
    {
        public frmPesquisaUsuarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmUsuarios abrir = new frmUsuarios();
            abrir.Show();
            this.Hide();
        }

        private void ltbResultadoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resp = ltbResultadoPesquisa.SelectedItem.ToString();

            frmUsuarios abrir = new frmUsuarios(resp);
            abrir.Show();
            this.Hide();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();

        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked && txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores para pesquisa",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                txtDescricao.Focus();

            }
            else if (rdbNome.Checked && txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores para pesquisa",
                     "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
                txtDescricao.Focus();

            }
            else
            {
                if (rdbCodigo.Checked)
                {
                    pesquisaPorCodigo(Convert.ToInt32(txtDescricao.Text));
                }
                if (rdbNome.Checked)
                {
                    pesquisaPorNome(txtDescricao.Text);
                }
            }
        }
        public void pesquisaPorCodigo(int codigoUsuario)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where codUsu = " + codigoUsuario + ";";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            ltbResultadoPesquisa.Items.Clear();
            ltbResultadoPesquisa.Items.Add(DR.GetString(1));

            Conexao.fecharConexao();
        }

        public void pesquisaPorNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where nomeUsu like '%" + nome + "%';";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            ltbResultadoPesquisa.Items.Clear();

            while (DR.Read())
            {
                ltbResultadoPesquisa.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();
        }
    }
}
