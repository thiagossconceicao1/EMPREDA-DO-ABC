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
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        //Limpando campos
        public void limparCampos()
        {
            txtSalario.Clear();
            txtImpostoRenda.Clear();
            txtSalarioFolha.Clear();
            txtSalarioLiquido.Clear();
            cbbClubeLazer.Text = "";
            ckbPlanoSaude.Checked = false;
            txtSalario.Focus();
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            txtSalarioFolha.Text = txtSalario.Text;
        }

        double salario = 0;

        private void ckbPlanoSaude_CheckedChanged(object sender, EventArgs e)
        {
            salario = Convert.ToDouble(txtSalarioFolha.Text);

            if (ckbPlanoSaude.Checked)
            {
                salario = salario - 50;
                txtSalarioFolha.Text = salario.ToString();
                ckbPlanoSaude.Enabled = false;

            }
        }

        private void cbbClubeLazer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbClubeLazer.Text)
            {
                case "Clube A":
                    salario = salario - 100;
                    break;

                case "Clube B":
                    salario = salario - 50;
                    break;
                case "Clube C":
                    salario = salario - 10;
                    break;

                default:
                    break;
            }
            txtSalarioFolha.Text = salario.ToString();
        }

        private void txtSalarioFolha_TextChanged(object sender, EventArgs e)
        {
            salario = Convert.ToDouble(txtSalarioFolha.Text);
            double vporcentagem = 0;

            if (salario >= 1903.99 && salario <= 2826.65)
            {
                vporcentagem = (salario * 7.5 / 100);

                salario = salario - vporcentagem;

            }
            if (salario >= 2826.665 && salario <= 3751.05)
            {
                vporcentagem = (salario * 15 / 100);

                salario = salario - vporcentagem;

            }
            if (salario >= 3751.06 && salario <= 4664.68)
            {
                vporcentagem = (salario * 22.5 / 100);

                salario = salario - vporcentagem;

            }
            if (salario >= 4664.68)
            {
                vporcentagem = (salario * 27.5 / 100);

                salario = salario - vporcentagem;

            }

            txtImpostoRenda.Text = vporcentagem.ToString();
            //txtSalarioLiquido.Text = salario.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtSalarioLiquido.Text = (Convert.ToDouble(txtSalarioFolha.Text) + Convert.ToDouble(txtImpostoRenda.Text)).ToString();
        }
    }
}
