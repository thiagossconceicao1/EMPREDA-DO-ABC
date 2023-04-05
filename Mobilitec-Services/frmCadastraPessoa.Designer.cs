
namespace Mobilitec_Services
{
    partial class frmCadastraPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastraPessoa));
            this.gpbCadPessoa = new System.Windows.Forms.GroupBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvDadosPessoais = new System.Windows.Forms.DataGridView();
            this.pnlCadastraPessoa = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.gpbCadPessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosPessoais)).BeginInit();
            this.pnlCadastraPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCadPessoa
            // 
            this.gpbCadPessoa.Controls.Add(this.mskCPF);
            this.gpbCadPessoa.Controls.Add(this.lblCPF);
            this.gpbCadPessoa.Controls.Add(this.mskTelefone);
            this.gpbCadPessoa.Controls.Add(this.lblTelefone);
            this.gpbCadPessoa.Controls.Add(this.txtEmail);
            this.gpbCadPessoa.Controls.Add(this.lblEmail);
            this.gpbCadPessoa.Controls.Add(this.txtNome);
            this.gpbCadPessoa.Controls.Add(this.lblNome);
            this.gpbCadPessoa.Controls.Add(this.txtCodigo);
            this.gpbCadPessoa.Controls.Add(this.lblCodigo);
            this.gpbCadPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadPessoa.Location = new System.Drawing.Point(37, 31);
            this.gpbCadPessoa.Name = "gpbCadPessoa";
            this.gpbCadPessoa.Size = new System.Drawing.Size(713, 211);
            this.gpbCadPessoa.TabIndex = 0;
            this.gpbCadPessoa.TabStop = false;
            this.gpbCadPessoa.Text = "Dados Pessoais";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(345, 136);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(121, 26);
            this.mskCPF.TabIndex = 4;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(345, 113);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(485, 136);
            this.mskTelefone.Mask = "(00) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(121, 26);
            this.mskTelefone.TabIndex = 5;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(485, 113);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(72, 113);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(208, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(402, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(208, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(72, 54);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(72, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // dgvDadosPessoais
            // 
            this.dgvDadosPessoais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDadosPessoais.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDadosPessoais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosPessoais.Location = new System.Drawing.Point(37, 248);
            this.dgvDadosPessoais.Name = "dgvDadosPessoais";
            this.dgvDadosPessoais.ReadOnly = true;
            this.dgvDadosPessoais.Size = new System.Drawing.Size(713, 230);
            this.dgvDadosPessoais.TabIndex = 6;
            // 
            // pnlCadastraPessoa
            // 
            this.pnlCadastraPessoa.Controls.Add(this.btnLimpar);
            this.pnlCadastraPessoa.Controls.Add(this.btnExcluir);
            this.pnlCadastraPessoa.Controls.Add(this.btnAdicionar);
            this.pnlCadastraPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCadastraPessoa.Location = new System.Drawing.Point(37, 494);
            this.pnlCadastraPessoa.Name = "pnlCadastraPessoa";
            this.pnlCadastraPessoa.Size = new System.Drawing.Size(713, 56);
            this.pnlCadastraPessoa.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(414, 10);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 39);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(274, 10);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(134, 39);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(134, 10);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(134, 39);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmCadastraPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlCadastraPessoa);
            this.Controls.Add(this.dgvDadosPessoais);
            this.Controls.Add(this.gpbCadPessoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastraPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastra Pessoa";
            this.gpbCadPessoa.ResumeLayout(false);
            this.gpbCadPessoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosPessoais)).EndInit();
            this.pnlCadastraPessoa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadPessoa;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.DataGridView dgvDadosPessoais;
        private System.Windows.Forms.Panel pnlCadastraPessoa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
    }
}