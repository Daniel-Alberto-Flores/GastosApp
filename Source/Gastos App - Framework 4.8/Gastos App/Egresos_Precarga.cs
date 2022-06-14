/*
 * Creado por SharpDevelop.
 * Usuario: ZEiryu
 * Fecha: 19/7/2020
 * Hora: 20:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Gastos_App
{
	public partial class Egresos_Precarga : Form
	{
		string Cone = "data source=C://Gastos_App/gastos.db"; //Conexión
		
		int verifi_close = 0;
		
		public Egresos_Precarga()
		{			
			InitializeComponent();
			//ToolTip
			tip_guardar.SetToolTip(bt_guardar, "Guardar");	
			
			//Establecemos el formato del DateTimePicker
		  	dtp_precarga.Format = DateTimePickerFormat.Custom;
			dtp_precarga.CustomFormat = "MMMM yyyy";
			dtp_precarga.ShowUpDown = true;			
			dtp_precarga.Value = Convert.ToDateTime(MainForm.fecha_dtp);//Le cargamos la fecha del DateTimePicker del Main Form
			
			//Egresos diarios
			int conta = 1; //Contamos la cantidad de checkbox agregados al Array
			ArrayList lista_diarios = met_bus_tipos_diarios();//Guardamos el resultado de la búsqueda en una varible del tipo DataRow			
			foreach (string row in lista_diarios)
			{
				//Creamos de forma dinámica los cb
			    CheckBox cb_diarios = new CheckBox();
			    cb_diarios.Font = new Font("Courier New", 10, FontStyle.Bold);
			    cb_diarios.Text = row;
			    cb_diarios.AutoSize = true;
				cb_diarios.Checked=true;		    
			    cb_diarios.Location = new Point(24, gb_diarios.Location.Y+(conta*22));//Establecemos la ubicación
			    this.Controls.Add(cb_diarios);
			    cb_diarios.BringToFront();			    			    
			    gb_diarios.Size= new Size (235, 26+(conta*22));//Agrandamos el gb_diarios
			    conta++;
			}
			
			//Egresos otros
			conta=1;
			gb_otros.Location = new Point(12, gb_diarios.Location.Y+gb_diarios.Size.Height+4);
			
			ArrayList lista_otros = met_bus_tipos_otros();//Guardamos el resultado de la búsqueda en una varible del tipo DataRow			
			foreach (string row in lista_otros)
			{
				//Creamos de forma dinámica los cb
			    CheckBox cb_otros = new CheckBox();
				cb_otros.Font = new Font("Courier New", 10, FontStyle.Bold);			    
			    cb_otros.Text = row;
			    cb_otros.AutoSize = true;
			    cb_otros.Checked=true;
			    cb_otros.Location = new Point(24, gb_otros.Location.Y+(conta*22));//Establecemos la ubicación			    
			    this.Controls.Add(cb_otros);
			    cb_otros.BringToFront();
			    gb_otros.Size= new Size (235,26+(conta*22));//Agrandamos el gb_otros
			    conta++;
			}
			
			//Ubicamos el botón de guardar
			bt_guardar.Location = new Point(222,gb_otros.Location.Y+gb_otros.Size.Height+8);//Sumamos el Location del gb_otros + su tamaño y le agregamos 8 posiciones
			
			int form_height = 39+gb_diarios.Location.Y+gb_diarios.Size.Height+gb_otros.Size.Height+bt_guardar.Size.Height+panel_bottom.Size.Height+20;
			//39 -->es lo que mide la barra de título del Form
			//gb_diarios.Location.Y --> Sería la ubicación de y del gb_diarios
			//gb_diarios.Size.Height --> Sería la altura del gb_diarios
			//gb_otros.Size.Height --> Sería la altura del gb_otros
			//bt_guardar.Size.Height -- Sería la altura del bt_guardar
			//panel_bottom.Size.Height --> Sería la altura del panel inferior dónde está el DateTimePicker
			this.Size = new Size (272, form_height);
			this.MinimumSize = new Size (272, form_height);
			this.MaximumSize = new Size (272, form_height);
			
		}
		
		void Egresos_PrecargaFormClosing(object sender, FormClosingEventArgs e)
		{
			if (verifi_close == 0)
			{
				this.Hide();			
				MainForm principal = new MainForm();
				principal.Show();
			}				
		}
		
		void Bt_guardarClick(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Va a cargar los egresos predeterminados seleccionados, está seguro?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				//Insertamos un nuevo registro en la tabla MOVIMIENTOS
				string egreso = "";
				
				foreach (var control in this.Controls)//Buscamos los objetos del tipo control
				{
					if (control is CheckBox)//Verificams que sea del tipo Checkbox
					{	
						if (((CheckBox)control).Checked)//Verificamos que esté checkeado
						{
							CheckBox cb = (CheckBox)control;//Lo guardamos en una variable del tipo Checkbox
							egreso = cb.Text;
							met_insert_egreso(egreso);//Le pasamos el nombre del egreso para buscarlo e insertarlo en el período actual
						}
					}					
				}
				
				if (verifi_close == 0)//Hacemos esta verificación para que no pase dos veces por el evento form closing
				{
					verifi_close = 1;
					this.Hide();			
					MainForm principal = new MainForm();
					principal.Show();
				}							
			}						
		}
		
		//Método
		private ArrayList met_bus_tipos_diarios()
		{
            SQLiteConnection cn = new SQLiteConnection(Cone);
            string Bus_Query = @"SELECT nombre
			FROM MOVIMIENTOS_DETALLES
			WHERE (tipo_id = 2) AND (estado = 'Activo') AND (diario = 'Si')
			ORDER BY nombre ASC";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Bus_Query, cn);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
			ArrayList lista_diarios = new ArrayList();
	        foreach (DataRow row in dt.Rows)
	        {
	          lista_diarios.Add(row["nombre"]);//Guardamos la query en un arraylist
	        }	        
            return lista_diarios;            
		}
		
		private ArrayList met_bus_tipos_otros()
		{
            SQLiteConnection cn = new SQLiteConnection(Cone);
            string Bus_Query = @"SELECT nombre
			FROM MOVIMIENTOS_DETALLES
			WHERE (tipo_id = 2) AND (estado = 'Activo') AND (diario = 'No')
			ORDER BY nombre ASC";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Bus_Query, cn);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
			ArrayList lista_otros = new ArrayList();
	        foreach (DataRow row in dt.Rows)
	        {
	          lista_otros.Add(row["nombre"]);//Guardamos la query en un arraylist
	        }	        
            return lista_otros;            
		}
		
		private void met_insert_egreso(string nombre_egreso)
		{
			//Insertamos el nuevo egreso			
			string mes = dtp_precarga.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_precarga.Value.ToString("yyyy"));
            SQLiteConnection cn = new SQLiteConnection(Cone);
            string Upd_Query = @"INSERT INTO MOVIMIENTOS (detalle_id, monto, mes, año)
			VALUES((SELECT id_detalle FROM MOVIMIENTOS_DETALLES WHERE (nombre = '"+nombre_egreso+"')), 0, '"+mes+"', "+año+");";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Upd_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}
	}
}
