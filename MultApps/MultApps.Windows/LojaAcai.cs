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
            #region Acai

            int quantidade = 1; // Neste caso, a quantidade é fixa, já que o botão adiciona 1 por vez.
            decimal precoUnitario = 15.00m; // Preço do Açaí Pequeno
            decimal precoTotal = quantidade * precoUnitario;

            lstPedido.Items.Add($"Açaí 300ml: {quantidade} - Preço Total: R$ {precoTotal:F2}");
            AtualizarTotal(); // Atualiza o total do pedido automaticamente

        }

        private void btnAcaiMedio_Click(object sender, EventArgs e)
        {
            int quantidade = 1; // Quantidade fixa, pois o botão adiciona um item por vez.
            decimal precoUnitario = 20.00m; // Preço do Açaí Médio
            decimal precoTotal = quantidade * precoUnitario;

            lstPedido.Items.Add($"Açaí 500ml: {quantidade} - Preço Total: R$ {precoTotal:F2}");
            AtualizarTotal();
        }

        private void btnAcaiGrande_Click(object sender, EventArgs e)
        {
            int quantidade = 1; // Quantidade fixa, já que o botão adiciona um item por vez.
            decimal precoUnitario = 25.00m; // Preço do Açaí Grande
            decimal precoTotal = quantidade * precoUnitario;

            lstPedido.Items.Add($"Açaí 700ml: {quantidade} - Preço Total: R$ {precoTotal:F2}");
            AtualizarTotal();
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            int quantidade = 1; // Quantidade fixa, já que o botão adiciona um item por vez.
            decimal precoUnitario = 35.00m; // Preço do Açaí Família
            decimal precoTotal = quantidade * precoUnitario;

            lstPedido.Items.Add($"Açaí 1L: {quantidade} - Preço Total: R$ {precoTotal:F2}");
            AtualizarTotal();

            #endregion
        }

        private void nudGotasdeChocolate_ValueChanged(object sender, EventArgs e)
        {
            #region Complemento
            int quantidade = 1; 
           decimal precoUnitario = 3.00m; // Preço unitário das gotas de chocolate
           decimal precoTotal = quantidade * precoUnitario;

           lstPedido.Items.Add($"Gosta de Chocolate: {quantidade} - Preço Total: R$ {precoTotal:F2}");
           AtualizarTotal();
        }

        private void nudLeiteEmPó_ValueChanged(object sender, EventArgs e)
        {
            int quantidade = 1;
            decimal precoUnitario = 2.00m; // Preço unitário do leite em pó
            decimal precoTotal = quantidade * precoUnitario;

            lstPedido.Items.Add($"Leite em Pó: {quantidade} - Preço Total: R$ {precoTotal:F2}");
            AtualizarTotal() ; 
        }

        private void nudMorango_ValueChanged(object sender, EventArgs e)
        {
           int quantidade = 1;
           decimal precoUnitario = 3.00m; // Preço unitário do morango
           decimal precoTotal = quantidade * precoUnitario;
            lstPedido.Items.Add($"Morango: {quantidade} - Preço Total: R$ {precoTotal:F2}");
            AtualizarTotal();    

        }

        private void nudUva_ValueChanged(object sender, EventArgs e)
        {
            int quantidade = 1;
            decimal precoUnitario = 3.50m; // Preço unitário da uva
            decimal precoTotal = quantidade * precoUnitario;
            lstPedido.Items.Add($"Uva: {quantidade} - Preço Total: R$ {precoTotal:F2}");
            AtualizarTotal();
            #endregion
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstPedido.SelectedItem != null)
            {
                lstPedido.Items.Remove(lstPedido.SelectedItem);
                AtualizarTotal();
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }

        private void AtualizarTotal()
        {
            decimal total = 0;

            foreach (var item in lstPedido.Items)
            {
                string itemText = item.ToString();

                // Garante que "Preço Total: R$ " exista na string antes de tentar acessar
                int startIndex = itemText.IndexOf("Preço Total: R$ ");
                if (startIndex != -1)
                {
                    startIndex += "Preço Total: R$ ".Length;

                    // Verifica se o índice está dentro do limite da string
                    if (startIndex < itemText.Length)
                    {
                        string precoText = itemText.Substring(startIndex).Trim();

                        // Tenta converter o texto do preço para decimal
                        if (decimal.TryParse(precoText, out decimal preco))
                        {
                            total += preco;
                        }
                    }
                }
            }

            // Atualiza o label com o valor total
            lblValor.Text = $"Total: R$ {total:F2}";
        }

    }


}
