
namespace Mobilitec_Services
{
    partial class frmComponentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.cbbEstados = new System.Windows.Forms.ComboBox();
            this.ckbLivro = new System.Windows.Forms.CheckBox();
            this.ltbPreferencias = new System.Windows.Forms.ListBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.ckbAcademia = new System.Windows.Forms.CheckBox();
            this.ckbCultura = new System.Windows.Forms.CheckBox();
            this.ckbEsportes = new System.Windows.Forms.CheckBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.lblEstados = new System.Windows.Forms.Label();
            this.lblPreferencias = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblComponentes = new System.Windows.Forms.Label();
            this.gpbSelecione = new System.Windows.Forms.GroupBox();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbSelecione.SuspendLayout();
            this.gpbSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbEstados
            // 
            this.cbbEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstados.FormattingEnabled = true;
            this.cbbEstados.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Belo Horizonte",
            "Paraná"});
            this.cbbEstados.Location = new System.Drawing.Point(58, 105);
            this.cbbEstados.Name = "cbbEstados";
            this.cbbEstados.Size = new System.Drawing.Size(197, 28);
            this.cbbEstados.TabIndex = 0;
            this.cbbEstados.SelectedIndexChanged += new System.EventHandler(this.cbbEstados_SelectedIndexChanged);
            // 
            // ckbLivro
            // 
            this.ckbLivro.AutoSize = true;
            this.ckbLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLivro.Location = new System.Drawing.Point(25, 31);
            this.ckbLivro.Name = "ckbLivro";
            this.ckbLivro.Size = new System.Drawing.Size(61, 24);
            this.ckbLivro.TabIndex = 1;
            this.ckbLivro.Text = "Livro";
            this.ckbLivro.UseVisualStyleBackColor = true;
            // 
            // ltbPreferencias
            // 
            this.ltbPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPreferencias.FormattingEnabled = true;
            this.ltbPreferencias.ItemHeight = 20;
            this.ltbPreferencias.Items.AddRange(new object[] {
            "Amarelo",
            "Vermelho",
            "Azul",
            "Cinza",
            "Preto"});
            this.ltbPreferencias.Location = new System.Drawing.Point(376, 105);
            this.ltbPreferencias.Name = "ltbPreferencias";
            this.ltbPreferencias.Size = new System.Drawing.Size(165, 144);
            this.ltbPreferencias.TabIndex = 7;
            this.ltbPreferencias.SelectedIndexChanged += new System.EventHandler(this.ltbPreferencias_SelectedIndexChanged);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.Location = new System.Drawing.Point(28, 33);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rdbMasculino.TabIndex = 5;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // ckbAcademia
            // 
            this.ckbAcademia.AutoSize = true;
            this.ckbAcademia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAcademia.Location = new System.Drawing.Point(25, 56);
            this.ckbAcademia.Name = "ckbAcademia";
            this.ckbAcademia.Size = new System.Drawing.Size(99, 24);
            this.ckbAcademia.TabIndex = 2;
            this.ckbAcademia.Text = "Academia";
            this.ckbAcademia.UseVisualStyleBackColor = true;
            // 
            // ckbCultura
            // 
            this.ckbCultura.AutoSize = true;
            this.ckbCultura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCultura.Location = new System.Drawing.Point(25, 86);
            this.ckbCultura.Name = "ckbCultura";
            this.ckbCultura.Size = new System.Drawing.Size(79, 24);
            this.ckbCultura.TabIndex = 3;
            this.ckbCultura.Text = "Cultura";
            this.ckbCultura.UseVisualStyleBackColor = true;
            // 
            // ckbEsportes
            // 
            this.ckbEsportes.AutoSize = true;
            this.ckbEsportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEsportes.Location = new System.Drawing.Point(25, 116);
            this.ckbEsportes.Name = "ckbEsportes";
            this.ckbEsportes.Size = new System.Drawing.Size(92, 24);
            this.ckbEsportes.TabIndex = 4;
            this.ckbEsportes.Text = "Esportes";
            this.ckbEsportes.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFeminino.Location = new System.Drawing.Point(28, 63);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(92, 24);
            this.rdbFeminino.TabIndex = 6;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(58, 82);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(68, 20);
            this.lblEstados.TabIndex = 8;
            this.lblEstados.Text = "Estados";
            // 
            // lblPreferencias
            // 
            this.lblPreferencias.AutoSize = true;
            this.lblPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferencias.Location = new System.Drawing.Point(372, 82);
            this.lblPreferencias.Name = "lblPreferencias";
            this.lblPreferencias.Size = new System.Drawing.Size(98, 20);
            this.lblPreferencias.TabIndex = 10;
            this.lblPreferencias.Text = "Preferências";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(376, 269);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(165, 49);
            this.btnSelecionar.TabIndex = 8;
            this.btnSelecionar.Text = "&Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(376, 330);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(165, 49);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(376, 391);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(165, 49);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblComponentes
            // 
            this.lblComponentes.AutoSize = true;
            this.lblComponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentes.Location = new System.Drawing.Point(201, 9);
            this.lblComponentes.Name = "lblComponentes";
            this.lblComponentes.Size = new System.Drawing.Size(156, 25);
            this.lblComponentes.TabIndex = 14;
            this.lblComponentes.Text = "Componentes";
            // 
            // gpbSelecione
            // 
            this.gpbSelecione.Controls.Add(this.ckbAcademia);
            this.gpbSelecione.Controls.Add(this.ckbLivro);
            this.gpbSelecione.Controls.Add(this.ckbCultura);
            this.gpbSelecione.Controls.Add(this.ckbEsportes);
            this.gpbSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSelecione.Location = new System.Drawing.Point(58, 169);
            this.gpbSelecione.Name = "gpbSelecione";
            this.gpbSelecione.Size = new System.Drawing.Size(208, 149);
            this.gpbSelecione.TabIndex = 1;
            this.gpbSelecione.TabStop = false;
            this.gpbSelecione.Text = "Selecione";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbMasculino);
            this.gpbSexo.Controls.Add(this.rdbFeminino);
            this.gpbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSexo.Location = new System.Drawing.Point(62, 340);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(200, 100);
            this.gpbSexo.TabIndex = 15;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(35, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 31);
            this.textBox1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(597, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 262);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(41, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 54);
            this.label1.TabIndex = 19;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.gpbSelecione);
            this.Controls.Add(this.lblComponentes);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lblPreferencias);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.ltbPreferencias);
            this.Controls.Add(this.cbbEstados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.gpbSelecione.ResumeLayout(false);
            this.gpbSelecione.PerformLayout();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstados;
        private System.Windows.Forms.CheckBox ckbLivro;
        private System.Windows.Forms.ListBox ltbPreferencias;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.CheckBox ckbAcademia;
        private System.Windows.Forms.CheckBox ckbCultura;
        private System.Windows.Forms.CheckBox ckbEsportes;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.Label lblPreferencias;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblComponentes;
        private System.Windows.Forms.GroupBox gpbSelecione;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}