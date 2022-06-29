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
            this.dgv_list_egre = new System.Windows.Forms.DataGridView();
            this.dtp_precarga = new System.Windows.Forms.DateTimePicker();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.gb_otros = new System.Windows.Forms.GroupBox();
            this.dgv_list_egre_otros = new System.Windows.Forms.DataGridView();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.tip_guardar = new System.Windows.Forms.ToolTip(this.components);
            this.gb_diarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_egre)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.gb_otros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_egre_otros)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_diarios
            // 
            this.gb_diarios.Controls.Add(this.dgv_list_egre);
            this.gb_diarios.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.gb_diarios.Location = new System.Drawing.Point(12, 12);
            this.gb_diarios.Name = "gb_diarios";
            this.gb_diarios.Size = new System.Drawing.Size(239, 160);
            this.gb_diarios.TabIndex = 0;
            this.gb_diarios.TabStop = false;
            this.gb_diarios.Text = "Egresos diarios";
            // 
            // dgv_list_egre
            // 
            this.dgv_list_egre.AllowUserToAddRows = false;
            this.dgv_list_egre.AllowUserToDeleteRows = false;
            this.dgv_list_egre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list_egre.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_list_egre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_list_egre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_egre.Location = new System.Drawing.Point(6, 22);
            this.dgv_list_egre.Name = "dgv_list_egre";
            this.dgv_list_egre.RowHeadersVisible = false;
            this.dgv_list_egre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_egre.Size = new System.Drawing.Size(227, 124);
            this.dgv_list_egre.TabIndex = 13;
            // 
            // dtp_precarga
            // 
            this.dtp_precarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_precarga.Enabled = false;
            this.dtp_precarga.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtp_precarga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_precarga.Location = new System.Drawing.Point(108, 2);
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
            this.panel_bottom.Location = new System.Drawing.Point(0, 378);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(263, 28);
            this.panel_bottom.TabIndex = 6;
            // 
            // gb_otros
            // 
            this.gb_otros.Controls.Add(this.dgv_list_egre_otros);
            this.gb_otros.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.gb_otros.Location = new System.Drawing.Point(12, 179);
            this.gb_otros.Name = "gb_otros";
            this.gb_otros.Size = new System.Drawing.Size(239, 163);
            this.gb_otros.TabIndex = 1;
            this.gb_otros.TabStop = false;
            this.gb_otros.Text = "Otros egresos";
            // 
            // dgv_list_egre_otros
            // 
            this.dgv_list_egre_otros.AllowUserToAddRows = false;
            this.dgv_list_egre_otros.AllowUserToDeleteRows = false;
            this.dgv_list_egre_otros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list_egre_otros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_list_egre_otros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_list_egre_otros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_egre_otros.Location = new System.Drawing.Point(6, 22);
            this.dgv_list_egre_otros.Name = "dgv_list_egre_otros";
            this.dgv_list_egre_otros.RowHeadersVisible = false;
            this.dgv_list_egre_otros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_egre_otros.Size = new System.Drawing.Size(227, 124);
            this.dgv_list_egre_otros.TabIndex = 14;
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_guardar.BackgroundImage")));
            this.bt_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_guardar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.bt_guardar.Location = new System.Drawing.Point(226, 349);
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
            this.ClientSize = new System.Drawing.Size(263, 406);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.gb_otros);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.gb_diarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(279, 445);
            this.MinimumSize = new System.Drawing.Size(279, 445);
            this.Name = "Egresos_Precarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Precarga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Egresos_PrecargaFormClosing);
            this.gb_diarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_egre)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.gb_otros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_egre_otros)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.DataGridView dgv_list_egre;
        private System.Windows.Forms.DataGridView dgv_list_egre_otros;
    }
}
