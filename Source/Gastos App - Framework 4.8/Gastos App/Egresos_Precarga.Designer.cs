/*
 * Creado por SharpDevelop.
 * Usuario: ZEiryu
 * Fecha: 19/7/2020
 * Hora: 20:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Gastos_App
{
	partial class Egresos_Precarga
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gb_diarios;
		private System.Windows.Forms.DateTimePicker dtp_precarga;
		private System.Windows.Forms.Panel panel_bottom;
		private System.Windows.Forms.GroupBox gb_otros;
		private System.Windows.Forms.Button bt_guardar;
		private System.Windows.Forms.ToolTip tip_guardar;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Egresos_Precarga));
			this.gb_diarios = new System.Windows.Forms.GroupBox();
			this.dtp_precarga = new System.Windows.Forms.DateTimePicker();
			this.panel_bottom = new System.Windows.Forms.Panel();
			this.gb_otros = new System.Windows.Forms.GroupBox();
			this.bt_guardar = new System.Windows.Forms.Button();
			this.tip_guardar = new System.Windows.Forms.ToolTip(this.components);
			this.panel_bottom.SuspendLayout();
			this.SuspendLayout();
			// 
			// gb_diarios
			// 
			this.gb_diarios.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
			this.gb_diarios.Location = new System.Drawing.Point(12, 12);
			this.gb_diarios.Name = "gb_diarios";
			this.gb_diarios.Size = new System.Drawing.Size(235, 36);
			this.gb_diarios.TabIndex = 0;
			this.gb_diarios.TabStop = false;
			this.gb_diarios.Text = "Egresos diarios";
			// 
			// dtp_precarga
			// 
			this.dtp_precarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.dtp_precarga.Enabled = false;
			this.dtp_precarga.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
			this.dtp_precarga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_precarga.Location = new System.Drawing.Point(101, 2);
			this.dtp_precarga.Name = "dtp_precarga";
			this.dtp_precarga.Size = new System.Drawing.Size(149, 20);
			this.dtp_precarga.TabIndex = 0;
			this.dtp_precarga.Value = new System.DateTime(2020, 7, 15, 0, 29, 0, 0);
			// 
			// panel_bottom
			// 
			this.panel_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel_bottom.Controls.Add(this.dtp_precarga);
			this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel_bottom.Location = new System.Drawing.Point(0, 125);
			this.panel_bottom.Name = "panel_bottom";
			this.panel_bottom.Size = new System.Drawing.Size(256, 28);
			this.panel_bottom.TabIndex = 6;
			// 
			// gb_otros
			// 
			this.gb_otros.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
			this.gb_otros.Location = new System.Drawing.Point(12, 54);
			this.gb_otros.Name = "gb_otros";
			this.gb_otros.Size = new System.Drawing.Size(235, 36);
			this.gb_otros.TabIndex = 1;
			this.gb_otros.TabStop = false;
			this.gb_otros.Text = "Otros egresos";
			// 
			// bt_guardar
			// 
			this.bt_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_guardar.BackgroundImage")));
			this.bt_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bt_guardar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
			this.bt_guardar.Location = new System.Drawing.Point(222, 96);
			this.bt_guardar.Name = "bt_guardar";
			this.bt_guardar.Size = new System.Drawing.Size(25, 25);
			this.bt_guardar.TabIndex = 12;
			this.bt_guardar.UseVisualStyleBackColor = true;
			this.bt_guardar.Click += new System.EventHandler(this.Bt_guardarClick);
			// 
			// Egresos_Precarga
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(256, 153);
			this.Controls.Add(this.bt_guardar);
			this.Controls.Add(this.gb_otros);
			this.Controls.Add(this.panel_bottom);
			this.Controls.Add(this.gb_diarios);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Egresos_Precarga";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Precarga";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Egresos_PrecargaFormClosing);
			this.panel_bottom.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
