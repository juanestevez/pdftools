namespace XawanPDFTools
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.jpgApdf = new System.Windows.Forms.TabPage();
            this.checkTab1Abrir = new System.Windows.Forms.CheckBox();
            this.linkLblAbout = new System.Windows.Forms.LinkLabel();
            this.btnTab1LimpiarLista = new System.Windows.Forms.Button();
            this.btnGuardarPdf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTab1CambiaRuta = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.radioUnico = new System.Windows.Forms.RadioButton();
            this.radioVarios = new System.Windows.Forms.RadioButton();
            this.txtTab1Ruta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTab1Abajo = new System.Windows.Forms.Button();
            this.btnTab1Arriba = new System.Windows.Forms.Button();
            this.btnTab1Quitar = new System.Windows.Forms.Button();
            this.btnTab1Agregar = new System.Windows.Forms.Button();
            this.listaImagenes = new System.Windows.Forms.ListView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.jpgApdf.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.jpgApdf);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 221);
            this.tabControl1.TabIndex = 0;
            // 
            // jpgApdf
            // 
            this.jpgApdf.BackColor = System.Drawing.Color.Transparent;
            this.jpgApdf.Controls.Add(this.checkTab1Abrir);
            this.jpgApdf.Controls.Add(this.linkLblAbout);
            this.jpgApdf.Controls.Add(this.btnTab1LimpiarLista);
            this.jpgApdf.Controls.Add(this.btnGuardarPdf);
            this.jpgApdf.Controls.Add(this.groupBox1);
            this.jpgApdf.Controls.Add(this.btnTab1Abajo);
            this.jpgApdf.Controls.Add(this.btnTab1Arriba);
            this.jpgApdf.Controls.Add(this.btnTab1Quitar);
            this.jpgApdf.Controls.Add(this.btnTab1Agregar);
            this.jpgApdf.Controls.Add(this.listaImagenes);
            this.jpgApdf.Location = new System.Drawing.Point(4, 22);
            this.jpgApdf.Name = "jpgApdf";
            this.jpgApdf.Padding = new System.Windows.Forms.Padding(3);
            this.jpgApdf.Size = new System.Drawing.Size(601, 195);
            this.jpgApdf.TabIndex = 0;
            this.jpgApdf.Text = "JPG a PDF";
            // 
            // checkTab1Abrir
            // 
            this.checkTab1Abrir.AutoSize = true;
            this.checkTab1Abrir.Checked = true;
            this.checkTab1Abrir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTab1Abrir.Location = new System.Drawing.Point(356, 145);
            this.checkTab1Abrir.Name = "checkTab1Abrir";
            this.checkTab1Abrir.Size = new System.Drawing.Size(122, 17);
            this.checkTab1Abrir.TabIndex = 9;
            this.checkTab1Abrir.Text = "Abrir PDF al terminar";
            this.checkTab1Abrir.UseVisualStyleBackColor = true;
            // 
            // linkLblAbout
            // 
            this.linkLblAbout.AutoSize = true;
            this.linkLblAbout.Location = new System.Drawing.Point(252, 179);
            this.linkLblAbout.Name = "linkLblAbout";
            this.linkLblAbout.Size = new System.Drawing.Size(65, 13);
            this.linkLblAbout.TabIndex = 8;
            this.linkLblAbout.TabStop = true;
            this.linkLblAbout.Text = "Acerca de...";
            this.linkLblAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnTab1LimpiarLista
            // 
            this.btnTab1LimpiarLista.Image = ((System.Drawing.Image)(resources.GetObject("btnTab1LimpiarLista.Image")));
            this.btnTab1LimpiarLista.Location = new System.Drawing.Point(195, 161);
            this.btnTab1LimpiarLista.Name = "btnTab1LimpiarLista";
            this.btnTab1LimpiarLista.Size = new System.Drawing.Size(43, 26);
            this.btnTab1LimpiarLista.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnTab1LimpiarLista, "Limpiar lista");
            this.btnTab1LimpiarLista.UseVisualStyleBackColor = true;
            this.btnTab1LimpiarLista.Click += new System.EventHandler(this.btnTab1LimpiarLista_Click);
            // 
            // btnGuardarPdf
            // 
            this.btnGuardarPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarPdf.Image")));
            this.btnGuardarPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPdf.Location = new System.Drawing.Point(494, 139);
            this.btnGuardarPdf.Name = "btnGuardarPdf";
            this.btnGuardarPdf.Size = new System.Drawing.Size(99, 27);
            this.btnGuardarPdf.TabIndex = 6;
            this.btnGuardarPdf.Text = "Guardar PDF";
            this.btnGuardarPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPdf.UseVisualStyleBackColor = true;
            this.btnGuardarPdf.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTab1CambiaRuta);
            this.groupBox1.Controls.Add(this.txtNombreArchivo);
            this.groupBox1.Controls.Add(this.radioUnico);
            this.groupBox1.Controls.Add(this.radioVarios);
            this.groupBox1.Controls.Add(this.txtTab1Ruta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(245, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archivos de salida";
            // 
            // btnTab1CambiaRuta
            // 
            this.btnTab1CambiaRuta.Location = new System.Drawing.Point(318, 18);
            this.btnTab1CambiaRuta.Name = "btnTab1CambiaRuta";
            this.btnTab1CambiaRuta.Size = new System.Drawing.Size(24, 23);
            this.btnTab1CambiaRuta.TabIndex = 5;
            this.btnTab1CambiaRuta.Text = "...";
            this.toolTip1.SetToolTip(this.btnTab1CambiaRuta, "Cambiar carpeta de salida...");
            this.btnTab1CambiaRuta.UseVisualStyleBackColor = true;
            this.btnTab1CambiaRuta.Click += new System.EventHandler(this.btnCambiaRuta_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(130, 75);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(212, 20);
            this.txtNombreArchivo.TabIndex = 4;
            // 
            // radioUnico
            // 
            this.radioUnico.AutoSize = true;
            this.radioUnico.Checked = true;
            this.radioUnico.Location = new System.Drawing.Point(10, 79);
            this.radioUnico.Name = "radioUnico";
            this.radioUnico.Size = new System.Drawing.Size(91, 17);
            this.radioUnico.TabIndex = 3;
            this.radioUnico.TabStop = true;
            this.radioUnico.Text = "Único archivo";
            this.radioUnico.UseVisualStyleBackColor = true;
            this.radioUnico.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioVarios
            // 
            this.radioVarios.AutoSize = true;
            this.radioVarios.Location = new System.Drawing.Point(10, 53);
            this.radioVarios.Name = "radioVarios";
            this.radioVarios.Size = new System.Drawing.Size(121, 17);
            this.radioVarios.TabIndex = 2;
            this.radioVarios.Text = "Varios archivos PDF";
            this.radioVarios.UseVisualStyleBackColor = true;
            this.radioVarios.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtTab1Ruta
            // 
            this.txtTab1Ruta.Location = new System.Drawing.Point(105, 19);
            this.txtTab1Ruta.Name = "txtTab1Ruta";
            this.txtTab1Ruta.Size = new System.Drawing.Size(207, 20);
            this.txtTab1Ruta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carpeta de salida:";
            // 
            // btnTab1Abajo
            // 
            this.btnTab1Abajo.Enabled = false;
            this.btnTab1Abajo.Image = ((System.Drawing.Image)(resources.GetObject("btnTab1Abajo.Image")));
            this.btnTab1Abajo.Location = new System.Drawing.Point(195, 107);
            this.btnTab1Abajo.Name = "btnTab1Abajo";
            this.btnTab1Abajo.Size = new System.Drawing.Size(43, 26);
            this.btnTab1Abajo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnTab1Abajo, "Mover selección hacia abajo");
            this.btnTab1Abajo.UseVisualStyleBackColor = true;
            // 
            // btnTab1Arriba
            // 
            this.btnTab1Arriba.Enabled = false;
            this.btnTab1Arriba.Image = ((System.Drawing.Image)(resources.GetObject("btnTab1Arriba.Image")));
            this.btnTab1Arriba.Location = new System.Drawing.Point(195, 78);
            this.btnTab1Arriba.Name = "btnTab1Arriba";
            this.btnTab1Arriba.Size = new System.Drawing.Size(43, 26);
            this.btnTab1Arriba.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnTab1Arriba, "Mover selección hacia arriba");
            this.btnTab1Arriba.UseVisualStyleBackColor = true;
            // 
            // btnTab1Quitar
            // 
            this.btnTab1Quitar.Image = ((System.Drawing.Image)(resources.GetObject("btnTab1Quitar.Image")));
            this.btnTab1Quitar.Location = new System.Drawing.Point(195, 35);
            this.btnTab1Quitar.Name = "btnTab1Quitar";
            this.btnTab1Quitar.Size = new System.Drawing.Size(43, 26);
            this.btnTab1Quitar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnTab1Quitar, "Eliminar archivo seleccionado");
            this.btnTab1Quitar.UseVisualStyleBackColor = true;
            this.btnTab1Quitar.Click += new System.EventHandler(this.btnTab1Quitar_Click);
            // 
            // btnTab1Agregar
            // 
            this.btnTab1Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btnTab1Agregar.Image")));
            this.btnTab1Agregar.Location = new System.Drawing.Point(195, 6);
            this.btnTab1Agregar.Name = "btnTab1Agregar";
            this.btnTab1Agregar.Size = new System.Drawing.Size(43, 26);
            this.btnTab1Agregar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnTab1Agregar, "Añadir archivo");
            this.btnTab1Agregar.UseVisualStyleBackColor = true;
            this.btnTab1Agregar.Click += new System.EventHandler(this.btnTab1Agregar_Click);
            // 
            // listaImagenes
            // 
            this.listaImagenes.AllowDrop = true;
            this.listaImagenes.Location = new System.Drawing.Point(8, 6);
            this.listaImagenes.Name = "listaImagenes";
            this.listaImagenes.ShowItemToolTips = true;
            this.listaImagenes.Size = new System.Drawing.Size(181, 182);
            this.listaImagenes.TabIndex = 0;
            this.listaImagenes.UseCompatibleStateImageBehavior = false;
            this.listaImagenes.View = System.Windows.Forms.View.List;
            this.listaImagenes.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListaImagenesDragDrop);
            this.listaImagenes.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListaImagenesDragEnter);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 221);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xawan PDF Tools";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.jpgApdf.ResumeLayout(false);
            this.jpgApdf.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage jpgApdf;
        private System.Windows.Forms.ListView listaImagenes;
        private System.Windows.Forms.Button btnGuardarPdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.RadioButton radioUnico;
        private System.Windows.Forms.RadioButton radioVarios;
        private System.Windows.Forms.TextBox txtTab1Ruta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTab1Abajo;
        private System.Windows.Forms.Button btnTab1Arriba;
        private System.Windows.Forms.Button btnTab1Quitar;
        private System.Windows.Forms.Button btnTab1Agregar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnTab1CambiaRuta;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnTab1LimpiarLista;
        private System.Windows.Forms.LinkLabel linkLblAbout;
        private System.Windows.Forms.CheckBox checkTab1Abrir;
    }
}

