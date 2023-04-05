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
    public partial class frmEstruturaRepeticao : Form
    {
        public frmEstruturaRepeticao()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txtContador.Clear();
            txtSoma.Clear();
            txtValor.Clear();
            txtRepeticoes.Clear();
            ltbSomatoria.Items.Clear();
            txtContador.Focus();
            cbbSomatoria.Items.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int contador, repeticoes;
            double soma, valor;

            contador = Convert.ToInt32(txtContador.Text);

            repeticoes = Convert.ToInt32(txtRepeticoes.Text);

            soma = Convert.ToDouble(txtSoma.Text);

            valor = Convert.ToDouble(txtValor.Text);

            ltbSomatoria.Items.Clear();
            cbbSomatoria.Items.Clear();

            while (contador <= repeticoes)
            {
                contador++;
                soma = soma + valor;
                ltbSomatoria.Items.Add("A soma: " + soma + " reais " + contador);
                cbbSomatoria.Items.Add(soma);
            }


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisando...");
        }
    }
}
