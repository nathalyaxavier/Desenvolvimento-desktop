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
    public partial class CalculoDeAposentaria : Form
    {
        public CalculoDeAposentaria()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime dataNascimento = DateTime.Parse(txtNascimento.Text);
                string sexo = cmbSexo.SelectedItem?.ToString();
                int tempoContribuicao = int.Parse(txtTempoContribuicao.Text);

                if (sexo == null)
                {
                    ExibirMensagem("Por favor, selecione o sexo.", Color.Red);
                    return;
                }

                int idade = DateTime.Now.Year - dataNascimento.Year;
                if (dataNascimento.Date > DateTime.Now.AddYears(-idade)) idade--;

                bool apto = (sexo == "Masculino" && idade >= 65 && tempoContribuicao >= 20) ||
                            (sexo == "Feminino" && idade >= 62 && tempoContribuicao >= 15);
                            int somaIdadeContribuicao = idade + tempoContribuicao;

                if (apto)
                {
                    ExibirMensagem("Você pode dar entrada no processo de aposentadoria.", Color.Green);
                }
                else
                {
                    ExibirMensagem("Você não cumpre os requisitos para se aposentar.", Color.Red);
                }
            }
            catch (FormatException)
            {
                ExibirMensagem("Por favor, insira dados válidos.", Color.Red);
            }
 
        }
        private void ExibirMensagem(string mensagem, Color cor)
        {
            lblMensagem.Text = mensagem;
            lblMensagem.ForeColor = cor;
            lblMensagem.BackColor = Color.LightGray;

        }
    }
}