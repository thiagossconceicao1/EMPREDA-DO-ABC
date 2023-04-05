
namespace Mobilitec_Services
{
    partial class frmEstruturaRepeticao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstruturaRepeticao));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lblSomatoria = new System.Windows.Forms.Label();
            this.ltbSomatoria = new System.Windows.Forms.ListBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblSoma = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtRepeticoes = new System.Windows.Forms.TextBox();
            this.lblRepeticoes = new System.Windows.Forms.Label();
            this.cbbSomatoria = new System.Windows.Forms.ComboBox();
            this.lblCbbSomatoria = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(169, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(254, 25);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Estrutura de Repetição";
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(436, 400);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(165, 64);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(236, 400);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(165, 64);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Image = ((System.Drawing.Image)(resources.GetObject("btnExecutar.Image")));
            this.btnExecutar.Location = new System.Drawing.Point(47, 400);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(165, 64);
            this.btnExecutar.TabIndex = 6;
            this.btnExecutar.Text = "&Executar";
            this.btnExecutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lblSomatoria
            // 
            this.lblSomatoria.AutoSize = true;
            this.lblSomatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomatoria.Location = new System.Drawing.Point(195, 89);
            this.lblSomatoria.Name = "lblSomatoria";
            this.lblSomatoria.Size = new System.Drawing.Size(82, 20);
            this.lblSomatoria.TabIndex = 19;
            this.lblSomatoria.Text = "Somatória";
            // 
            // ltbSomatoria
            // 
            this.ltbSomatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbSomatoria.FormattingEnabled = true;
            this.ltbSomatoria.ItemHeight = 20;
            this.ltbSomatoria.Location = new System.Drawing.Point(195, 112);
            this.ltbSomatoria.Name = "ltbSomatoria";
            this.ltbSomatoria.Size = new System.Drawing.Size(228, 224);
            this.ltbSomatoria.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(47, 310);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 26);
            this.txtValor.TabIndex = 3;
            // 
            // txtSoma
            // 
            this.txtSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoma.Location = new System.Drawing.Point(47, 247);
            this.txtSoma.MaxLength = 10;
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.Size = new System.Drawing.Size(100, 26);
            this.txtSoma.TabIndex = 2;
            // 
            // txtContador
            // 
            this.txtContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContador.Location = new System.Drawing.Point(47, 114);
            this.txtContador.MaxLength = 10;
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(100, 26);
            this.txtContador.TabIndex = 0;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(47, 286);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 14;
            this.lblValor.Text = "Valor";
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoma.Location = new System.Drawing.Point(47, 224);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(51, 20);
            this.lblSoma.TabIndex = 13;
            this.lblSoma.Text = "Soma";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(47, 90);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(75, 20);
            this.lblContador.TabIndex = 12;
            this.lblContador.Text = "Contador";
            // 
            // txtRepeticoes
            // 
            this.txtRepeticoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeticoes.Location = new System.Drawing.Point(47, 181);
            this.txtRepeticoes.MaxLength = 10;
            this.txtRepeticoes.Name = "txtRepeticoes";
            this.txtRepeticoes.Size = new System.Drawing.Size(100, 26);
            this.txtRepeticoes.TabIndex = 1;
            // 
            // lblRepeticoes
            // 
            this.lblRepeticoes.AutoSize = true;
            this.lblRepeticoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeticoes.Location = new System.Drawing.Point(47, 157);
            this.lblRepeticoes.Name = "lblRepeticoes";
            this.lblRepeticoes.Size = new System.Drawing.Size(90, 20);
            this.lblRepeticoes.TabIndex = 25;
            this.lblRepeticoes.Text = "Repetições";
            // 
            // cbbSomatoria
            // 
            this.cbbSomatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSomatoria.FormattingEnabled = true;
            this.cbbSomatoria.Location = new System.Drawing.Point(457, 112);
            this.cbbSomatoria.Name = "cbbSomatoria";
            this.cbbSomatoria.Size = new System.Drawing.Size(144, 28);
            this.cbbSomatoria.TabIndex = 5;
            // 
            // lblCbbSomatoria
            // 
            this.lblCbbSomatoria.AutoSize = true;
            this.lblCbbSomatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCbbSomatoria.Location = new System.Drawing.Point(457, 89);
            this.lblCbbSomatoria.Name = "lblCbbSomatoria";
            this.lblCbbSomatoria.Size = new System.Drawing.Size(82, 20);
            this.lblCbbSomatoria.TabIndex = 27;
            this.lblCbbSomatoria.Text = "Somatória";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(457, 222);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(144, 114);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "&Buscar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmEstruturaRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 492);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblCbbSomatoria);
            this.Controls.Add(this.cbbSomatoria);
            this.Controls.Add(this.txtRepeticoes);
            this.Controls.Add(this.lblRepeticoes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lblSomatoria);
            this.Controls.Add(this.ltbSomatoria);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.lblContador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEstruturaRepeticao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estrutura de Repetição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label lblSomatoria;
        private System.Windows.Forms.ListBox ltbSomatoria;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtRepeticoes;
        private System.Windows.Forms.Label lblRepeticoes;
        private System.Windows.Forms.ComboBox cbbSomatoria;
        private System.Windows.Forms.Label lblCbbSomatoria;
        private System.Windows.Forms.Button btnPesquisar;
    }
}