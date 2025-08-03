using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace sistemas_reporte
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			gbx_mantenimiento.Enabled = false;
		
		}
		int numero_codigo;
		int valor_x = 0;
		
		
		// Poder ingresar datos
		void Btt_nuevoClick(object sender, EventArgs e)
		{
			tbx_codigo.Text = "";
			tbx_descripcion.Text = "";
			valor_x = 0;
			tbx_codigo.Enabled=true;
			gbx_mantenimiento.Enabled = true;
			gbx_botones.Enabled = false;
			tbx_codigo.Focus();
		}
		
		
		// Boton para cancelar ingresar datos
		void Btt_cancelarClick(object sender, EventArgs e)
		{
			tbx_codigo.Text = "";
			tbx_descripcion.Text = "";
			gbx_mantenimiento.Enabled = false;
			gbx_botones.Enabled = true;
		}
		
		
		// Boton para guardar lo ingresado
		void Btt_guardarClick(object sender, EventArgs e)
		{
			// Validar si no se ingreso un n
			if (string.IsNullOrWhiteSpace(tbx_codigo.Text) || !int.TryParse(tbx_codigo.Text, out numero_codigo))
			{
				MessageBox.Show("Ingresa un número valido");
				tbx_codigo.Text="";
				tbx_codigo.Focus();
				
				return;
			}
			
			// Validara que se ingrese un número 
			if (int.TryParse(tbx_codigo.Text, out numero_codigo))
			{
				// valor nuevo
				if (valor_x == 0) 
				{
					MessageBox.Show("Ingresado correctamente");
					lts_pantalla.Items.Add(tbx_codigo.Text + " || " + tbx_descripcion.Text + "\r\n");
					tbx_codigo.Text="";
					tbx_descripcion.Text="";
					gbx_mantenimiento.Enabled=false;
					gbx_botones.Enabled=true;
					
					return;
				}
				
				// actualizar valor
				else	
				{
					MessageBox.Show("Actualizado correctamente");
					
					
					lts_pantalla.Items.Insert(lts_pantalla.SelectedIndex,tbx_codigo.Text + " || " + tbx_descripcion.Text + "\r\n");
					lts_pantalla.Items.Remove(lts_pantalla.SelectedItem);
					
					tbx_codigo.Text="";
					tbx_descripcion.Text="";
					gbx_mantenimiento.Enabled=false;
					gbx_botones.Enabled=true;
					
					return;
				}
		
			}
		}
		
		
		// Eliminar todos los datos ingresados
		void Btt_eliminarClick(object sender, EventArgs e)
		{
			lts_pantalla.Items.Remove(lts_pantalla.SelectedItem);
			tbx_codigo.Text="";
			tbx_descripcion.Text="";
			MessageBox.Show("Eliminado con exito");
			lts_pantalla.Text="";
		}
		
		
		// Actualizará el valor seleccionado
		void Btt_actualizarClick(object sender, EventArgs e)
		{
			if (lts_pantalla.SelectedItem == null)
			{
				return;
			}
			
			valor_x = 1;
			string texto_seleccionado = lts_pantalla.SelectedItem.ToString().Trim();
			int largo_del_texto = texto_seleccionado.Length;
			
			tbx_codigo.Text = texto_seleccionado.Substring(0,5);
			largo_del_texto -= 9;
			tbx_descripcion.Text = texto_seleccionado.Substring(9, largo_del_texto);
			
			gbx_botones.Enabled = false;
			gbx_mantenimiento.Enabled=true;
			tbx_codigo.Enabled=false;
			
			tbx_descripcion.Focus();
			
		}
		
		
		// Acciones cuando se toque la pantalla
		void Lts_pantallaClick(object sender, EventArgs e)
		{
			if (lts_pantalla.SelectedItem == null)
			{
				return;
			}
			
			string texto_seleccionado = lts_pantalla.SelectedItem.ToString().Trim();
			int largo_del_texto = texto_seleccionado.Length;
			
			tbx_codigo.Text = texto_seleccionado.Substring(0,5);
			largo_del_texto -= 9;
			tbx_descripcion.Text = texto_seleccionado.Substring(9, largo_del_texto);
		}


		// Generara y guardara un archivo .PDF con toda la información agregada
        private void btt_reportar_Click(object sender, EventArgs e)
        {
            
			if (lts_pantalla.Items.Count == 0)
			{
				MessageBox.Show("No hay elementos para reportar");
				return;
			}
			
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				Document documento = new Document();

				try
				{
					PdfWriter.GetInstance(documento, new FileStream(saveFileDialog.FileName, FileMode.Create));

					documento.Open();

					documento.AddTitle($"Reporte Diario {DateTime.Now.ToShortDateString()}");
					documento.AddAuthor("Sistema de Reporte FPL");

					documento.Add(new Paragraph("Elementos del Reporte", 
						FontFactory.GetFont(FontFactory.TIMES_BOLD, 18, BaseColor.Blue)));

					documento.Add(new Paragraph(" "));

					foreach (var item in lts_pantalla.Items)
					{
						documento.Add(new Paragraph($" - {item.ToString()}", 
							FontFactory.GetFont(FontFactory.TIMES_BOLD, 12)));
                    }

					MessageBox.Show("Guardado con éxito");
					
                } catch (Exception ex)
				{
					MessageBox.Show($"Error: {ex.Message}");
				}
				finally { documento.Close(); }

			}
        }
    }
}