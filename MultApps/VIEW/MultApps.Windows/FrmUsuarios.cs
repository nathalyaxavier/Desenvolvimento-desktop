using MultApps.Models.Entities;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;
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

        public FrmUsuarios()
        {
            InitializeComponent();
            //Carregar o status do usuário.
            var status = new[] { "ativo", "inativo"};
            var filtro = new[] { "todos", "ativos", "inativo"};
            cmbStatus.Items.AddRange(status);
            cmbFiltrar.Items.AddRange(filtro);

            cmbStatus.SelectedIndex = 0;
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            //1 Passo pega os dados da tela
            //try para capturar  erros de conversão de valores.
            try
            {
                //Verificar se tem campos em branco.
                if(TemCamposEmbrancos())
                {
                    return;
                }

                var usuario = new Usuario();
                usuario.Nome = txtNomeCompleto.Text;
                usuario.CPF = mtxCPF.Text;
                usuario.Email= txtEmail.Text;
                usuario.Senha= txtSenha.Text;
                usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;

                //2Passo criar o objeto de repositório.
                var usuarioRepository = new UsuarioRepository();

                //Verificar se o email já existe
                var EmailJaExiste = usuarioRepository.EmailExiste(usuario.Email);
                if(EmailJaExiste)
                {
                    MessageBox.Show($"O email {usuario.Email} já está cadastrado.");
                    txtEmail.Focus();
                    return;
                }

                //3 Passo chamar o metodo de cadastro.
                var sucesso = usuarioRepository.CadastrarUsuario(usuario);

                if (sucesso)
                {
                    MessageBox.Show($"Usuário {usuario.Nome} cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show($"Erro ao cadastrar o usuário {usuario.Nome}");
                }
            }


            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }


        private bool TemCamposEmbrancos()
        {
            if( string.IsNullOrEmpty( txtNomeCompleto.Text ))
            {
                MessageBox.Show("Campo Nome é obrigatorio");
                txtNomeCompleto.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(mtxCPF.Text))
            {
                MessageBox.Show("Campo CPF é obrigatorio");
                txtNomeCompleto.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Campo Email é obrigatorio");
                txtNomeCompleto.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Campo Senha é obrigatorio");
                txtNomeCompleto.Focus();
                return true;
            }
            
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("campo Status é obrigatório");
                cmbStatus.Focus();
                return true;
            }
            return false;
        }
    }
}
