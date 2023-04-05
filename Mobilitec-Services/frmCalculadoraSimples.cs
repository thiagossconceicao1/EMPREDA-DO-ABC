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
    public partial class frmCalculadoraSimples : Form
    {
        public frmCalculadoraSimples()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();

            rdbAdicao.Checked = false;
            rdbsubtracao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbDivisao.Checked = false;

            lblResposta.Text = "";

            txtNum1.Focus();

        }

        public double somaValor(double num1, double num2)
        {
            return (num1 + num2);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;

            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("Inserir valores nos campos", "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                num1 = Convert.ToDouble(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum2.Text);


                if (rdbAdicao.Checked)
                {
                    resultado = somaValor(num1,num2);
                }
                if (rdbsubtracao.Checked)
                {
                    resultado = num1 - num2;
                }
                if (rdbMultiplicacao.Checked)
                {
                    resultado = num1 * num2;
                }
                if (rdbDivisao.Checked)
                {
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("Não existe divisão por zero",
                            "Mensagem do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                    }
                }
                lblResposta.Text = resultado.ToString();
            }
        }
    }
}
