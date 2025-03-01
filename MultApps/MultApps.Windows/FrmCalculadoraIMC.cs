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

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCriança.ForeColor = Color.Gray;
            chkAdulto.Checked = true;
            chkCriança.Checked = false;
            lblIdade.Text = "Acima de 19 anos";
            
        }

      
    }
}
