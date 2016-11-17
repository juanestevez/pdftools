using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace XawanPDFTools
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();            
        }        

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtTab1Ruta.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.Text = "Xawan PDF Tools - Alpha 4";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreArchivo.Enabled = false;
            checkTab1Abrir.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreArchivo.Enabled = true;
            checkTab1Abrir.Enabled = true;
        }

        private void btnCambiaRuta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtTab1Ruta.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnTab1Agregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Imagen JPG (*.jpg)|*.jpg";

            DialogResult dr = open.ShowDialog();

            if (dr == DialogResult.OK)
            {
                foreach (String file in open.FileNames)
                {
                    listaImagenes.Items.Add(file);
                }

            }
            
        }

        private void btnTab1LimpiarLista_Click(object sender, EventArgs e)
        {
            listaImagenes.Items.Clear();
            txtNombreArchivo.Text = "";
        }

        private void JPGaPDF(string ruta, string nombreArchivo)
        {
            string archivo = ruta + "\\" + nombreArchivo + ".pdf";
            PdfDocument s_document = new PdfDocument();
            PdfPage page;
            s_document.Info.CreationDate = DateTime.Now;
            s_document.ViewerPreferences.FitWindow = true;
            s_document.Info.Title = nombreArchivo;
            s_document.Info.Author = "Xawan Solutions";

            if (File.Exists(archivo))
            {
                if (MessageBox.Show("El archivo ya existe. \n¿Desea sobreescribirlo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    for (int i = 0; i < listaImagenes.Items.Count; i++)
                    {
                        page = s_document.AddPage();
                        XGraphics gfx = XGraphics.FromPdfPage(page);
                        XImage image = XImage.FromFile(listaImagenes.Items[i].SubItems[0].Text);
                        page.Width = image.PixelWidth;
                        page.Height = image.PixelHeight;
                        
                        gfx.DrawImage(image, 0, 0, image.PixelWidth, image.PixelHeight);
                        gfx.Dispose();
                        image.Dispose();
                    }
                    // Save the s_document...
                    s_document.Save(archivo);

                    MessageBox.Show("Archivo guardado en: " + archivo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;

                    if (checkTab1Abrir.Checked)
                    {
                        // ...and start a viewer
                        Process.Start(archivo);
                    }
                    
                }
                else
                {
                    txtNombreArchivo.Focus();
                    txtNombreArchivo.SelectionStart = 0;
                    txtNombreArchivo.SelectionLength = txtNombreArchivo.Text.Length;
                }
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                for (int i = 0; i < listaImagenes.Items.Count; i++)
                {
                    page = s_document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XImage image = XImage.FromFile(listaImagenes.Items[i].SubItems[0].Text);
                    page.Width = image.PixelWidth;
                    page.Height = image.PixelHeight;

                    gfx.DrawImage(image, 0, 0, image.PixelWidth, image.PixelHeight);
                    gfx.Dispose();
                    image.Dispose();
                }
                // Save the s_document...
                s_document.Save(archivo);

                MessageBox.Show("Archivo guardado en: " + archivo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;

                if (checkTab1Abrir.Checked)
                {
                    // ...and start a viewer
                    Process.Start(archivo);
                }
            }          
           
        }
        
        private void JPGaPDF(string ruta)
        {   
        	foreach (ListViewItem itemLista in listaImagenes.Items)
				{
	            	string nombreArchivo = Path.GetFileNameWithoutExtension(itemLista.Text);
	            	string archivo = ruta + "\\" + nombreArchivo + ".pdf";
	            	
	            	if (File.Exists(archivo))
	            	{
	            		if(MessageBox.Show("El archivo " + archivo + " ya existe.\n¿Desea sobreescribirlo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
	            		{
	            			this.Cursor = Cursors.WaitCursor;
		            		PdfDocument s_document = new PdfDocument();
		            		PdfPage page;
		            		s_document.Info.CreationDate = DateTime.Now;
			            	s_document.ViewerPreferences.FitWindow = true;
			            	s_document.Info.Title = nombreArchivo;
			            	s_document.Info.Author = "Xawan Solutions";
			            	
			            	page = s_document.AddPage();
			            	XGraphics gfx = XGraphics.FromPdfPage(page);
			            	XImage image = XImage.FromFile(itemLista.Text);
			            	page.Width = image.PixelWidth;
			            	page.Height = image.PixelHeight;
				
			            	gfx.DrawImage(image, 0, 0, image.PixelWidth, image.PixelHeight);
			            	gfx.Dispose();
			            	image.Dispose();
			            	try 
			            	{
			            		s_document.Save(archivo);
			            		
			            	}
			            	catch (Exception e)
			            	{
			            		MessageBox.Show(e.ToString());
			            	}
			            	finally
			            	{
			            		this.Cursor = Cursors.Default;
			            	}	        
	            		}
	            	}
	            	else 
	            	{
	            		this.Cursor = Cursors.WaitCursor;
	            		PdfDocument s_document = new PdfDocument();
	            		PdfPage page;
	            		s_document.Info.CreationDate = DateTime.Now;
		            	s_document.ViewerPreferences.FitWindow = true;
		            	s_document.Info.Title = nombreArchivo;
		            	s_document.Info.Author = "Xawan Solutions";
		            	
		            	page = s_document.AddPage();
		            	XGraphics gfx = XGraphics.FromPdfPage(page);
		            	XImage image = XImage.FromFile(itemLista.Text);
		            	page.Width = image.PixelWidth;
		            	page.Height = image.PixelHeight;
			
		            	gfx.DrawImage(image, 0, 0, image.PixelWidth, image.PixelHeight);
		            	gfx.Dispose();
		            	image.Dispose();
		            	try 
		            	{
		            		s_document.Save(archivo);
		            		
		            	}
		            	catch (Exception e)
		            	{
		            		MessageBox.Show(e.ToString());
		            	}
		            	finally
		            	{
		            		this.Cursor = Cursors.Default;
		            	}	        
	            	}
	            	
	            	    	
        	}
        	if (MessageBox.Show("Operación completada.\nArchivos guardados en " + ruta + ".\n¿Desea abrir la carpeta de destino?", "Operación realizada", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        	{
        		Process.Start(ruta);
        	}
        }

        private void btnTab1Quitar_Click(object sender, EventArgs e)
        {
        	foreach (ListViewItem eachItem in listaImagenes.SelectedItems)
			{
			    listaImagenes.Items.Remove(eachItem);
			}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listaImagenes.Items.Count < 1) //Si no hay imagenes en la lista
            {
                MessageBox.Show("No hay imagenes seleccionadas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
            	if (radioUnico.Checked)
            	{
            		if (txtNombreArchivo.Text == "" || txtNombreArchivo.Text == " ")
            		{
            			MessageBox.Show("Escriba el nombre del archivo de salida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            		}
            		else
            		{
            			JPGaPDF(txtTab1Ruta.Text, txtNombreArchivo.Text);
            		}
            	}
            	else if (radioVarios.Checked)
            	{
            		JPGaPDF(txtTab1Ruta.Text);
            	}
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
        
		void ListaImagenesDragDrop(object sender, DragEventArgs e)
		{	
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] objetos = (string[])(e.Data.GetData(DataFormats.FileDrop));
				
				foreach (String archivo in objetos)
				{
					string ext = Path.GetExtension(archivo);
					if ((ext == ".jpg") || (ext == ".JPG"))
					{
						listaImagenes.Items.Add(archivo);
					}					
				}
			}
		}
		
		void ListaImagenesDragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

        /*** TAB 2 ***/

    } /*** FIN CLASE***/
}/*** FIN NAMESPACE***/
