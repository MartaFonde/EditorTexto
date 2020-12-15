using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTexto
{
    public partial class Form1 : Form
    {
        SaveFileDialog sv;
        OpenFileDialog op;
        bool guardado = true;
        List<string> recientes = new List<string>();
        Form2 f2;
        bool win2 = false;
        FontConverter cvt = new FontConverter();
        string ruta = "..\\..\\..\\configuracion.config";
        FileStream fich;


        public Form1()
        {
            InitializeComponent();
            configLeer();
            toolTip1.SetToolTip(texto, "Líneas: 0\r\nPalabras: 0\r\nLetras: 0");
            itemInfoApp.Click += (Sender, Ev) => MessageBox.Show("Editor de texto ... (descripción)","Información sobre la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void actualizarText(object sender, EventArgs e)
        {
            guardado = false;
            string[] n = texto.Text.Replace(Environment.NewLine, " ").Split(' ');   //número de palabras...            
            List<string> numPalabras = n.ToList();
            int numLetras = 0;

            for (int i = numPalabras.Count() - 1; i >= 0; i--)
            {

                if (numPalabras.ElementAt(i).Trim().Length == 0)
                {
                    numPalabras.RemoveAt(i);
                }
                else
                {
                    numLetras += numPalabras.ElementAt(i).Length;       //número de letras de cada palabra   
                }
            }

            string cant = string.Format("Líneas: {1}{0}Palabras: {2}{0}Letras: {3}", Environment.NewLine, texto.Lines.Length, numPalabras.Count, numLetras);
            //text.Text.Count() --> conta tamén saltos de liña (+2)
            toolTip1.SetToolTip(texto, cant);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!guardado)
            {
                if (texto.Text.Length > 0)
                {
                    DialogResult res = MessageBox.Show("¿Quieres guardar antes de abrir un nuevo documento?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (res)
                    {
                        case DialogResult.Yes:
                            guardar();
                            goto default;
                        case DialogResult.No:
                            goto default;
                        default:
                            texto.Text = "";
                            guardado = true;
                            break;
                    }
                }
            }
            else
            {
                texto.Text = "";
            }          
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            sv = new SaveFileDialog();
            sv.Title = "Guardar";
            sv.Filter = "Texto|*.txt|Config|*.ini|Java|*.java|C#|*.cs|Python|*.py|HTML|*.html|CSS|*.css|XML|*.xml|Todos los archivos|*.*";
            sv.AddExtension = true;
            //sv.DefaultExt = ".txt";
            DialogResult res = sv.ShowDialog();
            if (res == DialogResult.OK)
            {
                FileInfo f = new FileInfo(sv.FileName);
                StreamWriter sw;
                using (sw = new StreamWriter(f.FullName))
                {
                    sw.WriteLine(texto.Text);
                }
                guardado = true;
                if (!recientes.Contains(sv.FileName))
                {
                    recientes.Insert(0, sv.FileName);
                }
                guardado = true;
            }
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            op = new OpenFileDialog();
            op.Title = "Abrir";
            this.op.Filter = "Texto|*.txt|Config|*.ini|Java|*.java|C#|*.cs|Python|*.py|HTML|*.html|CSS|*.css|XML|*.xml|Todos los archivos|*.*";
            DialogResult res = op.ShowDialog();
            if(res == DialogResult.OK)
            {
                FileInfo f = new FileInfo(op.FileName);
                leer(f.FullName);
                if (!recientes.Contains(op.FileName))
                {
                    recientes.Insert(0, op.FileName);
                }
                guardado = true;
            }
        }

        private void leer(string ruta)
        {
            texto.Text = "";
            string linea;
            StreamReader sr;
            using (sr = new StreamReader(ruta))
            {
                while ((linea = sr.ReadLine()) != null)
                {
                    texto.Text += linea + Environment.NewLine;
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (texto.Modified && texto.CanUndo)
            {
                texto.Undo();
            }
        }
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texto.Copy();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texto.Cut();
        }
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texto.Paste();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texto.SelectAll();
        }

        private void seleccionEscritura(object sender, EventArgs e) //SOLO PUEDE SELECCIONAR UNO
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            switch (item.Tag.ToString())
            {
                case "mayus":
                    texto.CharacterCasing = CharacterCasing.Upper;
                    itemMinus.Checked = false;
                    itemNormal.Checked = false;
                    break;
                case "minus":
                    texto.CharacterCasing = CharacterCasing.Lower;
                    itemMayus.Checked = false;
                    itemNormal.Checked = false;
                    break;
                case "normal":
                    texto.CharacterCasing = CharacterCasing.Normal;
                    itemMayus.Checked = false;
                    itemMinus.Checked = false;
                    break;
            }
        }

        private void colorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            DialogResult res = clr.ShowDialog();
            if(res == DialogResult.OK)
            {
                texto.ForeColor = clr.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            DialogResult res = clr.ShowDialog();
            if (res == DialogResult.OK)
            {
                texto.BackColor = clr.Color;
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            DialogResult res = fnt.ShowDialog();
            if(res == DialogResult.OK)
            {
                texto.Font = fnt.Font;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!guardado)
            {
                if(MessageBox.Show("El archivo no se ha guardado, ¿seguro que quieres salir?", "Archivo no guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
            configEscribir();
        }

        private void ajusteDeLíneaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texto.WordWrap = itemAjusteLinea.Checked ? true : false;
            texto.ScrollBars = texto.WordWrap? ScrollBars.Vertical : ScrollBars.Both;            
        }

        private void archivosRecientesOpening(object sender, EventArgs e)
        {
            if(recientes.Count > 0)                 
            {                
                ToolStripMenuItem item;
                for (int i = 0; i < (recientes.Count > 5 ? 5 : recientes.Count); i++)
                {
                    item = new ToolStripMenuItem();
                    FileInfo f = new FileInfo(recientes.ElementAt(i));
                    item.Text = f.Name;
                    item.Tag = f.FullName;
                    itemRecientes.DropDownItems.Add(item);
                    item.Click += new System.EventHandler(archivosRecientesClick);
                }
            }            
        }

        private void archivosRecientesClosed(object sender, EventArgs e)
        {
            itemRecientes.DropDownItems.Clear();
        }

        private void archivosRecientesClick(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            leer(item.Tag.ToString());            
        }


        //FORM NO MODAL INFORMACION DE SELECCION
        private void itemInfo_Click(object sender, EventArgs e)
        {
            f2 = new Form2(this);
            f2.Show();
            win2 = true;
            f2.lblInicio.Text = texto.SelectionStart.ToString();
            f2.lblLong.Text = texto.SelectionLength.ToString();
        }

        private void texto_MouseMove(object sender, MouseEventArgs e)
        {
            if (win2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    f2.lblInicio.Text = texto.SelectionStart.ToString();
                    f2.lblLong.Text = texto.SelectionLength.ToString();
                }
            }            
        }
        private void texto_KeyDown(object sender, KeyEventArgs e)
        {
            if (win2)
            {
                if (e.Shift)
                {
                    if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
                    {
                        f2.lblInicio.Text = texto.SelectionStart.ToString();
                        f2.lblLong.Text = texto.SelectionLength.ToString();
                    }
                }
            }            
        }
        // -------------------------------------------------------------------
        private void configEscribir()
        {
            BinaryWriter bw;
            fich = File.Create(ruta);
            using (bw = new BinaryWriter(fich))
            {
                bw.Write(itemAjusteLinea.Checked);
                bw.Write(itemMayus.Checked);
                bw.Write(itemMinus.Checked);
                bw.Write(itemNormal.Checked);

                bw.Write(texto.ForeColor.R);
                bw.Write(texto.ForeColor.G);
                bw.Write(texto.ForeColor.B);

                bw.Write(texto.BackColor.R);
                bw.Write(texto.BackColor.G);
                bw.Write(texto.BackColor.B);

                bw.Write(cvt.ConvertToString(this.texto.Font));

                bw.Write(Environment.CurrentDirectory);

                foreach (string s in recientes)
                {
                    bw.Write(s);
                }
            }
        }

        private void configLeer()
        {
            string ruta = null;

            if (File.Exists(ruta)){

                BinaryReader br;
                fich = File.OpenRead(ruta);
                using (br = new BinaryReader(fich))
                {
                    itemAjusteLinea.Checked = br.ReadBoolean();

                    itemMayus.Checked = br.ReadBoolean();
                    itemMinus.Checked = br.ReadBoolean();
                    itemNormal.Checked = br.ReadBoolean();

                    texto.ForeColor = Color.FromArgb(br.ReadByte(), br.ReadByte(), br.ReadByte());
                    texto.BackColor = Color.FromArgb(br.ReadByte(), br.ReadByte(), br.ReadByte());

                    texto.Font = cvt.ConvertFromString(br.ReadString()) as Font;

                    Environment.CurrentDirectory = br.ReadString();

                    while (br.BaseStream.Position != br.BaseStream.Length)
                    {
                        ruta = br.ReadString();
                        if (File.Exists(ruta))
                        {
                            recientes.Add(ruta);
                        }
                    }
                }
            }            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            //string[] n = texto.Text.Replace(Environment.NewLine, " ").Split(' ');   //número de palabras...            
            //List<string> numPalabras = n.ToList();
            //int numLetras = 0;

            //for (int i = numPalabras.Count() - 1; i >= 0; i--)
            //{
            //    if (numPalabras.ElementAt(i).Trim().Length == 0)
            //    {
            //        numPalabras.RemoveAt(i);
            //    }
            //    else
            //    {
            //        numLetras += numPalabras.ElementAt(i).Length;       //número de letras de cada palabra   
            //    }
            //}

            //string cant = string.Format("Líneas: {1}{0}Palabras: {2}{0}Letras: {3}", Environment.NewLine, texto.Lines.Length, numPalabras.Count, numLetras);
            ////text.Text.Count() --> conta tamén saltos de liña (+2)
            //toolTip1.SetToolTip(texto, cant);
        }
    }
}
