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
    public partial class frmStringFormat : Form
    {
        public frmStringFormat()
        {
            InitializeComponent();
        }


        private void btnMensagem_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa();

            ps.andar();
            
                        
                double valor = Convert.ToDouble(txtValor.Text);

            txtResposta.Text = string.Format("{0:c}", valor);

        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMensagem.Focus();
            }
        }
    }
}
