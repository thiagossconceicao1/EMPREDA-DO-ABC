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
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Close();
            //this.Close();
            Application.Exit();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked)
            {
                MessageBox.Show("Selecionou masculino");
            }
            if (rdbFeminino.Checked)
            {
                MessageBox.Show("Selecionou feminino");
            }

            if (ckbLivro.Checked)
            {
                MessageBox.Show("Selecionou Livro");
            }
            if (ckbAcademia.Checked)
            {
                MessageBox.Show("Selecionou Academia");
            }
            if (ckbCultura.Checked)
            {
                MessageBox.Show("Selecionou Cultura");
            }
            if (ckbEsportes.Checked)
            {
                MessageBox.Show("Selecionou Esportes");
            }
        }

        private void cbbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mostrando a posição selecionada
            //int valor = cbbEstados.SelectedIndex;

            //Mostrando o valor selecionado
            string valor = cbbEstados.SelectedItem.ToString();
            
            MessageBox.Show("Item selecionado "+valor);
        }

        private void ltbPreferencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mostrando a posição selecionada da lista
            //int valor = ltbPreferencias.SelectedIndex;

            //Mostrando o valor selecionado da lista
            string valor = ltbPreferencias.SelectedItem.ToString();

            MessageBox.Show("Item selecionado da lista "+valor);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbbEstados.Items.Clear();
            ltbPreferencias.Items.Clear();
            cbbEstados.Text = "";

            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;

            ckbAcademia.Checked = false;
            ckbCultura.Checked = false;
            ckbEsportes.Checked = false;
            ckbLivro.Checked = false;
        }
    }
}
