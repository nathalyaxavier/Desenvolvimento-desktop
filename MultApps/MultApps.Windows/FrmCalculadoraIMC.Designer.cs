namespace MultApps.Windows
{
    partial class FrmCalculadoraIMC
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
            this.lblInformaçao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAdulto = new System.Windows.Forms.Panel();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.cmbIdade = new System.Windows.Forms.ComboBox();
            this.lblIdade2 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.chkFeminino = new System.Windows.Forms.CheckBox();
            this.chkMasculino = new System.Windows.Forms.CheckBox();
            this.lblISexo = new System.Windows.Forms.Label();
            this.chkCriança = new System.Windows.Forms.CheckBox();
            this.chkAdulto = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelAdulto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInformaçao
            // 
            this.lblInformaçao.AutoSize = true;
            this.lblInformaçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformaçao.Location = new System.Drawing.Point(42, 23);
            this.lblInformaçao.Name = "lblInformaçao";
            this.lblInformaçao.Size = new System.Drawing.Size(107, 24);
            this.lblInformaçao.TabIndex = 0;
            this.lblInformaçao.Text = "selecione:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.panelAdulto);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.chkFeminino);
            this.panel1.Controls.Add(this.chkMasculino);
            this.panel1.Controls.Add(this.lblISexo);
            this.panel1.Controls.Add(this.chkCriança);
            this.panel1.Controls.Add(this.chkAdulto);
            this.panel1.Controls.Add(this.lblInformaçao);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 1;
            // 
            // panelAdulto
            // 
            this.panelAdulto.Controls.Add(this.txtAltura);
            this.panelAdulto.Controls.Add(this.txtPeso);
            this.panelAdulto.Controls.Add(this.cmbIdade);
            this.panelAdulto.Controls.Add(this.lblIdade2);
            this.panelAdulto.Controls.Add(this.lblAltura);
            this.panelAdulto.Controls.Add(this.lblPeso);
            this.panelAdulto.Location = new System.Drawing.Point(3, 143);
            this.panelAdulto.Name = "panelAdulto";
            this.panelAdulto.Size = new System.Drawing.Size(757, 84);
            this.panelAdulto.TabIndex = 7;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(116, 43);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(84, 20);
            this.txtAltura.TabIndex = 8;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(3, 43);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(83, 20);
            this.txtPeso.TabIndex = 7;
            // 
            // cmbIdade
            // 
            this.cmbIdade.FormattingEnabled = true;
            this.cmbIdade.Items.AddRange(new object[] {
            "1 ano",
            "2 ano",
            "3 ano",
            "4 ano",
            "5 ano",
            "6 ano",
            "7 ano",
            "8 ano",
            "9 ano",
            "10 ano",
            "11 ano",
            "12 ano",
            "13 ano",
            "14 ano",
            "15 ano",
            "16 ano",
            "17 ano",
            "18 ano"});
            this.cmbIdade.Location = new System.Drawing.Point(235, 43);
            this.cmbIdade.Name = "cmbIdade";
            this.cmbIdade.Size = new System.Drawing.Size(121, 21);
            this.cmbIdade.TabIndex = 6;
            // 
            // lblIdade2
            // 
            this.lblIdade2.AutoSize = true;
            this.lblIdade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade2.Location = new System.Drawing.Point(253, 17);
            this.lblIdade2.Name = "lblIdade2";
            this.lblIdade2.Size = new System.Drawing.Size(43, 18);
            this.lblIdade2.TabIndex = 5;
            this.lblIdade2.Text = "Idade";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(134, 17);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(45, 18);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(22, 15);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(45, 20);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.Black;
            this.lblIdade.Location = new System.Drawing.Point(25, 103);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(140, 20);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "Acima de 19 anos.";
            // 
            // chkFeminino
            // 
            this.chkFeminino.AutoSize = true;
            this.chkFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFeminino.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkFeminino.Location = new System.Drawing.Point(483, 66);
            this.chkFeminino.Name = "chkFeminino";
            this.chkFeminino.Size = new System.Drawing.Size(101, 24);
            this.chkFeminino.TabIndex = 5;
            this.chkFeminino.Text = "Feminino";
            this.chkFeminino.UseVisualStyleBackColor = true;
            this.chkFeminino.Click += new System.EventHandler(this.chkFeminino_CheckendChanged);
            // 
            // chkMasculino
            // 
            this.chkMasculino.AutoSize = true;
            this.chkMasculino.Checked = true;
            this.chkMasculino.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMasculino.ForeColor = System.Drawing.Color.Orange;
            this.chkMasculino.Location = new System.Drawing.Point(359, 66);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.Size = new System.Drawing.Size(108, 24);
            this.chkMasculino.TabIndex = 4;
            this.chkMasculino.Text = "Masculino";
            this.chkMasculino.UseVisualStyleBackColor = true;
            this.chkMasculino.Click += new System.EventHandler(this.chkMasculino_CheckendChanged);
            // 
            // lblISexo
            // 
            this.lblISexo.AutoSize = true;
            this.lblISexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISexo.Location = new System.Drawing.Point(355, 23);
            this.lblISexo.Name = "lblISexo";
            this.lblISexo.Size = new System.Drawing.Size(64, 24);
            this.lblISexo.TabIndex = 3;
            this.lblISexo.Text = "Sexo:";
            // 
            // chkCriança
            // 
            this.chkCriança.AutoSize = true;
            this.chkCriança.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCriança.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkCriança.Location = new System.Drawing.Point(163, 66);
            this.chkCriança.Name = "chkCriança";
            this.chkCriança.Size = new System.Drawing.Size(89, 24);
            this.chkCriança.TabIndex = 2;
            this.chkCriança.Text = "Criança";
            this.chkCriança.UseVisualStyleBackColor = true;
            this.chkCriança.Click += new System.EventHandler(this.chkCriança_CheckedChanged);
            // 
            // chkAdulto
            // 
            this.chkAdulto.AutoSize = true;
            this.chkAdulto.Checked = true;
            this.chkAdulto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdulto.ForeColor = System.Drawing.Color.Orange;
            this.chkAdulto.Location = new System.Drawing.Point(46, 66);
            this.chkAdulto.Name = "chkAdulto";
            this.chkAdulto.Size = new System.Drawing.Size(80, 24);
            this.chkAdulto.TabIndex = 1;
            this.chkAdulto.Text = "Adulto";
            this.chkAdulto.UseVisualStyleBackColor = true;
            this.chkAdulto.Click += new System.EventHandler(this.chkAdulto_CheckendChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Red;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(6, 243);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(127, 44);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(150, 255);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(75, 18);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado";
            // 
            // FrmCalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCalculadoraIMC";
            this.Text = "FrmCalculadoraIMC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAdulto.ResumeLayout(false);
            this.panelAdulto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInformaçao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAdulto;
        private System.Windows.Forms.Label lblISexo;
        private System.Windows.Forms.CheckBox chkCriança;
        private System.Windows.Forms.CheckBox chkFeminino;
        private System.Windows.Forms.CheckBox chkMasculino;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Panel panelAdulto;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblIdade2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.ComboBox cmbIdade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}