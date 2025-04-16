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


        }
    }
