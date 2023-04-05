using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobilitec_Services
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //declarando uma variável
            double num1,num2,resp;
            int valor;
            char sexo;
            string nome;
            bool acesso;

            //Inicializar as variáveis ou atribuindo valor
            valor = 5;
            sexo = 'F';
            nome = "Senac Largo Treze";
            acesso = true;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 + num2;

            lblResposta.Text = resp.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Clear();
            lblResposta.Text = "";
            txtNum1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja sair do sistema?",
                "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            Close();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            double num1, num2, resp;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 - num2;

            lblResposta.Text = resp.ToString();

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double num1, num2, resp;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 * num2;

            lblResposta.Text = resp.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1, num2, resp;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = num1 / num2;

            lblResposta.Text = resp.ToString();
        }
    }
}
