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
            this.chkMulher = new System.Windows.Forms.CheckBox();
            this.chkHomem = new System.Windows.Forms.CheckBox();
            this.lblInformaçao2 = new System.Windows.Forms.Label();
            this.chkCriança = new System.Windows.Forms.CheckBox();
            this.chkAdulto = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.chkMulher);
            this.panel1.Controls.Add(this.chkHomem);
            this.panel1.Controls.Add(this.lblInformaçao2);
            this.panel1.Controls.Add(this.chkCriança);
            this.panel1.Controls.Add(this.chkAdulto);
            this.panel1.Controls.Add(this.lblInformaçao);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 1;
            // 
            // chkMulher
            // 
            this.chkMulher.AutoSize = true;
            this.chkMulher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMulher.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkMulher.Location = new System.Drawing.Point(483, 66);
            this.chkMulher.Name = "chkMulher";
            this.chkMulher.Size = new System.Drawing.Size(82, 24);
            this.chkMulher.TabIndex = 5;
            this.chkMulher.Text = "Mulher";
            this.chkMulher.UseVisualStyleBackColor = true;
            // 
            // chkHomem
            // 
            this.chkHomem.AutoSize = true;
            this.chkHomem.Checked = true;
            this.chkHomem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHomem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHomem.ForeColor = System.Drawing.Color.Orange;
            this.chkHomem.Location = new System.Drawing.Point(359, 66);
            this.chkHomem.Name = "chkHomem";
            this.chkHomem.Size = new System.Drawing.Size(89, 24);
            this.chkHomem.TabIndex = 4;
            this.chkHomem.Text = "Homem";
            this.chkHomem.UseVisualStyleBackColor = true;
            // 
            // lblInformaçao2
            // 
            this.lblInformaçao2.AutoSize = true;
            this.lblInformaçao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformaçao2.Location = new System.Drawing.Point(355, 23);
            this.lblInformaçao2.Name = "lblInformaçao2";
            this.lblInformaçao2.Size = new System.Drawing.Size(64, 24);
            this.lblInformaçao2.TabIndex = 3;
            this.lblInformaçao2.Text = "Sexo:";
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
            this.chkCriança.CheckedChanged += new System.EventHandler(this.chkCriança_CheckedChanged);
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
            this.chkAdulto.CheckedChanged += new System.EventHandler(this.chkAdulto_CheckedChanged);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInformaçao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAdulto;
        private System.Windows.Forms.Label lblInformaçao2;
        private System.Windows.Forms.CheckBox chkCriança;
        private System.Windows.Forms.CheckBox chkMulher;
        private System.Windows.Forms.CheckBox chkHomem;
    }
}