namespace MultApps.Windows
{
    partial class CalculoDeAposentaria
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
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.txtTempoContribuicao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblInformacao1 = new System.Windows.Forms.Label();
            this.lblInformacao2 = new System.Windows.Forms.Label();
            this.lblInformacao3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(76, 76);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtNascimento.TabIndex = 0;
            // 
            // txtTempoContribuicao
            // 
            this.txtTempoContribuicao.Location = new System.Drawing.Point(284, 75);
            this.txtTempoContribuicao.Name = "txtTempoContribuicao";
            this.txtTempoContribuicao.Size = new System.Drawing.Size(100, 20);
            this.txtTempoContribuicao.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 136);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 34);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(209, 157);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(70, 15);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Text = "Mensagem";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Homem",
            "Mulher"});
            this.cmbSexo.Location = new System.Drawing.Point(446, 74);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 6;
            // 
            // lblInformacao1
            // 
            this.lblInformacao1.AutoSize = true;
            this.lblInformacao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao1.Location = new System.Drawing.Point(12, 39);
            this.lblInformacao1.Name = "lblInformacao1";
            this.lblInformacao1.Size = new System.Drawing.Size(227, 15);
            this.lblInformacao1.TabIndex = 7;
            this.lblInformacao1.Text = "Informe a sua data de Nascimento";
            // 
            // lblInformacao2
            // 
            this.lblInformacao2.AutoSize = true;
            this.lblInformacao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao2.Location = new System.Drawing.Point(272, 39);
            this.lblInformacao2.Name = "lblInformacao2";
            this.lblInformacao2.Size = new System.Drawing.Size(156, 15);
            this.lblInformacao2.TabIndex = 8;
            this.lblInformacao2.Text = "Tempo de Contribuição";
            // 
            // lblInformacao3
            // 
            this.lblInformacao3.AutoSize = true;
            this.lblInformacao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao3.Location = new System.Drawing.Point(483, 39);
            this.lblInformacao3.Name = "lblInformacao3";
            this.lblInformacao3.Size = new System.Drawing.Size(39, 15);
            this.lblInformacao3.TabIndex = 9;
            this.lblInformacao3.Text = "Sexo";
            // 
            // CalculoDeAposentaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInformacao3);
            this.Controls.Add(this.lblInformacao2);
            this.Controls.Add(this.lblInformacao1);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTempoContribuicao);
            this.Controls.Add(this.txtNascimento);
            this.Name = "CalculoDeAposentaria";
            this.Text = "CalculoDeAposentaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.TextBox txtTempoContribuicao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblInformacao1;
        private System.Windows.Forms.Label lblInformacao2;
        private System.Windows.Forms.Label lblInformacao3;
    }
}