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
            int i, l;
            if (int.TryParse(txtInicio.Text, out i) && int.TryParse(txtLong.Text, out l))
                if(i >= 0  && l >= 0 && l < f1.texto.Text.Length - i)
                {
                    lblInicio.Text = txtInicio.Text;
                    lblLong.Text = txtLong.Text;
                    f1.texto.Select(i, l);
                }
                else
                {
                    MessageBox.Show("Valores no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                MessageBox.Show("Introduce números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
                        
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.win2 = false;
        }
    }
}
