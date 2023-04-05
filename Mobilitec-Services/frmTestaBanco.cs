using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importar a classe de conexão
using MySql.Data.MySqlClient;


namespace Mobilitec_Services
{
    public partial class frmTestaBanco : Form
    {
        public frmTestaBanco()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //MySqlConnection conn = new MySqlConnection();
            //conn.ConnectionString = "server=localhost;port=3306;database=dbmobiliteservice;uid=user_service;pwd=123456";

            //conn.Open();

            //MessageBox.Show("Banco de dados aberto.");

            //conn.Close();
            //MessageBox.Show("Banco de dados fechado.");

            Conexao.obterConexao();
            MessageBox.Show("Banco de dados aberto.");

            Conexao.fecharConexao();
            MessageBox.Show("Banco de dados fechado.");
        }

        private void frmTestaBanco_Load(object sender, EventArgs e)
        {

        }
    }
}
