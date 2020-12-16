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
    enum extensiones
    {
        txt, ini, java, cs, py, html, css, xml
    }
    public partial class Form1 : Form
    {
        SaveFileDialog sv;
        OpenFileDialog op;
        FileInfo f;
        bool guardado = false;
        List<string> recientes = new List<string>();
        Form2 f2;
        internal bool win2 = false;
        FontConverter cvt = new FontConverter();        //https://stackoverflow.com/questions/2207709/convert-font-to-string-and-back-again
        string rutaConfig = Environment.GetEnvironmentVariable("appdata")+"\\configEditorTexto.config";   // Config a nivel usuario (ProgramData para global) Crear dir si existen + archivos de config
        string titulo = "Editor de texto";
        DialogResult res;

        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(texto, "Líneas: 0\r\nPalabras: 0\r\nCaracteres: 0");
            itemInfoApp.Click += (Sender, Ev) => MessageBox.Show("Editor de texto ... (descripción)","Información sobre la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            configLeer();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!guardado)
            {
                res = MessageBox.Show("¿Quieres guardar los cambios antes de salir?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (res)                    
                {
                    case DialogResult.Yes:
                        guardar();
                        break;
                    case DialogResult.Cancel:                
                        e.Cancel = true;
                        break;
                }
            }
            configEscribir();
        }

        // ======================= ARCHIVO ================================
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!guardado)
            {
                if(MessageBox.Show("¿Quieres guardar este archivo antes de abrir uno nuevo?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                    == DialogResult.Yes){
                    guardar();
                }
            }
            texto.Text = "";
            this.Text = titulo;
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
            res = sv.ShowDialog();
            if (res == DialogResult.OK)
            {                
                f = new FileInfo(sv.FileName);                
                using (StreamWriter sw = new StreamWriter(f.FullName))
                {
                    sw.Write(texto.Text);
                }
                guardado = true;
                colocarRecientes(sv.FileName);
                this.Text = f.Name;
            }
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            res = DialogResult.No;
            if (!guardado)
            {
                res = MessageBox.Show("¿Quieres guardar los cambios antes de abrir un nuevo archivo?", "Abrir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(res == DialogResult.Yes)
                {
                    guardar();
                }
            }
            if(res != DialogResult.Cancel)
            {
                op = new OpenFileDialog();
                op.Title = "Abrir";
                this.op.Filter = "Texto|*.txt|Config|*.ini|Java|*.java|C#|*.cs|Python|*.py|HTML|*.html|CSS|*.css|XML|*.xml|Todos los archivos|*.*";
                res = op.ShowDialog();
                if (res == DialogResult.OK)
                {
                    f = new FileInfo(op.FileName);
                    if (Enum.GetNames(typeof(extensiones)).ToList<string>().Contains(f.Extension.Substring(1)))
                    {
                        leer(f.FullName);
                        colocarRecientes(op.FileName);
                        this.Text = f.Name;
                        guardado = true;
                    }
                    else
                    {
                        MessageBox.Show("Archivo no válido " + f.Extension, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }            
        }

        private void leer(string ruta)
        {
            texto.Text = "";
            string linea;
            using (StreamReader sr = new StreamReader(ruta))
            {
                while ((linea = sr.ReadLine()) != null)
                {
                    texto.Text += linea + Environment.NewLine;
                }
            }
        }

        private void archivosRecientesOpening(object sender, EventArgs e)
        {
            if (recientes.Count > 0)
            {
                ToolStripMenuItem item;
                for (int i = 0; i < (recientes.Count > 5 ? 5 : recientes.Count); i++)
                {
                    if (File.Exists(recientes.ElementAt(i)))
                    {
                        item = new ToolStripMenuItem();
                        f = new FileInfo(recientes.ElementAt(i));
                        item.Text = f.Name;
                        item.Tag = f.FullName;
                        itemRecientes.DropDownItems.Add(item);
                        item.Click += new System.EventHandler(archivosRecientesClick);
                    }
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
            colocarRecientes(item.Tag.ToString());
            f = new FileInfo(item.Tag.ToString());
            this.Text = f.Name;
        }

        private void colocarRecientes(string fileName)
        {
            if (!recientes.Contains(fileName))
            {
                recientes.Insert(0, fileName);
            }
            else
            {
                string file = fileName;
                recientes.Remove(file);
                recientes.Insert(0, file);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configEscribir();
            Environment.Exit(0);
        }

// ===========================================================

        private void actualizarText(object sender, EventArgs e)
        {
            guardado = false;
            string[] n = texto.Text.Replace(Environment.NewLine, " ").Split(' ');   //número de palabras...            
            List<string> numPalabras = n.ToList();
            int numChar = 0;

            for (int i = numPalabras.Count() - 1; i >= 0; i--)
            {
                if (numPalabras.ElementAt(i).Trim().Length == 0)
                {
                    numPalabras.RemoveAt(i);
                }
                else
                {
                    numChar += numPalabras.ElementAt(i).Length;       //número de caracteres de cada palabra   
                }
            }

            string cant = string.Format("Líneas: {1}{0}Palabras: {2}{0}Caracteres: {3}", Environment.NewLine, texto.Lines.Length, numPalabras.Count, numChar);
            //text.Text.Count() --> conta tamén saltos de liña (+2)
            toolTip1.SetToolTip(texto, cant);
        }

// ======================= HERRAMIENTAS ================================
        private void ajusteLineaToolStripMenuItem_Check(object sender, EventArgs e)
        {
            ajusteLinea();
        }

        private void ajusteLinea()
        {
            texto.WordWrap = itemAjusteLinea.Checked;
            texto.ScrollBars = texto.WordWrap ? ScrollBars.Vertical : ScrollBars.Both;
            texto.Select(0, 0);
        }

        private void seleccionEscritura(object sender, EventArgs e)     //execútase cada vez que Check se cambie
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if(!itemMayus.Checked && !itemMinus.Checked && !itemNormal.Checked) //para que sempre haxa algún elem check
            {
                item.Checked = true;    
            }
            if (item.Checked)       //para evitar que entre en bucle, porque a prop Check se cambia nos case
            {
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
        }

        private void colorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if(clr.ShowDialog() == DialogResult.OK)
            {
                texto.ForeColor = clr.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                texto.BackColor = clr.Color;
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if(fnt.ShowDialog() == DialogResult.OK)
            {
                texto.Font = fnt.Font;
            }
        }

//-------------------- SELECCION ---------------------
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

// ---------------------- ARCHIVO CONFIG ----------------------
        private void configEscribir()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Create(rutaConfig)))
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
            string ruta;
            if (File.Exists(rutaConfig)){
                using (BinaryReader br = new BinaryReader(File.OpenRead(rutaConfig)))
                {
                    itemAjusteLinea.Checked = br.ReadBoolean();
                    ajusteLinea();
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

// ============================== EDICIÓN =================================
        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)        //facer colección para restaurar máis modificacións
        {
            if (texto.CanUndo) //texto.Modified
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
    }
}
