
namespace Mobilitec_Services
{
    partial class frmTabList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCadastrarClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastrarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCadastrarClientes
            // 
            this.dgvCadastrarClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvCadastrarClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCadastrarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastrarClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvCadastrarClientes.Location = new System.Drawing.Point(55, 84);
            this.dgvCadastrarClientes.Name = "dgvCadastrarClientes";
            this.dgvCadastrarClientes.Size = new System.Drawing.Size(733, 472);
            this.dgvCadastrarClientes.TabIndex = 0;
            // 
            // frmTabList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 600);
            this.Controls.Add(this.dgvCadastrarClientes);
            this.Name = "frmTabList";
            this.Text = "frmTabList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastrarClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCadastrarClientes;
    }
}