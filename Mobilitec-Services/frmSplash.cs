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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {

            if (pgbCarregando.Value < 100)
            {
                pgbCarregando.Value = pgbCarregando.Value + 10;
                lblPorcentagem.Text = pgbCarregando.Value.ToString() + "%";
                lblCarregando.Visible = true;
            }
            else
            {
                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();

                //desabilitando o timer
                tmrSplash.Enabled = false;
            }
            
        }
    }
}
