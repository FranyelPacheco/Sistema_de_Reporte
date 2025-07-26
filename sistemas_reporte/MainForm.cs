using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
			valor_x = 0;
			tbx_codigo.Enabled=true;
			gbx_mantenimiento.Enabled = true;
			gbx_botones.Enabled = false;
			tbx_codigo.Focus();
		}
		
		
		// Boton para cancelar ingresar datos
		void Btt_cancelarClick(object sender, EventArgs e)
		{
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
					
					
					lts_pantalla.Items.Insert(lts_pantalla.SelectedIndex,tbx_codigo.Text 
					                          + " || " + tbx_descripcion.Text + "\r\n");
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
	}
}