using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void chkCriança_CheckedChanged(object sender, EventArgs e)
        {
            chkCriança.ForeColor = Color.DarkOrange;
            chkAdulto.ForeColor = Color.Gray;
            chkCriança.Checked = true;
            chkAdulto.Checked = false;
            lblIdade.Text = "Abaixo de 19 anos";

        }

        private void chkAdulto_CheckendChanged(object sender, EventArgs e)
        {
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCriança.ForeColor = Color.Gray;
            chkAdulto.Checked = true;
            chkCriança.Checked = false;
            lblIdade.Text = "Acima de 19 anos";
            cmbIdade.Visible = false;
            lblIdade2.Text = "";

        }

        private void chkMasculino_CheckendChanged(object sender, EventArgs e)
        {
            chkMasculino.ForeColor = Color.DarkOrange;
            chkFeminino.ForeColor = Color.Gray;
            chkMasculino.Checked = true;
            chkFeminino.Checked = false;
        }

        private void chkFeminino_CheckendChanged(object sender, EventArgs e)
        {
            chkFeminino.ForeColor = Color.DarkOrange;
            chkMasculino.ForeColor = Color.Gray;
            chkFeminino.Checked = true;
            chkMasculino.Checked = false;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(chkAdulto.Checked && chkMasculino.Checked)
            {
                #region Adulto Masculino


                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var TextoBase = $@"Meu IMC: {imc:N2} é";

                if (imc < 18.5)
                {
                    lblResultado.Text = $@" {TextoBase} abaixo do normal";
                    picBoxImc.Load(ImcImagem.MasculinoAbaixoDoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultado.Text = $@" {TextoBase} normal";
                    picBoxImc.Load(ImcImagem.MasculinoNormal);
                }
                else if (imc <29.9)
                {
                    lblResultado.Text = $@" {TextoBase} sobrepeso";
                    picBoxImc.Load(ImcImagem.MasculinoSobrepeso);
                }
                else if (imc < 34.9)
                {
                    lblResultado.Text = $@" {TextoBase} obesidade grau 1";
                    picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau1);
                }
                else if (imc < 39.9)
                {
                    lblResultado.Text = $@" {TextoBase} {imc:N2} é obesidade grau 2";
                    picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau2);
                }
                else
                {
                    lblResultado.Text = $@" {TextoBase} {imc:N2} é obesidade grau 3";
                    picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau3);
                }
                #endregion
                
            }
            
            if(chkAdulto.Checked && chkFeminino.Checked)
            {
                #region Adulto Feminino


                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var TextoBase = $@"Meu IMC: {imc:N2} é";

                if (imc < 18.5)
                {
                    lblResultado.Text = $@" {TextoBase} abaixo do normal";
                    picBoxImc.Load(ImcImagem.FemeninoAbaixoDoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultado.Text = $@" {TextoBase} normal";
                    picBoxImc.Load(ImcImagem.FemeninoNormal);
                }
                else if (imc <29.9)
                {
                    lblResultado.Text = $@" {TextoBase} sobrepeso";
                    picBoxImc.Load(ImcImagem.FemeninoSobrepeso);
                }
                else if (imc < 34.9)
                {
                    lblResultado.Text = $@" {TextoBase} obesidade grau 1";
                    picBoxImc.Load(ImcImagem.FemeninoObesidadeGrau1);
                }
                else if (imc < 39.9)
                {
                    lblResultado.Text = $@" {TextoBase} {imc:N2} é obesidade grau 2";
                    picBoxImc.Load(ImcImagem.FemeninoObesidadeGrau2);
                }
                else
                {
                    lblResultado.Text = $@" {TextoBase} {imc:N2} é obesidade grau 3";
                    picBoxImc.Load(ImcImagem.FemeninoObesidadeGrau3);
                }
                #endregion
            }

            if (chkCriança.Checked && chkCriança.Checked)
            {
                #region Criança 

                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var TextoBase = $@"Meu IMC: {imc:N2} é";

                if (imc < 18.5)
                {
                    lblResultado.Text = $@" {TextoBase} abaixo do normal";
                    picBoxImc.Load(ImcImagem.CriançaAbaixoDoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultado.Text = $@" {TextoBase} normal";
                    picBoxImc.Load(ImcImagem.CriançaNormal);
                }
                else if (imc <29.9)
                {
                    lblResultado.Text = $@" {TextoBase} sobrepeso";
                    picBoxImc.Load(ImcImagem.CriançaSobrepeso);
                }
                else if (imc < 34.9)
                {
                    lblResultado.Text = $@" {TextoBase} obesidade grau 1";
                    picBoxImc.Load(ImcImagem.CriançaObesidade);
                }
                #endregion  
            }
        }

    }
    
}

