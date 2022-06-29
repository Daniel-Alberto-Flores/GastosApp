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
		string Cone = "data source=" + System.Environment.CurrentDirectory + "//gastos.db";//Conexión

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

			carga_de_datos_dgv();//Cargamos los datos en los dgvs
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

				foreach (DataGridViewRow Row in dgv_list_egre.Rows)
				{
					if ((bool)Row.Cells["ckCbxColumn"].Value)
                    {
						egreso = Row.Cells["nombre"].Value.ToString();
						met_insert_egreso(egreso);//Le pasamos el nombre del egreso para buscarlo e insertarlo en el período actual
					}					
				}

				foreach (DataGridViewRow Row in dgv_list_egre_otros.Rows)
				{
					if ((bool)Row.Cells["ckCbxColumn"].Value)
					{
						egreso = Row.Cells["nombre"].Value.ToString();
						met_insert_egreso(egreso);//Le pasamos el nombre del egreso para buscarlo e insertarlo en el período actual
					}
				}

				//foreach (var control in this.Controls)//Buscamos los objetos del tipo control
				//{
				//	if (control is CheckBox)//Verificams que sea del tipo Checkbox
				//	{	
				//		if (((CheckBox)control).Checked)//Verificamos que esté checkeado
				//		{
				//			CheckBox cb = (CheckBox)control;//Lo guardamos en una variable del tipo Checkbox
				//			egreso = cb.Text;
				//			met_insert_egreso(egreso);//Le pasamos el nombre del egreso para buscarlo e insertarlo en el período actual
				//		}
				//	}					
				//}
				
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

		private void carga_de_datos_dgv()
		{
			ArrayList listDiarios = met_bus_tipos_diarios();
			ArrayList listOtros = met_bus_tipos_otros();

			LoadDgvListOutColumnsNames();//Cargamos los encabezados de dgv_list_egre
			LoadDgvListOutOthersColumnsNames();//Cargamos los encabezados de dgv_list_egre_otros

			foreach (var Nombre in listDiarios)
			{
				dgv_list_egre.Rows.Add(Nombre, true);			
			}
			foreach (var Nombre in listOtros)
            {
				dgv_list_egre_otros.Rows.Add(Nombre, true);
			}
		}

		private DataGridViewCheckBoxColumn CreateDgvCbxColumn()
		{
			// We create a DataGridViewCheckBoxColumn at runtime
			DataGridViewCheckBoxColumn cbxColumn = new DataGridViewCheckBoxColumn();
			cbxColumn.Name = "ckCbxColumn";
			cbxColumn.HeaderText = "Check";
			cbxColumn.Width = 30;
			cbxColumn.ReadOnly = false;
			return cbxColumn;
		}

		private void LoadDgvListOutColumnsNames()
		{   //dgv_list_egre
			dgv_list_egre.Columns.Add("Nombre", "Nombre");
			dgv_list_egre.Columns.Add(CreateDgvCbxColumn());
		}

		private void LoadDgvListOutOthersColumnsNames()
		{   //dgv_list_egre_otros
			dgv_list_egre_otros.Columns.Add("Nombre", "Nombre");
			dgv_list_egre_otros.Columns.Add(CreateDgvCbxColumn());
		}
	}
}
