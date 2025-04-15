using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MultApps.Windows
{
    public partial class FrmUsuarios : Form
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();
        public FrmUsuarios()
        {
            InitializeComponent();
            cmbFiltrar.Items.Add("Todos");
            cmbFiltrar.Items.Add("Ativos");
            cmbFiltrar.Items.Add("Inativos");
            cmbFiltrar.SelectedIndex = 0;
            AtualizarGrid();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                NomeCompleto = txtNomeCompleto.Text,
                CPF = mtxCPF.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text, // Você deve aplicar criptografia aqui
                DataCadastro = DateTime.Now,
                StatusAtivo = checkBoxStatus.Checked
            };

            listaUsuarios.Add(usuario);
            AtualizarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedIndex >= 0)
            {
                var indice = listBoxUsuarios.SelectedIndex;
                var usuario = listaUsuarios[indice];

                usuario.NomeCompleto = txtNomeCompleto.Text;
                usuario.CPF = mtxCPF.Text;
                usuario.Email = txtEmail.Text;
                usuario.StatusAtivo = checkBoxStatus.Checked;

                AtualizarLista()
        }
    }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedIndex >= 0)
            {
                var indice = listBoxUsuarios.SelectedIndex;
                listaUsuarios.RemoveAt(indice);
                AtualizarLista();
            }
        }
    }
