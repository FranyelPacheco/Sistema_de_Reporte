/*
 * Created by SharpDevelop.
 * User: Franyel
 * Date: 22/7/2025
 * Time: 11:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sistemas_reporte
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.gbx_mantenimiento = new System.Windows.Forms.GroupBox();
			this.btt_guardar = new System.Windows.Forms.Button();
			this.btt_cancelar = new System.Windows.Forms.Button();
			this.tbx_descripcion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbx_codigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbx_botones = new System.Windows.Forms.GroupBox();
			this.btt_salir = new System.Windows.Forms.Button();
			this.btt_reportar = new System.Windows.Forms.Button();
			this.btt_eliminar = new System.Windows.Forms.Button();
			this.btt_actualizar = new System.Windows.Forms.Button();
			this.btt_nuevo = new System.Windows.Forms.Button();
			this.lts_pantalla = new System.Windows.Forms.ListBox();
			this.gbx_mantenimiento.SuspendLayout();
			this.gbx_botones.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbx_mantenimiento
			// 
			this.gbx_mantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.gbx_mantenimiento.Controls.Add(this.btt_guardar);
			this.gbx_mantenimiento.Controls.Add(this.btt_cancelar);
			this.gbx_mantenimiento.Controls.Add(this.tbx_descripcion);
			this.gbx_mantenimiento.Controls.Add(this.label2);
			this.gbx_mantenimiento.Controls.Add(this.tbx_codigo);
			this.gbx_mantenimiento.Controls.Add(this.label1);
			this.gbx_mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbx_mantenimiento.Location = new System.Drawing.Point(47, 33);
			this.gbx_mantenimiento.Name = "gbx_mantenimiento";
			this.gbx_mantenimiento.Size = new System.Drawing.Size(309, 201);
			this.gbx_mantenimiento.TabIndex = 0;
			this.gbx_mantenimiento.TabStop = false;
			// 
			// btt_guardar
			// 
			this.btt_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btt_guardar.Location = new System.Drawing.Point(175, 153);
			this.btt_guardar.Name = "btt_guardar";
			this.btt_guardar.Size = new System.Drawing.Size(75, 23);
			this.btt_guardar.TabIndex = 5;
			this.btt_guardar.Text = "Guardar";
			this.btt_guardar.UseVisualStyleBackColor = false;
			this.btt_guardar.Click += new System.EventHandler(this.Btt_guardarClick);
			// 
			// btt_cancelar
			// 
			this.btt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btt_cancelar.Location = new System.Drawing.Point(83, 153);
			this.btt_cancelar.Name = "btt_cancelar";
			this.btt_cancelar.Size = new System.Drawing.Size(75, 23);
			this.btt_cancelar.TabIndex = 4;
			this.btt_cancelar.Text = "Cancelar";
			this.btt_cancelar.UseVisualStyleBackColor = false;
			this.btt_cancelar.Click += new System.EventHandler(this.Btt_cancelarClick);
			// 
			// tbx_descripcion
			// 
			this.tbx_descripcion.Location = new System.Drawing.Point(83, 91);
			this.tbx_descripcion.MaxLength = 30;
			this.tbx_descripcion.Name = "tbx_descripcion";
			this.tbx_descripcion.Size = new System.Drawing.Size(167, 20);
			this.tbx_descripcion.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Descripción:";
			// 
			// tbx_codigo
			// 
			this.tbx_codigo.Location = new System.Drawing.Point(83, 55);
			this.tbx_codigo.MaxLength = 5;
			this.tbx_codigo.Name = "tbx_codigo";
			this.tbx_codigo.Size = new System.Drawing.Size(100, 20);
			this.tbx_codigo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código:";
			// 
			// gbx_botones
			// 
			this.gbx_botones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.gbx_botones.Controls.Add(this.btt_salir);
			this.gbx_botones.Controls.Add(this.btt_reportar);
			this.gbx_botones.Controls.Add(this.btt_eliminar);
			this.gbx_botones.Controls.Add(this.btt_actualizar);
			this.gbx_botones.Controls.Add(this.btt_nuevo);
			this.gbx_botones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbx_botones.Location = new System.Drawing.Point(47, 262);
			this.gbx_botones.Name = "gbx_botones";
			this.gbx_botones.Size = new System.Drawing.Size(644, 126);
			this.gbx_botones.TabIndex = 7;
			this.gbx_botones.TabStop = false;
			// 
			// btt_salir
			// 
			this.btt_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btt_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btt_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btt_salir.Image = ((System.Drawing.Image)(resources.GetObject("btt_salir.Image")));
			this.btt_salir.Location = new System.Drawing.Point(527, 15);
			this.btt_salir.Name = "btt_salir";
			this.btt_salir.Size = new System.Drawing.Size(103, 98);
			this.btt_salir.TabIndex = 11;
			this.btt_salir.Text = "Salir";
			this.btt_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btt_salir.UseVisualStyleBackColor = false;
			// 
			// btt_reportar
			// 
			this.btt_reportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btt_reportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btt_reportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btt_reportar.Image = ((System.Drawing.Image)(resources.GetObject("btt_reportar.Image")));
			this.btt_reportar.Location = new System.Drawing.Point(399, 15);
			this.btt_reportar.Name = "btt_reportar";
			this.btt_reportar.Size = new System.Drawing.Size(103, 98);
			this.btt_reportar.TabIndex = 10;
			this.btt_reportar.Text = "Reportar";
			this.btt_reportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btt_reportar.UseVisualStyleBackColor = false;
			// 
			// btt_eliminar
			// 
			this.btt_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btt_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btt_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btt_eliminar.Image")));
			this.btt_eliminar.Location = new System.Drawing.Point(272, 15);
			this.btt_eliminar.Name = "btt_eliminar";
			this.btt_eliminar.Size = new System.Drawing.Size(103, 98);
			this.btt_eliminar.TabIndex = 9;
			this.btt_eliminar.Text = "Eliminar";
			this.btt_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btt_eliminar.UseVisualStyleBackColor = false;
			this.btt_eliminar.Click += new System.EventHandler(this.Btt_eliminarClick);
			// 
			// btt_actualizar
			// 
			this.btt_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btt_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btt_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btt_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btt_actualizar.Image")));
			this.btt_actualizar.Location = new System.Drawing.Point(144, 15);
			this.btt_actualizar.Name = "btt_actualizar";
			this.btt_actualizar.Size = new System.Drawing.Size(103, 98);
			this.btt_actualizar.TabIndex = 8;
			this.btt_actualizar.Text = "Actualizar";
			this.btt_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btt_actualizar.UseVisualStyleBackColor = false;
			this.btt_actualizar.Click += new System.EventHandler(this.Btt_actualizarClick);
			// 
			// btt_nuevo
			// 
			this.btt_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btt_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btt_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btt_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btt_nuevo.Image")));
			this.btt_nuevo.Location = new System.Drawing.Point(15, 15);
			this.btt_nuevo.Name = "btt_nuevo";
			this.btt_nuevo.Size = new System.Drawing.Size(103, 98);
			this.btt_nuevo.TabIndex = 7;
			this.btt_nuevo.Text = "Nuevo";
			this.btt_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btt_nuevo.UseVisualStyleBackColor = false;
			this.btt_nuevo.Click += new System.EventHandler(this.Btt_nuevoClick);
			// 
			// lts_pantalla
			// 
			this.lts_pantalla.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.lts_pantalla.FormattingEnabled = true;
			this.lts_pantalla.Location = new System.Drawing.Point(362, 33);
			this.lts_pantalla.Name = "lts_pantalla";
			this.lts_pantalla.Size = new System.Drawing.Size(329, 199);
			this.lts_pantalla.TabIndex = 8;
			this.lts_pantalla.Click += new System.EventHandler(this.Lts_pantallaClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(733, 419);
			this.Controls.Add(this.lts_pantalla);
			this.Controls.Add(this.gbx_botones);
			this.Controls.Add(this.gbx_mantenimiento);
			this.Name = "MainForm";
			this.Text = "sistemas_reporte";
			this.gbx_mantenimiento.ResumeLayout(false);
			this.gbx_mantenimiento.PerformLayout();
			this.gbx_botones.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListBox lts_pantalla;
		private System.Windows.Forms.GroupBox gbx_botones;
		private System.Windows.Forms.Button btt_salir;
		private System.Windows.Forms.Button btt_reportar;
		private System.Windows.Forms.Button btt_eliminar;
		private System.Windows.Forms.Button btt_actualizar;
		private System.Windows.Forms.Button btt_nuevo;
		private System.Windows.Forms.TextBox tbx_codigo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbx_descripcion;
		private System.Windows.Forms.Button btt_cancelar;
		private System.Windows.Forms.Button btt_guardar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbx_mantenimiento;
	}
}
