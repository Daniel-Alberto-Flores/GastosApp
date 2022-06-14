/*
 * Creado por SharpDevelop.
 * Usuario: ZEiryu
 * Fecha: 14/7/2020
 * Hora: 01:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Gastos_App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tc_principal = new System.Windows.Forms.TabControl();
            this.tab_egresos = new System.Windows.Forms.TabPage();
            this.gb_listado_egre = new System.Windows.Forms.GroupBox();
            this.panel_otros = new System.Windows.Forms.Panel();
            this.tb_egre_sub_otros = new System.Windows.Forms.TextBox();
            this.bt_egre_diarios_otros_quitar = new System.Windows.Forms.Button();
            this.lb_egre_sub_otros = new System.Windows.Forms.Label();
            this.panel_diarios = new System.Windows.Forms.Panel();
            this.tb_egre_sub_diarios = new System.Windows.Forms.TextBox();
            this.lb_egre_sub_diarios = new System.Windows.Forms.Label();
            this.bt_egre_diarios_quitar = new System.Windows.Forms.Button();
            this.dgv_list_egre_otros = new System.Windows.Forms.DataGridView();
            this.lb_egre_otros = new System.Windows.Forms.Label();
            this.dgv_list_egre = new System.Windows.Forms.DataGridView();
            this.lb_egre_diarios = new System.Windows.Forms.Label();
            this.gb_egre_tipos = new System.Windows.Forms.GroupBox();
            this.bt_egre_tipos_cancel = new System.Windows.Forms.Button();
            this.panel_egre_tipos = new System.Windows.Forms.Panel();
            this.bt_egre_editar = new System.Windows.Forms.Button();
            this.bt_egre_tipos_quitar = new System.Windows.Forms.Button();
            this.bt_egre_nuevo = new System.Windows.Forms.Button();
            this.dgv_list_egre_tipos = new System.Windows.Forms.DataGridView();
            this.cb_egre_diario = new System.Windows.Forms.ComboBox();
            this.lb_egre_diario = new System.Windows.Forms.Label();
            this.bt_egre_tipos_guardar = new System.Windows.Forms.Button();
            this.tb_egre_new_tipo = new System.Windows.Forms.TextBox();
            this.lb_egre_tipo_nuevo = new System.Windows.Forms.Label();
            this.gb_calculadora_egre = new System.Windows.Forms.GroupBox();
            this.pb_calculadora_egre = new System.Windows.Forms.PictureBox();
            this.lb_egre_nombre = new System.Windows.Forms.Label();
            this.lb_egre = new System.Windows.Forms.Label();
            this.bt_egre_guardar = new System.Windows.Forms.Button();
            this.lb_egre_monto = new System.Windows.Forms.Label();
            this.lb_egre_valor = new System.Windows.Forms.Label();
            this.tb_egre_monto = new System.Windows.Forms.TextBox();
            this.cb_egre_operacion = new System.Windows.Forms.ComboBox();
            this.tab_ingresos = new System.Windows.Forms.TabPage();
            this.gb_listado_ingre = new System.Windows.Forms.GroupBox();
            this.panel_ingresos = new System.Windows.Forms.Panel();
            this.tb_ingre_sub = new System.Windows.Forms.TextBox();
            this.lb_ingre_sub = new System.Windows.Forms.Label();
            this.bt_ingre_quitar = new System.Windows.Forms.Button();
            this.dgv_list_ingre = new System.Windows.Forms.DataGridView();
            this.gb_ingre_tipos = new System.Windows.Forms.GroupBox();
            this.bt_ingre_tipos_cancel = new System.Windows.Forms.Button();
            this.panel_ingre_tipos = new System.Windows.Forms.Panel();
            this.bt_ingre_editar = new System.Windows.Forms.Button();
            this.bt_ingre__tipos_quitar = new System.Windows.Forms.Button();
            this.bt_ingre_nuevo = new System.Windows.Forms.Button();
            this.dgv_list_ingre_tipos = new System.Windows.Forms.DataGridView();
            this.bt_ingre_tipos_guardar = new System.Windows.Forms.Button();
            this.tb_ingre_new_tipo = new System.Windows.Forms.TextBox();
            this.lb_ingre_tipo_nuevo = new System.Windows.Forms.Label();
            this.gb_calculadora_ingre = new System.Windows.Forms.GroupBox();
            this.pb_calculadora_ingre = new System.Windows.Forms.PictureBox();
            this.lb_ingre_nombre = new System.Windows.Forms.Label();
            this.lb_ingre = new System.Windows.Forms.Label();
            this.bt_ingre_guardar = new System.Windows.Forms.Button();
            this.lb_ingre_monto = new System.Windows.Forms.Label();
            this.lb_ingre_valor = new System.Windows.Forms.Label();
            this.tb_ingre_monto = new System.Windows.Forms.TextBox();
            this.cb_ingre_operacion = new System.Windows.Forms.ComboBox();
            this.tab_notas = new System.Windows.Forms.TabPage();
            this.rtb_notas = new System.Windows.Forms.RichTextBox();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.bt_ayuda = new System.Windows.Forms.Button();
            this.tb_saldo = new System.Windows.Forms.TextBox();
            this.lb_saldo = new System.Windows.Forms.Label();
            this.dtp_principal = new System.Windows.Forms.DateTimePicker();
            this.tip_agregar = new System.Windows.Forms.ToolTip(this.components);
            this.tip_quitar = new System.Windows.Forms.ToolTip(this.components);
            this.tip_nuevo = new System.Windows.Forms.ToolTip(this.components);
            this.tip_guardar = new System.Windows.Forms.ToolTip(this.components);
            this.tip_ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.tip_editar = new System.Windows.Forms.ToolTip(this.components);
            this.tip_cancelar = new System.Windows.Forms.ToolTip(this.components);
            this.tc_principal.SuspendLayout();
            this.tab_egresos.SuspendLayout();
            this.gb_listado_egre.SuspendLayout();
            this.panel_otros.SuspendLayout();
            this.panel_diarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_egre_otros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_egre)).BeginInit();
            this.gb_egre_tipos.SuspendLayout();
            this.panel_egre_tipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_egre_tipos)).BeginInit();
            this.gb_calculadora_egre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_calculadora_egre)).BeginInit();
            this.tab_ingresos.SuspendLayout();
            this.gb_listado_ingre.SuspendLayout();
            this.panel_ingresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_ingre)).BeginInit();
            this.gb_ingre_tipos.SuspendLayout();
            this.panel_ingre_tipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_ingre_tipos)).BeginInit();
            this.gb_calculadora_ingre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_calculadora_ingre)).BeginInit();
            this.tab_notas.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_principal
            // 
            this.tc_principal.Controls.Add(this.tab_egresos);
            this.tc_principal.Controls.Add(this.tab_ingresos);
            this.tc_principal.Controls.Add(this.tab_notas);
            this.tc_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_principal.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_principal.Location = new System.Drawing.Point(0, 0);
            this.tc_principal.Name = "tc_principal";
            this.tc_principal.SelectedIndex = 0;
            this.tc_principal.Size = new System.Drawing.Size(567, 632);
            this.tc_principal.TabIndex = 1;
            this.tc_principal.SelectedIndexChanged += new System.EventHandler(this.Tc_principalSelectedIndexChanged);
            // 
            // tab_egresos
            // 
            this.tab_egresos.BackColor = System.Drawing.SystemColors.Info;
            this.tab_egresos.Controls.Add(this.gb_listado_egre);
            this.tab_egresos.Controls.Add(this.gb_egre_tipos);
            this.tab_egresos.Controls.Add(this.gb_calculadora_egre);
            this.tab_egresos.Location = new System.Drawing.Point(4, 25);
            this.tab_egresos.Name = "tab_egresos";
            this.tab_egresos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_egresos.Size = new System.Drawing.Size(559, 603);
            this.tab_egresos.TabIndex = 0;
            this.tab_egresos.Text = "Egresos";
            // 
            // gb_listado_egre
            // 
            this.gb_listado_egre.Controls.Add(this.panel_otros);
            this.gb_listado_egre.Controls.Add(this.panel_diarios);
            this.gb_listado_egre.Controls.Add(this.dgv_list_egre_otros);
            this.gb_listado_egre.Controls.Add(this.lb_egre_otros);
            this.gb_listado_egre.Controls.Add(this.dgv_list_egre);
            this.gb_listado_egre.Controls.Add(this.lb_egre_diarios);
            this.gb_listado_egre.Location = new System.Drawing.Point(3, 3);
            this.gb_listado_egre.Name = "gb_listado_egre";
            this.gb_listado_egre.Size = new System.Drawing.Size(288, 594);
            this.gb_listado_egre.TabIndex = 11;
            this.gb_listado_egre.TabStop = false;
            this.gb_listado_egre.Text = "Listado de movimientos:";
            // 
            // panel_otros
            // 
            this.panel_otros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_otros.Controls.Add(this.tb_egre_sub_otros);
            this.panel_otros.Controls.Add(this.bt_egre_diarios_otros_quitar);
            this.panel_otros.Controls.Add(this.lb_egre_sub_otros);
            this.panel_otros.Location = new System.Drawing.Point(6, 554);
            this.panel_otros.Name = "panel_otros";
            this.panel_otros.Size = new System.Drawing.Size(272, 34);
            this.panel_otros.TabIndex = 13;
            // 
            // tb_egre_sub_otros
            // 
            this.tb_egre_sub_otros.Location = new System.Drawing.Point(94, 5);
            this.tb_egre_sub_otros.Name = "tb_egre_sub_otros";
            this.tb_egre_sub_otros.ReadOnly = true;
            this.tb_egre_sub_otros.Size = new System.Drawing.Size(100, 23);
            this.tb_egre_sub_otros.TabIndex = 12;
            // 
            // bt_egre_diarios_otros_quitar
            // 
            this.bt_egre_diarios_otros_quitar.BackColor = System.Drawing.Color.Transparent;
            this.bt_egre_diarios_otros_quitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_egre_diarios_otros_quitar.BackgroundImage")));
            this.bt_egre_diarios_otros_quitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_egre_diarios_otros_quitar.Location = new System.Drawing.Point(239, 2);
            this.bt_egre_diarios_otros_quitar.Name = "bt_egre_diarios_otros_quitar";
            this.bt_egre_diarios_otros_quitar.Size = new System.Drawing.Size(30, 30);
            this.bt_egre_diarios_otros_quitar.TabIndex = 9;
            this.bt_egre_diarios_otros_quitar.UseVisualStyleBackColor = false;
            this.bt_egre_diarios_otros_quitar.Click += new System.EventHandler(this.Bt_egre_diarios_otros_quitarClick);
            // 
            // lb_egre_sub_otros
            // 
            this.lb_egre_sub_otros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_egre_sub_otros.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_egre_sub_otros.Location = new System.Drawing.Point(8, 8);
            this.lb_egre_sub_otros.Name = "lb_egre_sub_otros";
            this.lb_egre_sub_otros.Size = new System.Drawing.Size(80, 15);
            this.lb_egre_sub_otros.TabIndex = 11;
            this.lb_egre_sub_otros.Text = "Subtotal:";
            // 
            // panel_diarios
            // 
            this.panel_diarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_diarios.Controls.Add(this.tb_egre_sub_diarios);
            this.panel_diarios.Controls.Add(this.lb_egre_sub_diarios);
            this.panel_diarios.Controls.Add(this.bt_egre_diarios_quitar);
            this.panel_diarios.Location = new System.Drawing.Point(6, 214);
            this.panel_diarios.Name = "panel_diarios";
            this.panel_diarios.Size = new System.Drawing.Size(272, 34);
            this.panel_diarios.TabIndex = 12;
            // 
            // tb_egre_sub_diarios
            // 
            this.tb_egre_sub_diarios.Location = new System.Drawing.Point(94, 5);
            this.tb_egre_sub_diarios.Name = "tb_egre_sub_diarios";
            this.tb_egre_sub_diarios.ReadOnly = true;
            this.tb_egre_sub_diarios.Size = new System.Drawing.Size(100, 23);
            this.tb_egre_sub_diarios.TabIndex = 10;
            // 
            // lb_egre_sub_diarios
            // 
            this.lb_egre_sub_diarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_egre_sub_diarios.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_egre_sub_diarios.Location = new System.Drawing.Point(8, 8);
            this.lb_egre_sub_diarios.Name = "lb_egre_sub_diarios";
            this.lb_egre_sub_diarios.Size = new System.Drawing.Size(80, 15);
            this.lb_egre_sub_diarios.TabIndex = 9;
            this.lb_egre_sub_diarios.Text = "Subtotal:";
            // 
            // bt_egre_diarios_quitar
            // 
            this.bt_egre_diarios_quitar.BackColor = System.Drawing.Color.Transparent;
            this.bt_egre_diarios_quitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_egre_diarios_quitar.BackgroundImage")));
            this.bt_egre_diarios_quitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_egre_diarios_quitar.Location = new System.Drawing.Point(239, 1);
            this.bt_egre_diarios_quitar.Name = "bt_egre_diarios_quitar";
            this.bt_egre_diarios_quitar.Size = new System.Drawing.Size(30, 30);
            this.bt_egre_diarios_quitar.TabIndex = 8;
            this.bt_egre_diarios_quitar.UseVisualStyleBackColor = false;
            this.bt_egre_diarios_quitar.Click += new System.EventHandler(this.Bt_egre_diarios_quitarClick);
            // 
            // dgv_list_egre_otros
            // 
            this.dgv_list_egre_otros.AllowUserToAddRows = false;
            this.dgv_list_egre_otros.AllowUserToDeleteRows = false;
            this.dgv_list_egre_otros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_list_egre_otros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_list_egre_otros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_list_egre_otros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_egre_otros.Location = new System.Drawing.Point(6, 268);
            this.dgv_list_egre_otros.Name = "dgv_list_egre_otros";
            this.dgv_list_egre_otros.ReadOnly = true;
            this.dgv_list_egre_otros.RowHeadersVisible = false;
            this.dgv_list_egre_otros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_egre_otros.Size = new System.Drawing.Size(272, 286);
            this.dgv_list_egre_otros.TabIndex = 11;
            this.dgv_list_egre_otros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_list_egre_otrosCellClick);
            this.dgv_list_egre_otros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_list_egre_otrosCellDoubleClick);
            // 
            // lb_egre_otros
            // 
            this.lb_egre_otros.Location = new System.Drawing.Point(14, 251);
            this.lb_egre_otros.Name = "lb_egre_otros";
            this.lb_egre_otros.Size = new System.Drawing.Size(60, 14);
            this.lb_egre_otros.TabIndex = 10;
            this.lb_egre_otros.Text = "Otros:";
            // 
            // dgv_list_egre
            // 
            this.dgv_list_egre.AllowUserToAddRows = false;
            this.dgv_list_egre.AllowUserToDeleteRows = false;
            this.dgv_list_egre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_list_egre.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_list_egre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_list_egre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_egre.Location = new System.Drawing.Point(6, 35);
            this.dgv_list_egre.Name = "dgv_list_egre";
            this.dgv_list_egre.ReadOnly = true;
            this.dgv_list_egre.RowHeadersVisible = false;
            this.dgv_list_egre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_egre.Size = new System.Drawing.Size(272, 179);
            this.dgv_list_egre.TabIndex = 0;
            this.dgv_list_egre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_list_egreCellClick);
            this.dgv_list_egre.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_list_egre_dia_CellDoubleClick);
            // 
            // lb_egre_diarios
            // 
            this.lb_egre_diarios.Location = new System.Drawing.Point(14, 18);
            this.lb_egre_diarios.Name = "lb_egre_diarios";
            this.lb_egre_diarios.Size = new System.Drawing.Size(80, 14);
            this.lb_egre_diarios.TabIndex = 8;
            this.lb_egre_diarios.Text = "Diarios:";
            // 
            // gb_egre_tipos
            // 
            this.gb_egre_tipos.Controls.Add(this.bt_egre_tipos_cancel);
            this.gb_egre_tipos.Controls.Add(this.panel_egre_tipos);
            this.gb_egre_tipos.Controls.Add(this.dgv_list_egre_tipos);
            this.gb_egre_tipos.Controls.Add(this.cb_egre_diario);
            this.gb_egre_tipos.Controls.Add(this.lb_egre_diario);
            this.gb_egre_tipos.Controls.Add(this.bt_egre_tipos_guardar);
            this.gb_egre_tipos.Controls.Add(this.tb_egre_new_tipo);
            this.gb_egre_tipos.Controls.Add(this.lb_egre_tipo_nuevo);
            this.gb_egre_tipos.Location = new System.Drawing.Point(296, 115);
            this.gb_egre_tipos.Name = "gb_egre_tipos";
            this.gb_egre_tipos.Size = new System.Drawing.Size(258, 482);
            this.gb_egre_tipos.TabIndex = 7;
            this.gb_egre_tipos.TabStop = false;
            this.gb_egre_tipos.Text = "Agregar tipos de gastos:";
            // 
            // bt_egre_tipos_cancel
            // 
            this.bt_egre_tipos_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_egre_tipos_cancel.BackgroundImage")));
            this.bt_egre_tipos_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_egre_tipos_cancel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.bt_egre_tipos_cancel.Location = new System.Drawing.Point(158, 450);
            this.bt_egre_tipos_cancel.Name = "bt_egre_tipos_cancel";
            this.bt_egre_tipos_cancel.Size = new System.Drawing.Size(25, 25);
            this.bt_egre_tipos_cancel.TabIndex = 14;
            this.bt_egre_tipos_cancel.UseVisualStyleBackColor = true;
            this.bt_egre_tipos_cancel.Click += new System.EventHandler(this.Bt_egre_tipos_cancelClick);
            // 
            // panel_egre_tipos
            // 
            this.panel_egre_tipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_egre_tipos.Controls.Add(this.bt_egre_editar);
            this.panel_egre_tipos.Controls.Add(this.bt_egre_tipos_quitar);
            this.panel_egre_tipos.Controls.Add(this.bt_egre_nuevo);
            this.panel_egre_tipos.Location = new System.Drawing.Point(6, 380);
            this.panel_egre_tipos.Name = "panel_egre_tipos";
            this.panel_egre_tipos.Size = new System.Drawing.Size(243, 34);
            this.panel_egre_tipos.TabIndex = 13;
            // 
            // bt_egre_editar
            // 
            this.bt_egre_editar.BackColor = System.Drawing.Color.Transparent;
            this.bt_egre_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_egre_editar.BackgroundImage")));
            this.bt_egre_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_egre_editar.Location = new System.Drawing.Point(146, 2);
            this.bt_egre_editar.Name = "bt_egre_editar";
            this.bt_egre_editar.Size = new System.Drawing.Size(30, 30);
            this.bt_egre_editar.TabIndex = 8;
            this.bt_egre_editar.UseVisualStyleBackColor = false;
            this.bt_egre_editar.Click += new System.EventHandler(this.Bt_egre_editarClick);
            // 
            // bt_egre_tipos_quitar
            // 
            this.bt_egre_tipos_quitar.BackColor = System.Drawing.Color.Transparent;
            this.bt_egre_tipos_quitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_egre_tipos_quitar.BackgroundImage")));
            this.bt_egre_tipos_quitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_egre_tipos_quitar.Location = new System.Drawing.Point(178, 2);
            this.bt_egre_tipos_quitar.Name = "bt_egre_tipos_quitar";
            this.bt_egre_tipos_quitar.Size = new System.Drawing.Size(30, 30);
            this.bt_egre_tipos_quitar.TabIndex = 6;
            this.bt_egre_tipos_quitar.UseVisualStyleBackColor = false;
            this.bt_egre_tipos_quitar.Click += new System.EventHandler(this.Bt_egre__tipos_quitarClick);
            // 
            // bt_egre_nuevo
            // 
            this.bt_egre_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_egre_nuevo.BackgroundImage")));
            this.bt_egre_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_egre_nuevo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.bt_egre_nuevo.Location = new System.Drawing.Point(210, 2);
            this.bt_egre_nuevo.Name = "bt_egre_nuevo";
            this.bt_egre_nuevo.Size = new System.Drawing.Size(30, 30);
            this.bt_egre_nuevo.TabIndex = 7;
            this.bt_egre_nuevo.UseVisualStyleBackColor = true;
            this.bt_egre_nuevo.Click += new System.EventHandler(this.Bt_egre_nuevoClick);
            // 
            // dgv_list_egre_tipos
            // 
            this.dgv_list_egre_tipos.AllowUserToAddRows = false;
            this.dgv_list_egre_tipos.AllowUserToDeleteRows = false;
            this.dgv_list_egre_tipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_list_egre_tipos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_list_egre_tipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_list_egre_tipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_egre_tipos.Location = new System.Drawing.Point(6, 22);
            this.dgv_list_egre_tipos.Name = "dgv_list_egre_tipos";
            this.dgv_list_egre_tipos.ReadOnly = true;
            this.dgv_list_egre_tipos.RowHeadersVisible = false;
            this.dgv_list_egre_tipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_egre_tipos.Size = new System.Drawing.Size(243, 358);
            this.dgv_list_egre_tipos.TabIndex = 12;
            this.dgv_list_egre_tipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_egre_tiposCellClick);
            this.dgv_list_egre_tipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_egre_tiposDoubleClick);
            // 
            // cb_egre_diario
            // 
            this.cb_egre_diario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_egre_diario.FormattingEnabled = true;
            this.cb_egre_diario.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cb_egre_diario.Location = new System.Drawing.Point(78, 451);
            this.cb_egre_diario.Name = "cb_egre_diario";
            this.cb_egre_diario.Size = new System.Drawing.Size(40, 24);
            this.cb_egre_diario.TabIndex = 12;
            // 
            // lb_egre_diario
            // 
            this.lb_egre_diario.Location = new System.Drawing.Point(10, 454);
            this.lb_egre_diario.Name = "lb_egre_diario";
            this.lb_egre_diario.Size = new System.Drawing.Size(64, 17);
            this.lb_egre_diario.TabIndex = 11;
            this.lb_egre_diario.Text = "Diario:";
            // 
            // bt_egre_tipos_guardar
            // 
            this.bt_egre_tipos_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_egre_tipos_guardar.BackgroundImage")));
            this.bt_egre_tipos_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_egre_tipos_guardar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.bt_egre_tipos_guardar.Location = new System.Drawing.Point(188, 450);
            this.bt_egre_tipos_guardar.Name = "bt_egre_tipos_guardar";
            this.bt_egre_tipos_guardar.Size = new System.Drawing.Size(25, 25);
            this.bt_egre_tipos_guardar.TabIndex = 10;
            this.bt_egre_tipos_guardar.UseVisualStyleBackColor = true;
            this.bt_egre_tipos_guardar.Click += new System.EventHandler(this.Bt_egre_tipos_guardarClick);
            // 
            // tb_egre_new_tipo
            // 
            this.tb_egre_new_tipo.Location = new System.Drawing.Point(78, 424);
            this.tb_egre_new_tipo.Name = "tb_egre_new_tipo";
            this.tb_egre_new_tipo.Size = new System.Drawing.Size(135, 23);
            this.tb_egre_new_tipo.TabIndex = 9;
            // 
            // lb_egre_tipo_nuevo
            // 
            this.lb_egre_tipo_nuevo.Location = new System.Drawing.Point(10, 427);
            this.lb_egre_tipo_nuevo.Name = "lb_egre_tipo_nuevo";
            this.lb_egre_tipo_nuevo.Size = new System.Drawing.Size(74, 17);
            this.lb_egre_tipo_nuevo.TabIndex = 8;
            this.lb_egre_tipo_nuevo.Text = "Nombre:";
            // 
            // gb_calculadora_egre
            // 
            this.gb_calculadora_egre.Controls.Add(this.pb_calculadora_egre);
            this.gb_calculadora_egre.Controls.Add(this.lb_egre_nombre);
            this.gb_calculadora_egre.Controls.Add(this.lb_egre);
            this.gb_calculadora_egre.Controls.Add(this.bt_egre_guardar);
            this.gb_calculadora_egre.Controls.Add(this.lb_egre_monto);
            this.gb_calculadora_egre.Controls.Add(this.lb_egre_valor);
            this.gb_calculadora_egre.Controls.Add(this.tb_egre_monto);
            this.gb_calculadora_egre.Controls.Add(this.cb_egre_operacion);
            this.gb_calculadora_egre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gb_calculadora_egre.Location = new System.Drawing.Point(296, 3);
            this.gb_calculadora_egre.Name = "gb_calculadora_egre";
            this.gb_calculadora_egre.Size = new System.Drawing.Size(258, 106);
            this.gb_calculadora_egre.TabIndex = 6;
            this.gb_calculadora_egre.TabStop = false;
            this.gb_calculadora_egre.Text = "Calculadora";
            // 
            // pb_calculadora_egre
            // 
            this.pb_calculadora_egre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_calculadora_egre.BackgroundImage")));
            this.pb_calculadora_egre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_calculadora_egre.Location = new System.Drawing.Point(6, 18);
            this.pb_calculadora_egre.Name = "pb_calculadora_egre";
            this.pb_calculadora_egre.Size = new System.Drawing.Size(30, 30);
            this.pb_calculadora_egre.TabIndex = 14;
            this.pb_calculadora_egre.TabStop = false;
            // 
            // lb_egre_nombre
            // 
            this.lb_egre_nombre.AutoSize = true;
            this.lb_egre_nombre.Location = new System.Drawing.Point(127, 26);
            this.lb_egre_nombre.Name = "lb_egre_nombre";
            this.lb_egre_nombre.Size = new System.Drawing.Size(55, 16);
            this.lb_egre_nombre.TabIndex = 13;
            this.lb_egre_nombre.Text = "Nombre";
            // 
            // lb_egre
            // 
            this.lb_egre.Location = new System.Drawing.Point(57, 26);
            this.lb_egre.Name = "lb_egre";
            this.lb_egre.Size = new System.Drawing.Size(65, 19);
            this.lb_egre.TabIndex = 12;
            this.lb_egre.Text = "Egreso:";
            // 
            // bt_egre_guardar
            // 
            this.bt_egre_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_egre_guardar.BackgroundImage")));
            this.bt_egre_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_egre_guardar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.bt_egre_guardar.Location = new System.Drawing.Point(188, 70);
            this.bt_egre_guardar.Name = "bt_egre_guardar";
            this.bt_egre_guardar.Size = new System.Drawing.Size(25, 25);
            this.bt_egre_guardar.TabIndex = 11;
            this.bt_egre_guardar.UseVisualStyleBackColor = true;
            this.bt_egre_guardar.Click += new System.EventHandler(this.Bt_egre_guardarClick);
            // 
            // lb_egre_monto
            // 
            this.lb_egre_monto.Location = new System.Drawing.Point(34, 49);
            this.lb_egre_monto.Name = "lb_egre_monto";
            this.lb_egre_monto.Size = new System.Drawing.Size(88, 19);
            this.lb_egre_monto.TabIndex = 1;
            this.lb_egre_monto.Text = "Monto ($):";
            // 
            // lb_egre_valor
            // 
            this.lb_egre_valor.AutoSize = true;
            this.lb_egre_valor.Location = new System.Drawing.Point(131, 48);
            this.lb_egre_valor.Name = "lb_egre_valor";
            this.lb_egre_valor.Size = new System.Drawing.Size(47, 16);
            this.lb_egre_valor.TabIndex = 2;
            this.lb_egre_valor.Text = "Valor";
            // 
            // tb_egre_monto
            // 
            this.tb_egre_monto.BackColor = System.Drawing.SystemColors.Window;
            this.tb_egre_monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_egre_monto.Enabled = false;
            this.tb_egre_monto.Location = new System.Drawing.Point(127, 71);
            this.tb_egre_monto.Name = "tb_egre_monto";
            this.tb_egre_monto.Size = new System.Drawing.Size(55, 23);
            this.tb_egre_monto.TabIndex = 4;
            this.tb_egre_monto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_egre_montoKeyDown);
            this.tb_egre_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_egre_montoKeyPress);
            // 
            // cb_egre_operacion
            // 
            this.cb_egre_operacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_egre_operacion.FormattingEnabled = true;
            this.cb_egre_operacion.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cb_egre_operacion.Location = new System.Drawing.Point(84, 70);
            this.cb_egre_operacion.Name = "cb_egre_operacion";
            this.cb_egre_operacion.Size = new System.Drawing.Size(34, 24);
            this.cb_egre_operacion.TabIndex = 3;
            // 
            // tab_ingresos
            // 
            this.tab_ingresos.BackColor = System.Drawing.SystemColors.Info;
            this.tab_ingresos.Controls.Add(this.gb_listado_ingre);
            this.tab_ingresos.Controls.Add(this.gb_ingre_tipos);
            this.tab_ingresos.Controls.Add(this.gb_calculadora_ingre);
            this.tab_ingresos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tab_ingresos.Location = new System.Drawing.Point(4, 25);
            this.tab_ingresos.Name = "tab_ingresos";
            this.tab_ingresos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ingresos.Size = new System.Drawing.Size(559, 603);
            this.tab_ingresos.TabIndex = 1;
            this.tab_ingresos.Text = "Ingresos";
            // 
            // gb_listado_ingre
            // 
            this.gb_listado_ingre.Controls.Add(this.panel_ingresos);
            this.gb_listado_ingre.Controls.Add(this.dgv_list_ingre);
            this.gb_listado_ingre.Location = new System.Drawing.Point(4, 4);
            this.gb_listado_ingre.Name = "gb_listado_ingre";
            this.gb_listado_ingre.Size = new System.Drawing.Size(288, 594);
            this.gb_listado_ingre.TabIndex = 14;
            this.gb_listado_ingre.TabStop = false;
            this.gb_listado_ingre.Text = "Listado de ingresos:";
            // 
            // panel_ingresos
            // 
            this.panel_ingresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_ingresos.Controls.Add(this.tb_ingre_sub);
            this.panel_ingresos.Controls.Add(this.lb_ingre_sub);
            this.panel_ingresos.Controls.Add(this.bt_ingre_quitar);
            this.panel_ingresos.Location = new System.Drawing.Point(6, 554);
            this.panel_ingresos.Name = "panel_ingresos";
            this.panel_ingresos.Size = new System.Drawing.Size(272, 34);
            this.panel_ingresos.TabIndex = 13;
            // 
            // tb_ingre_sub
            // 
            this.tb_ingre_sub.Location = new System.Drawing.Point(94, 5);
            this.tb_ingre_sub.Name = "tb_ingre_sub";
            this.tb_ingre_sub.ReadOnly = true;
            this.tb_ingre_sub.Size = new System.Drawing.Size(100, 23);
            this.tb_ingre_sub.TabIndex = 12;
            // 
            // lb_ingre_sub
            // 
            this.lb_ingre_sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_ingre_sub.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_ingre_sub.Location = new System.Drawing.Point(8, 8);
            this.lb_ingre_sub.Name = "lb_ingre_sub";
            this.lb_ingre_sub.Size = new System.Drawing.Size(80, 15);
            this.lb_ingre_sub.TabIndex = 11;
            this.lb_ingre_sub.Text = "Subtotal:";
            // 
            // bt_ingre_quitar
            // 
            this.bt_ingre_quitar.BackColor = System.Drawing.Color.Transparent;
            this.bt_ingre_quitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_ingre_quitar.BackgroundImage")));
            this.bt_ingre_quitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ingre_quitar.Location = new System.Drawing.Point(239, 1);
            this.bt_ingre_quitar.Name = "bt_ingre_quitar";
            this.bt_ingre_quitar.Size = new System.Drawing.Size(30, 30);
            this.bt_ingre_quitar.TabIndex = 8;
            this.bt_ingre_quitar.UseVisualStyleBackColor = false;
            this.bt_ingre_quitar.Click += new System.EventHandler(this.Bt_ingre_quitarClick);
            // 
            // dgv_list_ingre
            // 
            this.dgv_list_ingre.AllowUserToAddRows = false;
            this.dgv_list_ingre.AllowUserToDeleteRows = false;
            this.dgv_list_ingre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_list_ingre.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_list_ingre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_list_ingre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_ingre.Location = new System.Drawing.Point(6, 35);
            this.dgv_list_ingre.Name = "dgv_list_ingre";
            this.dgv_list_ingre.ReadOnly = true;
            this.dgv_list_ingre.RowHeadersVisible = false;
            this.dgv_list_ingre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_ingre.Size = new System.Drawing.Size(272, 519);
            this.dgv_list_ingre.TabIndex = 0;
            this.dgv_list_ingre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_list_ingre_CellClick);
            this.dgv_list_ingre.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_list_ingreCellDoubleClick);
            // 
            // gb_ingre_tipos
            // 
            this.gb_ingre_tipos.Controls.Add(this.bt_ingre_tipos_cancel);
            this.gb_ingre_tipos.Controls.Add(this.panel_ingre_tipos);
            this.gb_ingre_tipos.Controls.Add(this.dgv_list_ingre_tipos);
            this.gb_ingre_tipos.Controls.Add(this.bt_ingre_tipos_guardar);
            this.gb_ingre_tipos.Controls.Add(this.tb_ingre_new_tipo);
            this.gb_ingre_tipos.Controls.Add(this.lb_ingre_tipo_nuevo);
            this.gb_ingre_tipos.Location = new System.Drawing.Point(297, 116);
            this.gb_ingre_tipos.Name = "gb_ingre_tipos";
            this.gb_ingre_tipos.Size = new System.Drawing.Size(258, 481);
            this.gb_ingre_tipos.TabIndex = 13;
            this.gb_ingre_tipos.TabStop = false;
            this.gb_ingre_tipos.Text = "Agregar tipos de ingresos:";
            // 
            // bt_ingre_tipos_cancel
            // 
            this.bt_ingre_tipos_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_ingre_tipos_cancel.BackgroundImage")));
            this.bt_ingre_tipos_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ingre_tipos_cancel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.bt_ingre_tipos_cancel.Location = new System.Drawing.Point(188, 451);
            this.bt_ingre_tipos_cancel.Name = "bt_ingre_tipos_cancel";
            this.bt_ingre_tipos_cancel.Size = new System.Drawing.Size(25, 25);
            this.bt_ingre_tipos_cancel.TabIndex = 15;
            this.bt_ingre_tipos_cancel.UseVisualStyleBackColor = true;
            this.bt_ingre_tipos_cancel.Click += new System.EventHandler(this.bt_ingre_tipos_cancelClick);
            // 
            // panel_ingre_tipos
            // 
            this.panel_ingre_tipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_ingre_tipos.Controls.Add(this.bt_ingre_editar);
            this.panel_ingre_tipos.Controls.Add(this.bt_ingre__tipos_quitar);
            this.panel_ingre_tipos.Controls.Add(this.bt_ingre_nuevo);
            this.panel_ingre_tipos.Location = new System.Drawing.Point(6, 408);
            this.panel_ingre_tipos.Name = "panel_ingre_tipos";
            this.panel_ingre_tipos.Size = new System.Drawing.Size(243, 34);
            this.panel_ingre_tipos.TabIndex = 13;
            // 
            // bt_ingre_editar
            // 
            this.bt_ingre_editar.BackColor = System.Drawing.Color.Transparent;
            this.bt_ingre_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_ingre_editar.BackgroundImage")));
            this.bt_ingre_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ingre_editar.Location = new System.Drawing.Point(146, 2);
            this.bt_ingre_editar.Name = "bt_ingre_editar";
            this.bt_ingre_editar.Size = new System.Drawing.Size(30, 30);
            this.bt_ingre_editar.TabIndex = 9;
            this.bt_ingre_editar.UseVisualStyleBackColor = false;
            this.bt_ingre_editar.Click += new System.EventHandler(this.Bt_ingre_editarClick);
            // 
            // bt_ingre__tipos_quitar
            // 
            this.bt_ingre__tipos_quitar.BackColor = System.Drawing.Color.Transparent;
            this.bt_ingre__tipos_quitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_ingre__tipos_quitar.BackgroundImage")));
            this.bt_ingre__tipos_quitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ingre__tipos_quitar.Location = new System.Drawing.Point(178, 2);
            this.bt_ingre__tipos_quitar.Name = "bt_ingre__tipos_quitar";
            this.bt_ingre__tipos_quitar.Size = new System.Drawing.Size(30, 30);
            this.bt_ingre__tipos_quitar.TabIndex = 6;
            this.bt_ingre__tipos_quitar.UseVisualStyleBackColor = false;
            this.bt_ingre__tipos_quitar.Click += new System.EventHandler(this.bt_ingre__tipos_quitarClick);
            // 
            // bt_ingre_nuevo
            // 
            this.bt_ingre_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_ingre_nuevo.BackgroundImage")));
            this.bt_ingre_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ingre_nuevo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.bt_ingre_nuevo.Location = new System.Drawing.Point(210, 2);
            this.bt_ingre_nuevo.Name = "bt_ingre_nuevo";
            this.bt_ingre_nuevo.Size = new System.Drawing.Size(30, 30);
            this.bt_ingre_nuevo.TabIndex = 7;
            this.bt_ingre_nuevo.UseVisualStyleBackColor = true;
            this.bt_ingre_nuevo.Click += new System.EventHandler(this.Bt_ingre_nuevoClick);
            // 
            // dgv_list_ingre_tipos
            // 
            this.dgv_list_ingre_tipos.AllowUserToAddRows = false;
            this.dgv_list_ingre_tipos.AllowUserToDeleteRows = false;
            this.dgv_list_ingre_tipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_list_ingre_tipos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_list_ingre_tipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_list_ingre_tipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_ingre_tipos.Location = new System.Drawing.Point(6, 22);
            this.dgv_list_ingre_tipos.Name = "dgv_list_ingre_tipos";
            this.dgv_list_ingre_tipos.ReadOnly = true;
            this.dgv_list_ingre_tipos.RowHeadersVisible = false;
            this.dgv_list_ingre_tipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_ingre_tipos.Size = new System.Drawing.Size(243, 386);
            this.dgv_list_ingre_tipos.TabIndex = 12;
            this.dgv_list_ingre_tipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_list_ingre_tiposCellClick);
            this.dgv_list_ingre_tipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_list_ingre_tiposCellDoubleClick);
            // 
            // bt_ingre_tipos_guardar
            // 
            this.bt_ingre_tipos_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_ingre_tipos_guardar.BackgroundImage")));
            this.bt_ingre_tipos_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ingre_tipos_guardar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.bt_ingre_tipos_guardar.Location = new System.Drawing.Point(216, 451);
            this.bt_ingre_tipos_guardar.Name = "bt_ingre_tipos_guardar";
            this.bt_ingre_tipos_guardar.Size = new System.Drawing.Size(25, 25);
            this.bt_ingre_tipos_guardar.TabIndex = 10;
            this.bt_ingre_tipos_guardar.UseVisualStyleBackColor = true;
            this.bt_ingre_tipos_guardar.Click += new System.EventHandler(this.Bt_ingre_tipos_guardarClick);
            // 
            // tb_ingre_new_tipo
            // 
            this.tb_ingre_new_tipo.Location = new System.Drawing.Point(78, 452);
            this.tb_ingre_new_tipo.Name = "tb_ingre_new_tipo";
            this.tb_ingre_new_tipo.Size = new System.Drawing.Size(104, 23);
            this.tb_ingre_new_tipo.TabIndex = 9;
            // 
            // lb_ingre_tipo_nuevo
            // 
            this.lb_ingre_tipo_nuevo.Location = new System.Drawing.Point(10, 455);
            this.lb_ingre_tipo_nuevo.Name = "lb_ingre_tipo_nuevo";
            this.lb_ingre_tipo_nuevo.Size = new System.Drawing.Size(74, 17);
            this.lb_ingre_tipo_nuevo.TabIndex = 8;
            this.lb_ingre_tipo_nuevo.Text = "Nombre:";
            // 
            // gb_calculadora_ingre
            // 
            this.gb_calculadora_ingre.Controls.Add(this.pb_calculadora_ingre);
            this.gb_calculadora_ingre.Controls.Add(this.lb_ingre_nombre);
            this.gb_calculadora_ingre.Controls.Add(this.lb_ingre);
            this.gb_calculadora_ingre.Controls.Add(this.bt_ingre_guardar);
            this.gb_calculadora_ingre.Controls.Add(this.lb_ingre_monto);
            this.gb_calculadora_ingre.Controls.Add(this.lb_ingre_valor);
            this.gb_calculadora_ingre.Controls.Add(this.tb_ingre_monto);
            this.gb_calculadora_ingre.Controls.Add(this.cb_ingre_operacion);
            this.gb_calculadora_ingre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gb_calculadora_ingre.Location = new System.Drawing.Point(297, 4);
            this.gb_calculadora_ingre.Name = "gb_calculadora_ingre";
            this.gb_calculadora_ingre.Size = new System.Drawing.Size(258, 106);
            this.gb_calculadora_ingre.TabIndex = 12;
            this.gb_calculadora_ingre.TabStop = false;
            this.gb_calculadora_ingre.Text = "Calculadora";
            // 
            // pb_calculadora_ingre
            // 
            this.pb_calculadora_ingre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_calculadora_ingre.BackgroundImage")));
            this.pb_calculadora_ingre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_calculadora_ingre.Location = new System.Drawing.Point(6, 18);
            this.pb_calculadora_ingre.Name = "pb_calculadora_ingre";
            this.pb_calculadora_ingre.Size = new System.Drawing.Size(30, 30);
            this.pb_calculadora_ingre.TabIndex = 14;
            this.pb_calculadora_ingre.TabStop = false;
            // 
            // lb_ingre_nombre
            // 
            this.lb_ingre_nombre.AutoSize = true;
            this.lb_ingre_nombre.Location = new System.Drawing.Point(127, 26);
            this.lb_ingre_nombre.Name = "lb_ingre_nombre";
            this.lb_ingre_nombre.Size = new System.Drawing.Size(55, 16);
            this.lb_ingre_nombre.TabIndex = 13;
            this.lb_ingre_nombre.Text = "Nombre";
            // 
            // lb_ingre
            // 
            this.lb_ingre.Location = new System.Drawing.Point(50, 26);
            this.lb_ingre.Name = "lb_ingre";
            this.lb_ingre.Size = new System.Drawing.Size(77, 19);
            this.lb_ingre.TabIndex = 12;
            this.lb_ingre.Text = "Ingreso:";
            // 
            // bt_ingre_guardar
            // 
            this.bt_ingre_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_ingre_guardar.BackgroundImage")));
            this.bt_ingre_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ingre_guardar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.bt_ingre_guardar.Location = new System.Drawing.Point(188, 70);
            this.bt_ingre_guardar.Name = "bt_ingre_guardar";
            this.bt_ingre_guardar.Size = new System.Drawing.Size(25, 25);
            this.bt_ingre_guardar.TabIndex = 11;
            this.bt_ingre_guardar.UseVisualStyleBackColor = true;
            this.bt_ingre_guardar.Click += new System.EventHandler(this.Bt_ingre_guardarClick);
            // 
            // lb_ingre_monto
            // 
            this.lb_ingre_monto.Location = new System.Drawing.Point(34, 49);
            this.lb_ingre_monto.Name = "lb_ingre_monto";
            this.lb_ingre_monto.Size = new System.Drawing.Size(88, 19);
            this.lb_ingre_monto.TabIndex = 1;
            this.lb_ingre_monto.Text = "Monto ($):";
            // 
            // lb_ingre_valor
            // 
            this.lb_ingre_valor.AutoSize = true;
            this.lb_ingre_valor.Location = new System.Drawing.Point(131, 48);
            this.lb_ingre_valor.Name = "lb_ingre_valor";
            this.lb_ingre_valor.Size = new System.Drawing.Size(47, 16);
            this.lb_ingre_valor.TabIndex = 2;
            this.lb_ingre_valor.Text = "Valor";
            // 
            // tb_ingre_monto
            // 
            this.tb_ingre_monto.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ingre_monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ingre_monto.Enabled = false;
            this.tb_ingre_monto.Location = new System.Drawing.Point(127, 71);
            this.tb_ingre_monto.Name = "tb_ingre_monto";
            this.tb_ingre_monto.Size = new System.Drawing.Size(55, 23);
            this.tb_ingre_monto.TabIndex = 4;
            this.tb_ingre_monto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_ingre_montoKeyDown);
            this.tb_ingre_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_ingre_montoKeyPress);
            // 
            // cb_ingre_operacion
            // 
            this.cb_ingre_operacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ingre_operacion.FormattingEnabled = true;
            this.cb_ingre_operacion.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cb_ingre_operacion.Location = new System.Drawing.Point(84, 70);
            this.cb_ingre_operacion.Name = "cb_ingre_operacion";
            this.cb_ingre_operacion.Size = new System.Drawing.Size(34, 24);
            this.cb_ingre_operacion.TabIndex = 3;
            // 
            // tab_notas
            // 
            this.tab_notas.BackColor = System.Drawing.SystemColors.Info;
            this.tab_notas.Controls.Add(this.rtb_notas);
            this.tab_notas.Location = new System.Drawing.Point(4, 25);
            this.tab_notas.Name = "tab_notas";
            this.tab_notas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_notas.Size = new System.Drawing.Size(559, 603);
            this.tab_notas.TabIndex = 3;
            this.tab_notas.Text = "Notas";
            // 
            // rtb_notas
            // 
            this.rtb_notas.BackColor = System.Drawing.SystemColors.Info;
            this.rtb_notas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_notas.Location = new System.Drawing.Point(3, 3);
            this.rtb_notas.Name = "rtb_notas";
            this.rtb_notas.Size = new System.Drawing.Size(553, 597);
            this.rtb_notas.TabIndex = 0;
            this.rtb_notas.Text = "";
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_bottom.Controls.Add(this.bt_ayuda);
            this.panel_bottom.Controls.Add(this.tb_saldo);
            this.panel_bottom.Controls.Add(this.lb_saldo);
            this.panel_bottom.Controls.Add(this.dtp_principal);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 632);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(567, 28);
            this.panel_bottom.TabIndex = 5;
            // 
            // bt_ayuda
            // 
            this.bt_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_ayuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_ayuda.BackgroundImage")));
            this.bt_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ayuda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_ayuda.Location = new System.Drawing.Point(3, 2);
            this.bt_ayuda.Name = "bt_ayuda";
            this.bt_ayuda.Size = new System.Drawing.Size(25, 25);
            this.bt_ayuda.TabIndex = 3;
            this.bt_ayuda.UseVisualStyleBackColor = false;
            this.bt_ayuda.Click += new System.EventHandler(this.Bt_ayudaClick);
            // 
            // tb_saldo
            // 
            this.tb_saldo.BackColor = System.Drawing.SystemColors.Window;
            this.tb_saldo.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold);
            this.tb_saldo.ForeColor = System.Drawing.Color.Black;
            this.tb_saldo.Location = new System.Drawing.Point(117, 2);
            this.tb_saldo.Name = "tb_saldo";
            this.tb_saldo.ReadOnly = true;
            this.tb_saldo.Size = new System.Drawing.Size(100, 24);
            this.tb_saldo.TabIndex = 2;
            // 
            // lb_saldo
            // 
            this.lb_saldo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.lb_saldo.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_saldo.Location = new System.Drawing.Point(29, 8);
            this.lb_saldo.Name = "lb_saldo";
            this.lb_saldo.Size = new System.Drawing.Size(90, 15);
            this.lb_saldo.TabIndex = 1;
            this.lb_saldo.Text = "Saldo ($):";
            // 
            // dtp_principal
            // 
            this.dtp_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_principal.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtp_principal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtp_principal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_principal.Location = new System.Drawing.Point(414, 4);
            this.dtp_principal.Name = "dtp_principal";
            this.dtp_principal.Size = new System.Drawing.Size(149, 20);
            this.dtp_principal.TabIndex = 0;
            this.dtp_principal.Value = new System.DateTime(2020, 7, 15, 0, 29, 0, 0);
            this.dtp_principal.ValueChanged += new System.EventHandler(this.Dtp_principalValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(567, 660);
            this.Controls.Add(this.tc_principal);
            this.Controls.Add(this.panel_bottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(583, 699);
            this.MinimumSize = new System.Drawing.Size(583, 699);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.tc_principal.ResumeLayout(false);
            this.tab_egresos.ResumeLayout(false);
            this.gb_listado_egre.ResumeLayout(false);
            this.panel_otros.ResumeLayout(false);
            this.panel_otros.PerformLayout();
            this.panel_diarios.ResumeLayout(false);
            this.panel_diarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_egre_otros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_egre)).EndInit();
            this.gb_egre_tipos.ResumeLayout(false);
            this.gb_egre_tipos.PerformLayout();
            this.panel_egre_tipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_egre_tipos)).EndInit();
            this.gb_calculadora_egre.ResumeLayout(false);
            this.gb_calculadora_egre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_calculadora_egre)).EndInit();
            this.tab_ingresos.ResumeLayout(false);
            this.gb_listado_ingre.ResumeLayout(false);
            this.panel_ingresos.ResumeLayout(false);
            this.panel_ingresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_ingre)).EndInit();
            this.gb_ingre_tipos.ResumeLayout(false);
            this.gb_ingre_tipos.PerformLayout();
            this.panel_ingre_tipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_ingre_tipos)).EndInit();
            this.gb_calculadora_ingre.ResumeLayout(false);
            this.gb_calculadora_ingre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_calculadora_ingre)).EndInit();
            this.tab_notas.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.GroupBox gb_calculadora_egre;
		private System.Windows.Forms.DateTimePicker dtp_principal;
		private System.Windows.Forms.Panel panel_bottom;
		private System.Windows.Forms.TextBox tb_egre_monto;
		private System.Windows.Forms.Label lb_egre_monto;
		private System.Windows.Forms.Label lb_egre_valor;
		private System.Windows.Forms.ComboBox cb_egre_operacion;
		private System.Windows.Forms.DataGridView dgv_list_egre;
		private System.Windows.Forms.TabPage tab_ingresos;
		private System.Windows.Forms.TabPage tab_egresos;
		private System.Windows.Forms.TabControl tc_principal;
		private System.Windows.Forms.GroupBox gb_listado_egre;
		private System.Windows.Forms.DataGridView dgv_list_egre_otros;
		private System.Windows.Forms.Label lb_egre_otros;
		private System.Windows.Forms.Label lb_egre_diarios;
		private System.Windows.Forms.GroupBox gb_egre_tipos;
		private System.Windows.Forms.Button bt_egre_nuevo;
		private System.Windows.Forms.Button bt_egre_tipos_quitar;
		private System.Windows.Forms.ToolTip tip_agregar;
		private System.Windows.Forms.ToolTip tip_quitar;
		private System.Windows.Forms.ToolTip tip_nuevo;
		private System.Windows.Forms.Label lb_egre_tipo_nuevo;
		private System.Windows.Forms.ToolTip tip_guardar;
		private System.Windows.Forms.Button bt_egre_tipos_guardar;
		private System.Windows.Forms.Button bt_egre_guardar;
		private System.Windows.Forms.ComboBox cb_egre_diario;
		private System.Windows.Forms.Label lb_egre_diario;
		private System.Windows.Forms.DataGridView dgv_list_egre_tipos;
		private System.Windows.Forms.Panel panel_egre_tipos;
		private System.Windows.Forms.TextBox tb_egre_new_tipo;
		private System.Windows.Forms.Label lb_egre_nombre;
		private System.Windows.Forms.Label lb_egre;
		private System.Windows.Forms.Label lb_saldo;
		private System.Windows.Forms.TextBox tb_saldo;
		private System.Windows.Forms.PictureBox pb_calculadora_egre;
		private System.Windows.Forms.GroupBox gb_listado_ingre;
		private System.Windows.Forms.DataGridView dgv_list_ingre;
		private System.Windows.Forms.GroupBox gb_ingre_tipos;
		private System.Windows.Forms.Panel panel_ingre_tipos;
		private System.Windows.Forms.Button bt_ingre__tipos_quitar;
		private System.Windows.Forms.Button bt_ingre_nuevo;
		private System.Windows.Forms.DataGridView dgv_list_ingre_tipos;
		private System.Windows.Forms.Button bt_ingre_tipos_guardar;
		private System.Windows.Forms.TextBox tb_ingre_new_tipo;
		private System.Windows.Forms.Label lb_ingre_tipo_nuevo;
		private System.Windows.Forms.GroupBox gb_calculadora_ingre;
		private System.Windows.Forms.PictureBox pb_calculadora_ingre;
		private System.Windows.Forms.Label lb_ingre_nombre;
		private System.Windows.Forms.Label lb_ingre;
		private System.Windows.Forms.Button bt_ingre_guardar;
		private System.Windows.Forms.Label lb_ingre_monto;
		private System.Windows.Forms.TextBox tb_ingre_monto;
		private System.Windows.Forms.ComboBox cb_ingre_operacion;
		private System.Windows.Forms.Label lb_ingre_valor;
		private System.Windows.Forms.Panel panel_diarios;
		private System.Windows.Forms.Panel panel_otros;
		private System.Windows.Forms.Button bt_egre_diarios_otros_quitar;
		private System.Windows.Forms.Button bt_egre_diarios_quitar;
		private System.Windows.Forms.Button bt_ayuda;
		private System.Windows.Forms.ToolTip tip_ayuda;
		private System.Windows.Forms.Button bt_egre_editar;
		private System.Windows.Forms.ToolTip tip_editar;
		private System.Windows.Forms.Button bt_egre_tipos_cancel;
		private System.Windows.Forms.ToolTip tip_cancelar;
		private System.Windows.Forms.Button bt_ingre_tipos_cancel;
		private System.Windows.Forms.Button bt_ingre_editar;
		private System.Windows.Forms.TabPage tab_notas;
		private System.Windows.Forms.Panel panel_ingresos;
		private System.Windows.Forms.Button bt_ingre_quitar;
		private System.Windows.Forms.Label lb_egre_sub_otros;
		private System.Windows.Forms.TextBox tb_egre_sub_diarios;
		private System.Windows.Forms.Label lb_egre_sub_diarios;
		private System.Windows.Forms.TextBox tb_egre_sub_otros;
		private System.Windows.Forms.TextBox tb_ingre_sub;
		private System.Windows.Forms.Label lb_ingre_sub;
		private System.Windows.Forms.RichTextBox rtb_notas;
	}
}
