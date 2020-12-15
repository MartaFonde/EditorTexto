using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTexto
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            lblInicio.Text = txtInicio.Text;
            lblLong.Text = txtLong.Text;
            f1.texto.Select(Convert.ToInt32(txtInicio.Text), Convert.ToInt32(txtLong.Text));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
