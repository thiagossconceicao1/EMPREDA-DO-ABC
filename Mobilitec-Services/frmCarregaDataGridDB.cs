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
    public partial class frmCarregaDataGridDB : Form
    {
        public frmCarregaDataGridDB()
        {
            InitializeComponent();
        }

        private void btnCarregaDados_Click(object sender, EventArgs e)
        {
            

            dgvFuncionarios.DataSource = null;
            
            MySqlDataAdapter da = new MySqlDataAdapter("select codfunc as 'Código',nome as 'Nome',email as 'E-mail', cpf as 'CPF', telefone as 'Telefone', sexo as 'Sexo',  endereco as 'Endereço', numero as 'Número', cep as 'CEP', bairro as 'Bairro', cidade as 'Cidade', estado as 'Estado' from tbfuncionarios;", Conexao.obterConexao());

            DataTable dt = new DataTable();
            
            da.Fill(dt);

            dgvFuncionarios.DataSource = dt;

            Conexao.fecharConexao();

        }
    }
}
