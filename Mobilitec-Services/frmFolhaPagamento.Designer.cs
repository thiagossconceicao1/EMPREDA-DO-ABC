
namespace Mobilitec_Services
{
    partial class frmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagamento));
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblImpostoRenda = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.cbbClubeLazer = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.ckbPlanoSaude = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFolha.Location = new System.Drawing.Point(52, 96);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(105, 20);
            this.lblDataFolha.TabIndex = 0;
            this.lblDataFolha.Text = "Data da folha";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(52, 186);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 20);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário";
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeLazer.Location = new System.Drawing.Point(52, 336);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(110, 20);
            this.lblClubeLazer.TabIndex = 2;
            this.lblClubeLazer.Text = "Clube de lazer";
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFolha.Location = new System.Drawing.Point(315, 96);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(97, 20);
            this.lblSalarioFolha.TabIndex = 3;
            this.lblSalarioFolha.Text = "Salário folha";
            // 
            // lblImpostoRenda
            // 
            this.lblImpostoRenda.AutoSize = true;
            this.lblImpostoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostoRenda.Location = new System.Drawing.Point(315, 186);
            this.lblImpostoRenda.Name = "lblImpostoRenda";
            this.lblImpostoRenda.Size = new System.Drawing.Size(134, 20);
            this.lblImpostoRenda.TabIndex = 4;
            this.lblImpostoRenda.Text = "Imposto de renda";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(315, 282);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(107, 20);
            this.lblSalarioLiquido.TabIndex = 5;
            this.lblSalarioLiquido.Text = "Salário liquído";
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(52, 119);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(134, 26);
            this.dtpDataFolha.TabIndex = 0;
            this.dtpDataFolha.TabStop = false;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(52, 209);
            this.txtSalario.MaxLength = 20;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(134, 26);
            this.txtSalario.TabIndex = 1;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Enabled = false;
            this.txtSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFolha.Location = new System.Drawing.Point(315, 119);
            this.txtSalarioFolha.MaxLength = 20;
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(134, 26);
            this.txtSalarioFolha.TabIndex = 4;
            this.txtSalarioFolha.TextChanged += new System.EventHandler(this.txtSalarioFolha_TextChanged);
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Enabled = false;
            this.txtImpostoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpostoRenda.Location = new System.Drawing.Point(315, 209);
            this.txtImpostoRenda.MaxLength = 20;
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(134, 26);
            this.txtImpostoRenda.TabIndex = 5;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioLiquido.Location = new System.Drawing.Point(315, 308);
            this.txtSalarioLiquido.MaxLength = 20;
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(134, 26);
            this.txtSalarioLiquido.TabIndex = 6;
            // 
            // cbbClubeLazer
            // 
            this.cbbClubeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbClubeLazer.FormattingEnabled = true;
            this.cbbClubeLazer.Items.AddRange(new object[] {
            "",
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbbClubeLazer.Location = new System.Drawing.Point(52, 361);
            this.cbbClubeLazer.Name = "cbbClubeLazer";
            this.cbbClubeLazer.Size = new System.Drawing.Size(134, 28);
            this.cbbClubeLazer.TabIndex = 3;
            this.cbbClubeLazer.SelectedIndexChanged += new System.EventHandler(this.cbbClubeLazer_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(608, 96);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 53);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(608, 186);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 53);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(608, 281);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 53);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ckbPlanoSaude
            // 
            this.ckbPlanoSaude.AutoSize = true;
            this.ckbPlanoSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPlanoSaude.Location = new System.Drawing.Point(52, 282);
            this.ckbPlanoSaude.Name = "ckbPlanoSaude";
            this.ckbPlanoSaude.Size = new System.Drawing.Size(138, 24);
            this.ckbPlanoSaude.TabIndex = 2;
            this.ckbPlanoSaude.Text = "Plano de saúde";
            this.ckbPlanoSaude.UseVisualStyleBackColor = true;
            this.ckbPlanoSaude.CheckedChanged += new System.EventHandler(this.ckbPlanoSaude_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Folha de Pagamento";
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 439);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ckbPlanoSaude);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbbClubeLazer);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtImpostoRenda);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.dtpDataFolha);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblImpostoRenda);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.lblClubeLazer);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataFolha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolhaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblImpostoRenda;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.ComboBox cbbClubeLazer;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox ckbPlanoSaude;
        private System.Windows.Forms.Label label7;
    }
}