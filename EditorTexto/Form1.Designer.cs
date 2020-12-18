
namespace EditorTexto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.texto = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRecientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemSelecAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAjusteLinea = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSelecEscritura = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMayus = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMinus = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.itemColorTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.itemColorFondo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInfoApp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texto.HideSelection = false;
            this.texto.Location = new System.Drawing.Point(0, 52);
            this.texto.Multiline = true;
            this.texto.Name = "texto";
            this.texto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.texto.Size = new System.Drawing.Size(784, 509);
            this.texto.TabIndex = 0;
            this.texto.TextChanged += new System.EventHandler(this.actualizarText);
            this.texto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.texto_KeyUp);
            this.texto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.texto_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemArchivo,
            this.itemEdicion,
            this.itemHerramientas,
            this.itemInfoApp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.TextChanged += new System.EventHandler(this.actualizarText);
            // 
            // itemArchivo
            // 
            this.itemArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemNuevo,
            this.itemAbrir,
            this.itemGuardar,
            this.itemRecientes,
            this.toolStripMenuItem3,
            this.itemSalir});
            this.itemArchivo.Name = "itemArchivo";
            this.itemArchivo.Size = new System.Drawing.Size(60, 20);
            this.itemArchivo.Text = "&Archivo";
            // 
            // itemNuevo
            // 
            this.itemNuevo.Name = "itemNuevo";
            this.itemNuevo.Size = new System.Drawing.Size(124, 22);
            this.itemNuevo.Text = "&Nuevo ";
            this.itemNuevo.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // itemAbrir
            // 
            this.itemAbrir.Name = "itemAbrir";
            this.itemAbrir.Size = new System.Drawing.Size(124, 22);
            this.itemAbrir.Text = "&Abrir";
            this.itemAbrir.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // itemGuardar
            // 
            this.itemGuardar.Name = "itemGuardar";
            this.itemGuardar.Size = new System.Drawing.Size(124, 22);
            this.itemGuardar.Text = "&Guardar ";
            this.itemGuardar.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // itemRecientes
            // 
            this.itemRecientes.Name = "itemRecientes";
            this.itemRecientes.Size = new System.Drawing.Size(124, 22);
            this.itemRecientes.Text = "&Recientes";
            this.itemRecientes.DropDownClosed += new System.EventHandler(this.archivosRecientesClosed);
            this.itemRecientes.DropDownOpening += new System.EventHandler(this.archivosRecientesOpening);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 6);
            // 
            // itemSalir
            // 
            this.itemSalir.Name = "itemSalir";
            this.itemSalir.Size = new System.Drawing.Size(124, 22);
            this.itemSalir.Text = "&Salir";
            this.itemSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // itemEdicion
            // 
            this.itemEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDeshacer,
            this.itemCopiar,
            this.itemCortar,
            this.itemPegar,
            this.toolStripMenuItem1,
            this.itemSelecAll,
            this.toolStripMenuItem2,
            this.itemInfo});
            this.itemEdicion.Name = "itemEdicion";
            this.itemEdicion.Size = new System.Drawing.Size(58, 20);
            this.itemEdicion.Text = "&Edición";
            // 
            // itemDeshacer
            // 
            this.itemDeshacer.Name = "itemDeshacer";
            this.itemDeshacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.itemDeshacer.Size = new System.Drawing.Size(244, 22);
            this.itemDeshacer.Text = "&Deshacer";
            this.itemDeshacer.Click += new System.EventHandler(this.deshacerToolStripMenuItem_Click);
            // 
            // itemCopiar
            // 
            this.itemCopiar.Name = "itemCopiar";
            this.itemCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.itemCopiar.Size = new System.Drawing.Size(244, 22);
            this.itemCopiar.Text = "&Copiar";
            this.itemCopiar.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // itemCortar
            // 
            this.itemCortar.Name = "itemCortar";
            this.itemCortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.itemCortar.Size = new System.Drawing.Size(244, 22);
            this.itemCortar.Text = "Co&rtar";
            this.itemCortar.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // itemPegar
            // 
            this.itemPegar.Name = "itemPegar";
            this.itemPegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.itemPegar.Size = new System.Drawing.Size(244, 22);
            this.itemPegar.Text = "&Pegar";
            this.itemPegar.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(241, 6);
            // 
            // itemSelecAll
            // 
            this.itemSelecAll.Name = "itemSelecAll";
            this.itemSelecAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.itemSelecAll.Size = new System.Drawing.Size(244, 22);
            this.itemSelecAll.Text = "Seleccionar &todo";
            this.itemSelecAll.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(241, 6);
            // 
            // itemInfo
            // 
            this.itemInfo.Name = "itemInfo";
            this.itemInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.itemInfo.Size = new System.Drawing.Size(244, 22);
            this.itemInfo.Text = "&Información de selección";
            this.itemInfo.Click += new System.EventHandler(this.itemInfo_Click);
            // 
            // itemHerramientas
            // 
            this.itemHerramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAjusteLinea,
            this.itemSelecEscritura,
            this.itemColorTxt,
            this.itemColorFondo,
            this.itemFuente});
            this.itemHerramientas.Name = "itemHerramientas";
            this.itemHerramientas.Size = new System.Drawing.Size(90, 20);
            this.itemHerramientas.Text = "&Herramientas";
            // 
            // itemAjusteLinea
            // 
            this.itemAjusteLinea.Checked = true;
            this.itemAjusteLinea.CheckOnClick = true;
            this.itemAjusteLinea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemAjusteLinea.Name = "itemAjusteLinea";
            this.itemAjusteLinea.Size = new System.Drawing.Size(188, 22);
            this.itemAjusteLinea.Text = "&Ajuste de línea";
            this.itemAjusteLinea.CheckStateChanged += new System.EventHandler(this.ajusteLineaToolStripMenuItem_Check);
            // 
            // itemSelecEscritura
            // 
            this.itemSelecEscritura.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMayus,
            this.itemMinus,
            this.itemNormal});
            this.itemSelecEscritura.Name = "itemSelecEscritura";
            this.itemSelecEscritura.Size = new System.Drawing.Size(188, 22);
            this.itemSelecEscritura.Text = "&Selección de escritura";
            // 
            // itemMayus
            // 
            this.itemMayus.CheckOnClick = true;
            this.itemMayus.Name = "itemMayus";
            this.itemMayus.Size = new System.Drawing.Size(136, 22);
            this.itemMayus.Tag = "mayus";
            this.itemMayus.Text = "Mayúsculas";
            this.itemMayus.CheckStateChanged += new System.EventHandler(this.seleccionEscritura);
            // 
            // itemMinus
            // 
            this.itemMinus.CheckOnClick = true;
            this.itemMinus.Name = "itemMinus";
            this.itemMinus.Size = new System.Drawing.Size(136, 22);
            this.itemMinus.Tag = "minus";
            this.itemMinus.Text = "Minúsculas";
            this.itemMinus.CheckStateChanged += new System.EventHandler(this.seleccionEscritura);
            // 
            // itemNormal
            // 
            this.itemNormal.Checked = true;
            this.itemNormal.CheckOnClick = true;
            this.itemNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemNormal.Name = "itemNormal";
            this.itemNormal.Size = new System.Drawing.Size(136, 22);
            this.itemNormal.Tag = "normal";
            this.itemNormal.Text = "Normal";
            this.itemNormal.CheckStateChanged += new System.EventHandler(this.seleccionEscritura);
            // 
            // itemColorTxt
            // 
            this.itemColorTxt.Name = "itemColorTxt";
            this.itemColorTxt.Size = new System.Drawing.Size(188, 22);
            this.itemColorTxt.Text = "Color de &texto";
            this.itemColorTxt.Click += new System.EventHandler(this.colorDeTextoToolStripMenuItem_Click);
            // 
            // itemColorFondo
            // 
            this.itemColorFondo.Name = "itemColorFondo";
            this.itemColorFondo.Size = new System.Drawing.Size(188, 22);
            this.itemColorFondo.Text = "&Color de fondo";
            this.itemColorFondo.Click += new System.EventHandler(this.colorDeFondoToolStripMenuItem_Click);
            // 
            // itemFuente
            // 
            this.itemFuente.Name = "itemFuente";
            this.itemFuente.Size = new System.Drawing.Size(188, 22);
            this.itemFuente.Text = "&Fuente";
            this.itemFuente.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // itemInfoApp
            // 
            this.itemInfoApp.Name = "itemInfoApp";
            this.itemInfoApp.Size = new System.Drawing.Size(80, 20);
            this.itemInfoApp.Text = "A&cerca de...";
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton5,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton6,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::EditorTexto.Res.newDoc;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Nuevo";
            this.toolStripButton4.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Abrir";
            this.toolStripButton8.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Guardar";
            this.toolStripButton9.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::EditorTexto.Res.undo;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Deshacer";
            this.toolStripButton5.Click += new System.EventHandler(this.deshacerToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::EditorTexto.Res.cut;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Cortar";
            this.toolStripButton1.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::EditorTexto.Res.copy;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Copiar";
            this.toolStripButton2.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::EditorTexto.Res.paste;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Pegar";
            this.toolStripButton3.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::EditorTexto.Res.selecAll;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Seleccionar todo";
            this.toolStripButton6.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::EditorTexto.Res.info;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Información";
            this.toolStripButton7.Click += new System.EventHandler(this.itemInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de texto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemArchivo;
        private System.Windows.Forms.ToolStripMenuItem itemNuevo;
        private System.Windows.Forms.ToolStripMenuItem itemGuardar;
        private System.Windows.Forms.ToolStripMenuItem itemAbrir;
        private System.Windows.Forms.ToolStripMenuItem itemRecientes;
        private System.Windows.Forms.ToolStripMenuItem itemSalir;
        private System.Windows.Forms.ToolStripMenuItem itemEdicion;
        private System.Windows.Forms.ToolStripMenuItem itemDeshacer;
        private System.Windows.Forms.ToolStripMenuItem itemCopiar;
        private System.Windows.Forms.ToolStripMenuItem itemCortar;
        private System.Windows.Forms.ToolStripMenuItem itemPegar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemSelecAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem itemInfo;
        private System.Windows.Forms.ToolStripMenuItem itemHerramientas;
        private System.Windows.Forms.ToolStripMenuItem itemAjusteLinea;
        private System.Windows.Forms.ToolStripMenuItem itemSelecEscritura;
        private System.Windows.Forms.ToolStripMenuItem itemMayus;
        private System.Windows.Forms.ToolStripMenuItem itemMinus;
        private System.Windows.Forms.ToolStripMenuItem itemNormal;
        private System.Windows.Forms.ToolStripMenuItem itemColorTxt;
        private System.Windows.Forms.ToolStripMenuItem itemColorFondo;
        private System.Windows.Forms.ToolStripMenuItem itemFuente;
        private System.Windows.Forms.ToolStripMenuItem itemInfoApp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        internal System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    }
}

