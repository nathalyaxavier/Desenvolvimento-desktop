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
    public partial class LojaAcai : Form
    {
        public LojaAcai()
        {
            InitializeComponent();
        }
        private void btnAcaiPequeno_Click(object sender, EventArgs e)
        {
            lstPedido.Items.Add("Açaí 300ml - Quantidade: 1 - Preço: R$ 15,00");
            
        }

        private void btnAcaiMedio_Click(object sender, EventArgs e)
        {
            lstPedido.Items.Add("Açaí 500ml - Quantidade: 1 - Preço: R$ 20,00");
            
        }

        private void btnAcaiGrande_Click(object sender, EventArgs e)
        {
            lstPedido.Items.Add("Açaí 700ml - Quantidade: 1 - Preço: R$ 25,00");
           
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            lstPedido.Items.Add("Açaí 1L - Quantidade: 1 - Preço: R$ 35,00");
           
        }

        private void nudGotasdeChocolate_ValueChanged(object sender, EventArgs e)
        {
            int quantidade = (int)nudGotasdeChocolate.Value;

            lstPedido.Items.Add($"Gotas de Chocolate: {quantidade}");
            
        }

        private void nudLeiteEmPó_ValueChanged(object sender, EventArgs e)
        {
            int quantidade = (int)nudLeiteEmPó.Value;

            lstPedido.Items.Add($"Leite Em Pó: {quantidade}");
            
        }

        private void nudMorango_ValueChanged(object sender, EventArgs e)
        {
            int quantidade = (int)nudMorango.Value;

            lstPedido.Items.Add($"Morango: {quantidade}");
           
        }

        private void nudCompletoUva_ValueChanged(object sender, EventArgs e)
        {
            int quantidade = (int)nudUva.Value;

            lstPedido.Items.Add($"Uva: {quantidade}");
           
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstPedido.SelectedItem != null)
            {
                lstPedido.Items.Remove(lstPedido.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = 0;

            foreach (string item in lstPedido.Items)
            {
                // Extract the price from the item description
                string[] parts = item.Split('-');
                string precoString = parts[parts.Length - 1].Trim().Replace("Preço: R$", "").Replace(",", ".");

                if (double.TryParse(precoString, out double preco))
                {
                    total += preco;
                }
            }

            // Display the total
            MessageBox.Show($"O total do pedido é: R$ {total:F2}", "Total do Pedido");
        }
    }
    
    
}
