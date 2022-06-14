/*
 * Creado por SharpDevelop.
 * Usuario: ZEiryu
 * Fecha: 14/7/2020
 * Hora: 01:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
//using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Gastos_App
{		
	public partial class MainForm : Form
	{
		string Cone = "data source=C://Gastos_App/gastos.db"; //Conexión
		
		internal static string fecha_dtp = "";
		int verifi_deci = 0;
		int verifi_db = 0;
		int edit_tipo = 0;		
		string egreso = "", ingreso ="", diario = "";
		
		public MainForm()
		{			
		  	InitializeComponent();
		  	met_verifi_db();
					  	
		  	var blankContextMenu = new ContextMenuStrip();//Generamos una variable vacía del tipo ContextMenuStrip
            tb_egre_monto.ContextMenuStrip = blankContextMenu;//La cargamos en el tb_monto para anular el clásico menú al pulsar click derecho
            tb_egre_new_tipo.ContextMenuStrip = blankContextMenu;//La cargamos en el tb_new_tipo para anular el clásico menú al pulsar click derecho
            tb_ingre_monto.ContextMenuStrip = blankContextMenu;//La cargamos en el tb_monto para anular el clásico menú al pulsar click derecho
            tb_ingre_new_tipo.ContextMenuStrip = blankContextMenu;//La cargamos en el tb_new_tipo para anular el clásico menú al pulsar click derecho
            tb_saldo.ContextMenuStrip = blankContextMenu;//La cargamos en el tb_saldo para anular el clásico menú al pulsar click derecho
		  	
		  	//Establecemos el item inicial del ComboBox Operación ("+" o "-")
		  	cb_egre_operacion.SelectedIndex = 0;
		  	cb_egre_diario.SelectedIndex = 0;
		  	cb_ingre_operacion.SelectedIndex = 0;
		  	
		  	//Establecemos el formato del DateTimePicker
		  	dtp_principal.Format = DateTimePickerFormat.Custom;
			dtp_principal.CustomFormat = "MMMM yyyy";
			dtp_principal.ShowUpDown = true;	

			if (fecha_dtp =="")
			{
				//Establecemos siempre el primer día del mes para evitar que caiga en meses que no tengan 31 días y se genere una excepción
				dtp_principal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			}
			else
			{
				dtp_principal.Value = Convert.ToDateTime(fecha_dtp);//Le cargamos la fecha del DateTimePicker si se volvió de Egresos_Precarga
			}
			fecha_dtp="";
			
			//Ejecutamos la query inicial del dgv_list_egre
			met_ini_dgv_list_egre();
			
			//Ejecutamos la query inicial del dgv_list_otros
			met_ini_dgv_list_egre_otros();					
            
            //Ejecutamos la query inicial del dgv_list_tipos
            met_ini_dgv_list_egre_tipos();
            
            //Ejecutamos la query inicial del dgv_list_ingre
			met_ini_dgv_list_ingre();
            
            //Ejecutamos la query inicial del dgv_list_ingre_tipos
            met_ini_dgv_list_ingre_tipos();
            
            //Tool tips
            tip_quitar.SetToolTip(bt_egre_tipos_quitar, "Quitar");
            tip_nuevo.SetToolTip(bt_egre_nuevo, "Nuevo");
            tip_guardar.SetToolTip(bt_egre_tipos_guardar, "Guardar");
            tip_editar.SetToolTip(bt_egre_editar, "Editar");
            tip_cancelar.SetToolTip(bt_egre_tipos_cancel, "Cancelar");
			tip_quitar.SetToolTip(bt_ingre__tipos_quitar, "Quitar");
            tip_nuevo.SetToolTip(bt_ingre_nuevo, "Nuevo");
            tip_guardar.SetToolTip(bt_ingre_tipos_guardar, "Guardar");
			tip_guardar.SetToolTip(bt_ayuda, "Ayuda");               
            
            gb_egre_tipos.Size= new Size (258,423);
            gb_ingre_tipos.Size= new Size (258,450);
            
            //Actualizamos el tb_saldo
            met_update_saldo();
            
            //Cargamos el txt de notas
            met_ini_notas();
        	
	        
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{		
			met_update_notas();
			Application.Exit();
		}
		
		//EGRESOS
		
		void Bt_egre_nuevoClick(object sender, EventArgs e)
		{
			egreso = "";//Blanqueamos la variable egreso
			gb_egre_tipos.Size= new Size (258,482);
			tb_egre_new_tipo.Focus();
			edit_tipo=0;//Lo establecemos en cero para verificar que es un tipo nuevo y no se está editando
		}
		
		void Bt_egre_tipos_guardarClick(object sender, EventArgs e)
		{			
			//Guardamos el nombre del tipo seleccionado
			if (tb_egre_new_tipo.Text.Trim() != "")
			{
				string new_tipo = tb_egre_new_tipo.Text.Trim();
				string diario = cb_egre_diario.Text;
				if (edit_tipo == 0)//Se está cargando un nuevo tipo
				{
					if (met_bus_egre_tipo(new_tipo,diario))//Le pasamos el tipo seleccionado y si es del tipo diario
					{
						MessageBox.Show("Ya se encuentra cargado el tipo ingresado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{						
						met_insert_egre_tipo();//Insertamos el nuevo tipo
						met_ini_dgv_list_egre_tipos();//Actualizamos el dgv_list_tipos con el nuevo tipo cargado
						tb_egre_new_tipo.Text = "";				
						gb_egre_tipos.Size= new Size (258,423);
					}	
				}
				
				if (edit_tipo == 1)
				{
					if (met_bus_egre_tipo(new_tipo,diario))//Le pasamos el tipo seleccionado y si es del tipo diario
					{
						MessageBox.Show("Ya se encuentra cargado el tipo ingresado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						met_update_egre_tipo();
						met_ini_dgv_list_egre_tipos();//Actualizamos el dgv_list_tipos con el nuevo tipo cargado
						met_ini_dgv_list_egre();
						met_ini_dgv_list_egre_otros();
						tb_egre_new_tipo.Text = "";				
						gb_egre_tipos.Size= new Size (258,423);
					}
				}
				egreso = "";
			}
			else
			{
				MessageBox.Show("Debe completar el campo 'Nombre'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}					
		}
		
		void Dgv_list_egre_dia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				//Cargamos el valor en el lb_valor, y además guardamos el nombre del egreso
				egreso = dgv_list_egre.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
				lb_egre_nombre.Text = egreso;
				lb_egre_valor.Text = dgv_list_egre.Rows[e.RowIndex].Cells["Monto"].Value.ToString();
				tb_egre_monto.Enabled=true;
				tb_egre_monto.Focus();
			}			
		}
		
		void Dgv_list_egre_otrosCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				//Cargamos el valor en el lb_valor, y además guardamos el nombre del egreso
				egreso = dgv_list_egre_otros.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
				lb_egre_nombre.Text = egreso;				
				lb_egre_valor.Text = dgv_list_egre_otros.Rows[e.RowIndex].Cells["Monto"].Value.ToString();
				tb_egre_monto.Enabled=true;
				tb_egre_monto.Focus();
			}
		}
		
		void Tb_egre_montoKeyPress(object sender, KeyPressEventArgs e)
		{
			//Lo siguiente establece que solo se pueda ingresar números, si se ingresa otra cosa
            //Anula la pulsación de la tecla
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                tb_egre_monto.Text = "";
            }
            string texto_monto = "";//Lo usamos para ver si el texto_monto tiene algún (.) cargado 
            int verifi_doble_deci = 0;
            texto_monto = tb_egre_monto.Text;
            if (!(texto_monto.Contains(".")))//Si no contiene un punto lo establece al valor de verifi_deci en 0
            {
                verifi_deci = 0;
            }       
            //Esta variable la generamos para que una vez ingresado en ((verifi_coma == 1) && (e.KeyChar == ','))
            //no vuelva a pasar por ((verifi_coma == 0) && (e.KeyChar == ',') && (verifi_doble_coma == 0))
            if ((verifi_deci == 1) && (e.KeyChar == '.'))
            {
                e.Handled = true;//Suprimimos la pulsación de la tecla punto, el Handled suprime el evento 
                verifi_doble_deci = 1;
            }            
            if ((verifi_deci == 0) && (e.KeyChar == '.') && (verifi_doble_deci == 0))
            {
                verifi_deci = 1;//Establecemos en 1 el valor de verifi_deci cuando pasa la primera vez
            }
		}
		
		void Tb_egre_montoKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                bt_egre_guardar.PerformClick();
            }	
		}
		
		void Bt_egre_guardarClick(object sender, EventArgs e)
		{
			if (tb_egre_monto.Text != "")
			{
				//Actualizamos el dgv_list_egre con el nuevo dato ingresado
				egreso = lb_egre_nombre.Text;
				Double monto = 0;
				string monto_query ="";//Es el monto sin la coma
				
				//Convertir string a float --> para esto usamos Convert.ToSingle		
				lb_egre_valor.Text = lb_egre_valor.Text.Replace(".", ",");
				tb_egre_monto.Text = tb_egre_monto.Text.Replace(".", ",");
				
				if (cb_egre_operacion.Text == "+")
				{				
					monto = Convert.ToSingle(lb_egre_valor.Text) + Convert.ToSingle(tb_egre_monto.Text);					
				}
				else
				{
					monto = Convert.ToSingle(lb_egre_valor.Text) - Convert.ToSingle(tb_egre_monto.Text);
				}
				monto_query = monto.ToString("N2");
				monto_query = monto_query.Replace(".","");//Quitamos los puntos de los separadores de miles
				monto_query = monto_query.Replace(",",".");//Remplazamos la coma por punto para inserta la query
				
				met_update_egreso(egreso, monto_query);//Actualizamos el monto en la db
	            
	            met_ini_dgv_list_egre();//Refrescamos el dgv_list_egre
	            met_ini_dgv_list_egre_otros();//Refrescamos el dgv_list_egre_otros

				lb_egre_valor.Text = tb_egre_monto.Text;//Conservamos el valor del último egreso cargado

				tb_egre_monto.Text ="";
	            tb_egre_monto.Enabled=false;
	            //Actualizamos el tb_saldo
            	met_update_saldo();
			}
			else
			{
				MessageBox.Show("Debe ingresar un monto.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}			
		}
		
		void Dgv_egre_tiposDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				egreso = dgv_list_egre_tipos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
				string diario = dgv_list_egre_tipos.Rows[e.RowIndex].Cells["Diario"].Value.ToString();
				if (met_bus_egreso(egreso))
				{
					MessageBox.Show("Ya se encuentra cargado el tipo seleccionado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					//Insertamos un nuevo registro en la tabla MOVIMIENTOS
					met_insert_egreso(egreso);//Le pasamos el nombre del egreso para buscarlo e insertarlo en el período actual
					//Actualizamos los dgv
					met_ini_dgv_list_egre();
					met_ini_dgv_list_egre_otros();
				}
			}
		}
		
		void Dgv_egre_tiposCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				//Guardamos el nombre del egreso seleccionado para luego inactivarlo			
				egreso = dgv_list_egre_tipos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
				diario = dgv_list_egre_tipos.Rows[e.RowIndex].Cells["Diario"].Value.ToString();
			}		
		}

		void Bt_egre__tipos_quitarClick(object sender, EventArgs e)
		{
			if (egreso != "")
			{
				DialogResult result = MessageBox.Show("Va a inactivar el tipo de gasto seleccionado ("+egreso+") ¿Está seguro?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					met_update_egre_inac(egreso);
					met_ini_dgv_list_egre_tipos();//Actualizamos el dgv_list_otros
				}
			}		
		}
		
		void Bt_egre_editarClick(object sender, EventArgs e)
		{
			if (egreso != "")
			{
				//Cargamos el tipo a editar en el tb_egre_new_tipo, y además cargamos si es del tipo diario o no
				tb_egre_new_tipo.Text = egreso;
				cb_egre_diario.Text = diario;
				gb_egre_tipos.Size= new Size (258,482);
				tb_egre_new_tipo.Focus();
				edit_tipo=1;//Lo establecemos en 1 para al guardar saber si se está editando o es un tipo nuevo
			}
		}
		
		void Dtp_principalValueChanged(object sender, EventArgs e)
		{
			met_update_dgv();
		}
		
		void Tc_principalSelectedIndexChanged(object sender, EventArgs e)
		{
			edit_tipo = 0;
			if (tc_principal.SelectedTab.Text == "Egresos")
			{
				bt_egre_tipos_cancel.PerformClick();
			}
			if (tc_principal.SelectedTab.Text == "Ingresos")
			{
				bt_ingre_tipos_cancel.PerformClick();	
			}
			met_update_dgv();
		}

		void Dgv_list_egreCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				//Cargamos el valor en el lb_valor, y además guardamos el nombre del egreso
				egreso = dgv_list_egre.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
			}	
		}
		
		void Dgv_list_egre_otrosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				//Cargamos el valor en el lb_valor, y además guardamos el nombre del egreso
				egreso = dgv_list_egre_otros.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
			}	
		}
		
		void Bt_egre_diarios_quitarClick(object sender, EventArgs e)
		{
			if (egreso != "")
			{
				DialogResult result = MessageBox.Show("Va a eliminar el movimiento seleccionado ("+egreso+") ¿Está seguro?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					met_egre_delete(egreso);
					met_ini_dgv_list_egre();//Refrescamos el dgv_list_egre					
            		met_update_saldo();//Actualizamos el tb_saldo				
				}
			}	
		}
		
		void Bt_egre_diarios_otros_quitarClick(object sender, EventArgs e)
		{
			if (egreso != "")
			{
				DialogResult result = MessageBox.Show("Va a eliminar el movimiento seleccionado ("+egreso+") ¿Está seguro?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					met_egre_delete(egreso);
					met_ini_dgv_list_egre_otros();//Refrescamos el dgv_list_egre					
            		met_update_saldo();//Actualizamos el tb_saldo			
				}
			}	
		}
		
		void Bt_egre_tipos_cancelClick(object sender, EventArgs e)
		{
			tb_egre_new_tipo.Text = "";				
			gb_egre_tipos.Size= new Size (258,423);
			edit_tipo=0;
		}		
		
		//INGRESOS
		
		void Dgv_list_ingreCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				//Cargamos el valor en el lb_valor, y además guardamos el nombre del ingreso
				ingreso = dgv_list_ingre.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
				lb_ingre_nombre.Text = ingreso;
				lb_ingre_valor.Text = dgv_list_ingre.Rows[e.RowIndex].Cells["Monto"].Value.ToString();
				tb_ingre_monto.Enabled=true;
				tb_ingre_monto.Focus();
			}
		}
		
		void Dgv_list_ingre_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				//Guardamos el nombre del ingreso seleccionado para luego inactivarlo			
				ingreso = dgv_list_ingre.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();	
			}	
		}
		
		void Dgv_list_ingre_tiposCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				//Guardamos el nombre del ingreso seleccionado para luego inactivarlo			
				ingreso = dgv_list_ingre_tipos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();	
			}	
		}
		
		void Dgv_list_ingre_tiposCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				ingreso = dgv_list_ingre_tipos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
				if (met_bus_ingreso(ingreso))
				{
					MessageBox.Show("Ya se encuentra cargado el tipo seleccionado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					//Insertamos un nuevo registro en la tabla MOVIMIENTOS
					met_insert_ingreso(ingreso);//Le pasamos el nombre del ingreso para buscarlo e insertarlo en el período actual
					//Actualizamos los dgv
					met_ini_dgv_list_ingre();
				}
			}	
		}
		
		void bt_ingre__tipos_quitarClick(object sender, EventArgs e)
		{
			if (ingreso != "")
			{
				DialogResult result = MessageBox.Show("Va a inactivar el tipo de ingreso seleccionado ("+ingreso+") ¿Está seguro?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					met_update_ingre_inac(ingreso);
					met_ini_dgv_list_ingre_tipos();//Actualizamos el dgv_list_otros
				}
			}			
		}
		
		void Bt_ingre_nuevoClick(object sender, EventArgs e)
		{
			gb_ingre_tipos.Size= new Size (258,481);
			tb_ingre_new_tipo.Focus();
			edit_tipo=0;//Lo establecemos en cero para verificar que es un tipo nuevo y no se está editando
		}
		
		void Bt_ingre_tipos_guardarClick(object sender, EventArgs e)
		{
			if (tb_ingre_new_tipo.Text.Trim() != "")
			{
				//Guardamos el nombre del tipo seleccionado
				string new_tipo = tb_ingre_new_tipo.Text.Trim();
				if (edit_tipo == 0)//Se está cargando un nuevo tipo
				{
					if (met_bus_ingre_tipo(new_tipo))//Le pasamos el tipo seleccionado
					{
						MessageBox.Show("Ya se encuentra cargado el tipo ingresado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{						
						met_insert_ingre_tipo();//Insertamos el nuevo tipo
						met_ini_dgv_list_ingre_tipos();//Actualizamos el dgv_list_ingre_tipos con el nuevo tipo cargado
						tb_ingre_new_tipo.Text = "";				
						gb_ingre_tipos.Size= new Size (258,450);
					}
				}
				if (edit_tipo == 1)
				{
					if (met_bus_ingre_tipo(new_tipo))//Le pasamos el tipo seleccionado y si es del tipo diario
					{
						MessageBox.Show("Ya se encuentra cargado el tipo ingresado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);						
					}
					else
					{
						met_update_ingre_tipo();
						met_ini_dgv_list_ingre_tipos();//Actualizamos el dgv_list_tipos con el nuevo tipo cargado
						met_ini_dgv_list_ingre();
						tb_ingre_new_tipo.Text = "";				
						gb_ingre_tipos.Size= new Size (258,450);												
					}				
				}
				ingreso = "";
			}
			else
			{
				MessageBox.Show("Debe completar el campo 'Nombre'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}			
		}
		
		void Bt_ingre_guardarClick(object sender, EventArgs e)
		{
			if (tb_ingre_monto.Text != "")
			{
				//Actualizamos el dgv_list_ingre con el nuevo dato ingresado
				ingreso = lb_ingre_nombre.Text;
				Double monto = 0;
				string monto_query ="";//Es el monto sin la coma
				
				//Convertir string a float --> para esto usamos Convert.ToSingle		
				lb_ingre_valor.Text = lb_ingre_valor.Text.Replace(".", ",");
				tb_ingre_monto.Text = tb_ingre_monto.Text.Replace(".", ",");
				
				if (cb_ingre_operacion.Text == "+")
				{				
					monto = Convert.ToSingle(lb_ingre_valor.Text) + Convert.ToSingle(tb_ingre_monto.Text);					
				}
				else
				{
					monto = Convert.ToSingle(lb_ingre_valor.Text) - Convert.ToSingle(tb_ingre_monto.Text);
				}
				monto_query = monto.ToString("N2");//Al monto final le deja dos decimales y le establece el seperador de miles
				monto_query = monto_query.Replace(".","");//Quitamos los puntos de los separadores de miles
				monto_query = monto_query.Replace(",",".");//Remplazamos la coma por punto para inserta la query
				met_update_ingreso(ingreso, monto_query);//Actualizamos el monto en la db
	            
	            met_ini_dgv_list_ingre();//Refrescamos el dgv_list_ingre
	            lb_ingre_nombre.Text = "Nombre";
	            lb_ingre_valor.Text = "Valor";
	            tb_ingre_monto.Text ="";
	            tb_ingre_monto.Enabled=false;
	            //Actualizamos el tb_saldo
            	met_update_saldo();
			}
			else
			{
				MessageBox.Show("Debe ingresar un monto.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}	
		}
		
		void Bt_ingre_editarClick(object sender, EventArgs e)
		{
			if (ingreso!= "")
			{
				//Cargamos el tipo a editar en el tb_ingre_new_tipo
				tb_ingre_new_tipo.Text = ingreso;
				gb_ingre_tipos.Size= new Size (258,481);
				tb_ingre_new_tipo.Focus();
				edit_tipo=1;//Lo establecemos en 1 para al guardar saber si se está editando o es un tipo nuevo
			}
		}
		
		void Tb_ingre_montoKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                bt_ingre_guardar.PerformClick();
            }	
		}
		
		void Tb_ingre_montoKeyPress(object sender, KeyPressEventArgs e)
		{
			//Lo siguiente establece que solo se pueda ingresar números, si se ingresa otra cosa
            //Anula la pulsación de la tecla
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                tb_ingre_monto.Text = "";
            }
            string texto_monto = "";//Lo usamos para ver si el texto_monto tiene algún (.) cargado 
            int verifi_doble_deci = 0;
            texto_monto = tb_ingre_monto.Text;
            if (!(texto_monto.Contains(".")))//Si no contiene un punto lo establece al valor de verifi_deci en 0
            {
                verifi_deci = 0;
            }       
            //Esta variable la generamos para que una vez ingresado en ((verifi_coma == 1) && (e.KeyChar == ','))
            //no vuelva a pasar por ((verifi_coma == 0) && (e.KeyChar == ',') && (verifi_doble_coma == 0))
            if ((verifi_deci == 1) && (e.KeyChar == '.'))
            {
                e.Handled = true;//Suprimimos la pulsación de la tecla punto, el Handled suprime el evento 
                verifi_doble_deci = 1;
            }            
            if ((verifi_deci == 0) && (e.KeyChar == '.') && (verifi_doble_deci == 0))
            {
                verifi_deci = 1;//Establecemos en 1 el valor de verifi_deci cuando pasa la primera vez
            }	
		}
		
		void bt_ingre_tipos_cancelClick(object sender, EventArgs e)
		{
			tb_ingre_new_tipo.Text = "";				
			gb_ingre_tipos.Size= new Size (258,450);
			edit_tipo=0;
		}
		
		void Bt_ingre_quitarClick(object sender, EventArgs e)
		{
			if (ingreso != "")
			{
				DialogResult result = MessageBox.Show("Va a eliminar el movimiento seleccionado ("+ingreso+") ¿Está seguro?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					met_ingre_delete(ingreso);
					met_ini_dgv_list_ingre();//Refrescamos el dgv_list_ingre				
            		met_update_saldo();//Actualizamos el tb_saldo			
				}
			}	
		}
		
		void Bt_ayudaClick(object sender, EventArgs e)
		{
			this.Hide();
			Ayuda ayuda = new Ayuda();
			ayuda.Show();
		}
		
		//Métodos Egresos
		
		private void met_ini_dgv_list_egre()
		{
			//Cargamos la query del dgv_list_egre
			string mes = dtp_principal.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_principal.Value.ToString("yyyy"));
			string Ini_Query = "";
            SQLiteConnection cn = new SQLiteConnection(Cone);
            Ini_Query = @"SELECT MOV_DET.nombre AS Nombre, MOV.monto AS Monto
            FROM `MOVIMIENTOS` MOV
            INNER JOIN `MOVIMIENTOS_DETALLES` MOV_DET
            ON MOV_DET.id_detalle = MOV.detalle_id
			WHERE (MOV_DET.tipo_id = 2) AND (MOV_DET.diario = 'Si') AND (mes = '"+mes+"') AND (año = "+año+")"+
            "ORDER BY MOV_DET.nombre ASC;";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Ini_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);            
            dgv_list_egre.DataSource = dt;
            
            //Actualizamos el subtotal
            Double sub_total = 0;
			foreach (DataGridViewRow row in dgv_list_egre.Rows)
			{
			    sub_total += (Double)row.Cells["Monto"].Value;
			}            
			tb_egre_sub_diarios.Text = sub_total.ToString("N2").Replace(".","");
		}
		
		private void met_ini_dgv_list_egre_otros()
		{
			//Cargamos la query del dgv_list_egre
			string mes = dtp_principal.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_principal.Value.ToString("yyyy"));
			string Ini_Query = "";
            SQLiteConnection cn = new SQLiteConnection(Cone);
            Ini_Query = @"SELECT MOV_DET.nombre AS Nombre, MOV.monto AS Monto
            FROM `MOVIMIENTOS` MOV
            INNER JOIN `MOVIMIENTOS_DETALLES` MOV_DET
            ON MOV_DET.id_detalle = MOV.detalle_id
			WHERE (MOV_DET.tipo_id = 2) AND (MOV_DET.diario = 'No') AND (mes = '"+mes+"') AND (año = "+año+")"+
            "ORDER BY MOV_DET.nombre ASC;";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Ini_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);            
            dgv_list_egre_otros.DataSource = dt;
            
            //Actualizamos el subtotal
            Double sub_total = 0;
			foreach (DataGridViewRow row in dgv_list_egre_otros.Rows)
			{
			    sub_total += (Double)row.Cells["Monto"].Value;
			}            
			tb_egre_sub_otros.Text = sub_total.ToString("N2").Replace(".","");
		}
		
		private void met_ini_dgv_list_egre_tipos()
		{
			//Cargamos la query del dgv_list_tipos
			string Ini_Query = "";
            SQLiteConnection cn = new SQLiteConnection(Cone);
            Ini_Query = @"SELECT nombre AS Nombre, diario AS Diario
            FROM MOVIMIENTOS_DETALLES
            WHERE (estado = 'Activo') AND (tipo_id = 2)
			ORDER BY nombre ASC";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Ini_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);            
            dgv_list_egre_tipos.DataSource = dt;  
		}
		
		private bool met_bus_egre_tipo(string new_tipo, string diario)
		{
			//Buscamos si ya existe el nuevo tipo a agregar del dgv_egre_list_tipos
			string Bus_Query = "";
            SQLiteConnection cn = new SQLiteConnection(Cone);
            Bus_Query = @"SELECT nombre, diario
			FROM MOVIMIENTOS_DETALLES
			WHERE (nombre = '"+new_tipo+"') AND (diario = '"+diario+"') AND (tipo_id = '2') AND (estado = 'Activo');";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Bus_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
            	if (egreso == new_tipo)
            	{
            		return false;
            	}
            	else
            	{
            		return true;//Si ya existe devuelve true y no permitimos cargarlo nuevamente
            	}
            	
            }
            else
			{
				return false;
			}          
		}

		private bool met_bus_egreso(string nombre_egreso)
		{
			//Buscamos si ya existe el egreso a agregar al dgv_list_egre
			string mes = dtp_principal.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_principal.Value.ToString("yyyy"));
            SQLiteConnection cn = new SQLiteConnection(Cone);
            string Bus_Query = @"SELECT detalle_id 
			FROM MOVIMIENTOS
			WHERE (detalle_id = (SELECT id_detalle FROM MOVIMIENTOS_DETALLES WHERE (nombre = '"+nombre_egreso+"'))) AND (mes = '"+mes+"') AND (año = '"+año+"')";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Bus_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
            	return true;//Si ya existe devuelve true y no permitimos cargarlo nuevamente
            }
			else
			{
				return false;
			}			
		}
		
		private void met_insert_egre_tipo()
		{
			//Insertamos el nuevo tipo
			string Upd_Query = "";			
            SQLiteConnection cn = new SQLiteConnection(Cone);
            Upd_Query = @"INSERT INTO MOVIMIENTOS_DETALLES (nombre, tipo_id, diario, estado)
			VALUES('"+tb_egre_new_tipo.Text.Trim()+"', '2', '"+cb_egre_diario.Text+"', 'Activo');";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Upd_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}
		
		private void met_insert_egreso(string nombre_egreso)
		{
			//Insertamos el nuevo egreso			
			string mes = dtp_principal.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_principal.Value.ToString("yyyy"));
            SQLiteConnection cn = new SQLiteConnection(Cone);
            string Upd_Query = @"INSERT INTO MOVIMIENTOS (detalle_id, monto, mes, año)
			VALUES((SELECT id_detalle FROM MOVIMIENTOS_DETALLES WHERE (nombre = '"+nombre_egreso+"')), 0, '"+mes+"', "+año+");";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Upd_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}
		
		private void met_update_egreso (string nombre_egreso, string monto)
		{
			SQLiteConnection cn = new SQLiteConnection(Cone);
			string mes = dtp_principal.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_principal.Value.ToString("yyyy"));
			
			string update_query = @"UPDATE MOVIMIENTOS
			SET monto = "+monto+@"
			WHERE (detalle_id = (SELECT id_detalle 
			FROM MOVIMIENTOS_DETALLES
			WHERE (nombre = '"+nombre_egreso+"'))) AND (mes = '"+mes+"') AND (año = "+año+")";
			
			SQLiteDataAdapter da = new SQLiteDataAdapter(update_query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}
		
		private void met_update_egre_tipo()
		{
			SQLiteConnection cn = new SQLiteConnection(Cone);
			
			string update_query = @"UPDATE MOVIMIENTOS_DETALLES
			SET nombre = '"+tb_egre_new_tipo.Text+"', diario = '"+cb_egre_diario.Text+@"'
			WHERE nombre = '"+egreso+"'";
			
			SQLiteDataAdapter da = new SQLiteDataAdapter(update_query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}				
		
		private void met_update_egre_inac (string nombre_egreso)
		{
			SQLiteConnection cn = new SQLiteConnection(Cone);
			
			string update_query = @"
			UPDATE MOVIMIENTOS_DETALLES
			SET estado = 'Inactivo'
			WHERE (nombre = '"+nombre_egreso+"')";
			
			SQLiteDataAdapter da = new SQLiteDataAdapter(update_query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}
		
		private void met_egre_delete(string nombre_egreso)
		{						
			//Eliminamos el movimiento seleccionado del dgv_list_egre
			string mes = dtp_principal.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_principal.Value.ToString("yyyy"));
			
			string Del_Query = "";
            SQLiteConnection cn = new SQLiteConnection(Cone);
            Del_Query = @"DELETE FROM MOVIMIENTOS
			WHERE (detalle_id = (SELECT id_detalle 
			FROM MOVIMIENTOS_DETALLES
			WHERE (nombre = '"+nombre_egreso+"') AND (tipo_id = 2))) AND (mes = '"+mes+"') AND (año = "+año+")";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Del_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}
		
		//Métodos Ingresos
		
		private void met_ini_dgv_list_ingre()
		{
			//Cargamos la query del dgv_list_ingre
			string mes = dtp_principal.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_principal.Value.ToString("yyyy"));
			string Ini_Query = "";
            SQLiteConnection cn = new SQLiteConnection(Cone);
            Ini_Query = @"SELECT MOV_DET.nombre AS Nombre, MOV.monto AS Monto
            FROM `MOVIMIENTOS` MOV
            INNER JOIN `MOVIMIENTOS_DETALLES` MOV_DET
            ON MOV_DET.id_detalle = MOV.detalle_id
			WHERE (MOV_DET.tipo_id = 1) AND (MOV_DET.diario = 'No') AND (mes = '"+mes+"') AND (año = "+año+")"+
            "ORDER BY MOV_DET.nombre ASC;";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Ini_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);            
            dgv_list_ingre.DataSource = dt;
            
            //Actualizamos el subtotal
            Double sub_total = 0;
			foreach (DataGridViewRow row in dgv_list_ingre.Rows)
			{
			    sub_total += (Double)row.Cells["Monto"].Value;
			}            
			tb_ingre_sub.Text = sub_total.ToString("N2").Replace(".","");
		}
		
		private void met_ini_dgv_list_ingre_tipos()
		{
			//Cargamos la query del dgv_list_ingre_tipos
			string Ini_Query = "";
            SQLiteConnection cn = new SQLiteConnection(Cone);
            Ini_Query = @"SELECT nombre AS Nombre, diario AS Diario
            FROM MOVIMIENTOS_DETALLES
            WHERE (estado = 'Activo') AND (tipo_id = 1)
			ORDER BY nombre ASC";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Ini_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);            
            dgv_list_ingre_tipos.DataSource = dt;  
		}
		
		private bool met_bus_ingre_tipo(string new_tipo)
		{
			//Buscamos si ya existe el nuevo tipo a agregar del dgv_list_ingre_tipos
			string Bus_Query = "";
            SQLiteConnection cn = new SQLiteConnection(Cone);
            Bus_Query = @"SELECT nombre, diario
			FROM MOVIMIENTOS_DETALLES
			WHERE (nombre = '"+new_tipo+"') AND (diario = 'No') AND (tipo_id = '1');";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Bus_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
            	if (ingreso == new_tipo)
            	{
            		return false;
            	}
            	{
            		return true;//Si ya existe devuelve true y no permitimos cargarlo nuevamente
            	}            	
            }
			else
			{
				return false;
			}            
		}

		private bool met_bus_ingreso(string nombre_ingreso)
		{
			//Buscamos si ya existe el egreso a agregar al dgv_list_ingre
			string mes = dtp_principal.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_principal.Value.ToString("yyyy"));
            SQLiteConnection cn = new SQLiteConnection(Cone);
            string Bus_Query = @"SELECT detalle_id 
			FROM MOVIMIENTOS
			WHERE (detalle_id = (SELECT id_detalle FROM MOVIMIENTOS_DETALLES WHERE (nombre = '"+nombre_ingreso+"'))) AND (mes = '"+mes+"') AND (año = '"+año+"')";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Bus_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
            	return true;//Si ya existe devuelve true y no permitimos cargarlo nuevamente
            }
			else
			{
				return false;
			}			
		}
		
		private void met_insert_ingre_tipo()
		{
			//Insertamos el nuevo tipo
			string Upd_Query = "";			
            SQLiteConnection cn = new SQLiteConnection(Cone);
            Upd_Query = @"INSERT INTO MOVIMIENTOS_DETALLES (nombre, tipo_id, diario, estado)
			VALUES('"+tb_ingre_new_tipo.Text.Trim()+"', '1', 'No', 'Activo');";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Upd_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}
		
		private void met_insert_ingreso(string nombre_ingreso)
		{
			//Insertamos el nuevo ingreso			
			string mes = dtp_principal.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_principal.Value.ToString("yyyy"));
            SQLiteConnection cn = new SQLiteConnection(Cone);
            string Upd_Query = @"INSERT INTO MOVIMIENTOS (detalle_id, monto, mes, año)
			VALUES((SELECT id_detalle FROM MOVIMIENTOS_DETALLES WHERE (nombre = '"+nombre_ingreso+"')), 0, '"+mes+"', "+año+");";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Upd_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}
		
		private void met_update_ingreso (string nombre_ingreso, string monto)
		{
			SQLiteConnection cn = new SQLiteConnection(Cone);
			string mes = dtp_principal.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_principal.Value.ToString("yyyy"));
			
			string update_query = @"UPDATE MOVIMIENTOS
			SET monto = "+monto+@"
			WHERE (detalle_id = (SELECT id_detalle 
			FROM MOVIMIENTOS_DETALLES
			WHERE (nombre = '"+nombre_ingreso+"'))) AND (mes = '"+mes+"') AND (año = "+año+")";
			
			SQLiteDataAdapter da = new SQLiteDataAdapter(update_query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}
		
		private void met_update_ingre_inac (string nombre_ingreso)
		{
			SQLiteConnection cn = new SQLiteConnection(Cone);
			
			string update_query = @"
			UPDATE MOVIMIENTOS_DETALLES
			SET estado = 'Inactivo'
			WHERE (nombre = '"+nombre_ingreso+"')";
			
			SQLiteDataAdapter da = new SQLiteDataAdapter(update_query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}
		
		private void met_update_dgv()//Se encarga de verificar la tabpage seleccionada y actualizar los dgv correspondientes
		{
			if (verifi_db == 0)
			{
				met_verifi_db();
			}
			
			var tab = tc_principal.SelectedTab.Text;//Obtenemos el nombre de la tabpage seleccionada			
			if (tab == "Egresos")
			{
				met_ini_dgv_list_egre();
				met_ini_dgv_list_egre_otros();
				if ((dgv_list_egre.Rows.Count == 0) && (dgv_list_egre_otros.Rows.Count == 0) && (fecha_dtp == "") && (verifi_db == 1))
				{
					DialogResult result = MessageBox.Show("No se encuentran cargados egresos en el mes seleccionado. Desea precargar los tipos de egresos ya existentes?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						fecha_dtp = dtp_principal.Value.ToString("MMMM yyyy");
						this.Hide();
						Egresos_Precarga egre_pre = new Egresos_Precarga();
						egre_pre.Show();
					}	
				}				
			}
			if (tab == "Ingresos")
			{
				met_ini_dgv_list_ingre();
			}
			
			//Actualizamos el tb_saldo
            met_update_saldo();
		}
		
		private void met_update_saldo()
		{
			string mes = dtp_principal.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_principal.Value.ToString("yyyy"));
			
			Double total_egreso = 0, total_ingreso = 0;
			string query_egreso ="", query_ingreso ="";			
			SQLiteConnection cn = new SQLiteConnection(Cone); //Creamos la conexión
			cn.Open(); //Abrimos la conexión
			
            SQLiteCommand cmd = cn.CreateCommand(); //Creamos una variable para ejecutar la query            
            query_ingreso =@"SELECT total(MOV.monto) AS Ingresos
			FROM `MOVIMIENTOS` MOV
			INNER JOIN `MOVIMIENTOS_DETALLES` MOV_DET
			ON MOV_DET.id_detalle = MOV.detalle_id
			WHERE (MOV_DET.tipo_id = 1) AND (mes = '"+mes+"') AND (año = "+año+")";
            cmd.CommandText = query_ingreso;  //Ejecutamos la consulta
            total_ingreso = Convert.ToDouble(cmd.ExecuteScalar().ToString());//Pasamos el resultado a la variable
            
            cmd = cn.CreateCommand(); //Creamos una variable para ejecutar la query
            query_egreso =@"SELECT total(MOV.monto) AS Egresos
			FROM `MOVIMIENTOS` MOV
			INNER JOIN `MOVIMIENTOS_DETALLES` MOV_DET
			ON MOV_DET.id_detalle = MOV.detalle_id
			WHERE (MOV_DET.tipo_id = 2) AND (mes = '"+mes+"') AND (año = "+año+")";
            cmd.CommandText = query_egreso;  //Ejecutamos la consulta
            total_egreso = Convert.ToDouble(cmd.ExecuteScalar().ToString());//Pasamos el resultado a la variable
            
            Double saldo = (total_ingreso-total_egreso);
            
            if (saldo> 0)
            {
            	tb_saldo.ForeColor = Color.Green;            	
            }
            if (saldo <0)
            {
            	tb_saldo.ForeColor = Color.Red;
            }
            if (saldo == 0)
            {
            	tb_saldo.ForeColor = Color.Black;
            }
            tb_saldo.Text = saldo.ToString("N2");
            
            cn.Close(); //Cerramos la conexión
		}
		
		private void met_verifi_db()//Verificamos si la db está vacía
		{
			string verifi_query = @"SELECT nombre AS Nombre, diario AS Diario
            FROM MOVIMIENTOS_DETALLES
            WHERE (estado = 'Activo') AND (tipo_id = 2)
			ORDER BY nombre ASC";
			SQLiteConnection cn = new SQLiteConnection(Cone); //Creamos la conexión
            cn.Open(); //Abrimos la conexión
            SQLiteCommand cmd = cn.CreateCommand(); //Creamos una variable para ejecutar la query
            cmd.CommandText = verifi_query;  //Ejecutamos la consulta

            //Acá verifica que se haya cargado un tipo al menos, si no se cargó nada todavía devuelve un valor null
            //Pero al ser una consulta a la base no podemos usar "null" y debemos usar "DBNull.Value"
            if (cmd.ExecuteScalar() == null)
            {
            	verifi_db = 0;//Si está vacía carga 0
            }
            if (cmd.ExecuteScalar() != null)
            {
            	verifi_db = 1;//Si ya tiene algún registro carga 1            	
            }
            cn.Close(); //Cerramos la conexión
		}
		
		private void met_ingre_delete(string nombre_ingreso)
		{						
			//Eliminamos el movimiento seleccionado del dgv_list_ingre
			string mes = dtp_principal.Value.ToString("MMMM");
			int año = Convert.ToInt32(dtp_principal.Value.ToString("yyyy"));
			
			string Del_Query = "";
            SQLiteConnection cn = new SQLiteConnection(Cone);
            Del_Query = @"DELETE FROM MOVIMIENTOS
			WHERE (detalle_id = (SELECT id_detalle 
			FROM MOVIMIENTOS_DETALLES
			WHERE (nombre = '"+nombre_ingreso+"') AND (tipo_id = 1))) AND (mes = '"+mes+"') AND (año = "+año+")";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Del_Query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}
		
		private void met_update_ingre_tipo()
		{
			SQLiteConnection cn = new SQLiteConnection(Cone);
			
			string update_query = @"UPDATE MOVIMIENTOS_DETALLES
			SET nombre = '"+tb_ingre_new_tipo.Text+@"'
			WHERE nombre = '"+ingreso+"'";
			
			SQLiteDataAdapter da = new SQLiteDataAdapter(update_query, cn);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
		}	
		
		//Métodos Notas
		
		private void met_ini_notas()
		{
			if (File.Exists(@"C:\Gastos_App\notas.txt"))
            {		
            	string[] lines = File.ReadAllLines(@"C:\Gastos_App\notas.txt");
            	int conta =1;
		        foreach (string line in lines)
		        {
		            //Cargamos cada línea del txt en el rtb_notas y le agregamos un salto de línea al final de cada una
		            if (conta != lines.Length)
		            {
		            	rtb_notas.AppendText(line+Environment.NewLine);
		            }
		            else//Pero si está en la última posición no agregamos un salto de línea al final
		            {
		            	rtb_notas.AppendText(line);
		            }		            
		            conta++;
		        }
		    }
			else
			{
				MessageBox.Show("No existe el archivo 'notas.txt' en la carpeta 'Gastos_App', generar manualmente por favor, buscar en la ayuda en el apartado 'notas', como hacerlo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		
		private void met_update_notas()
		{
			if (File.Exists(@"C:\Gastos_App\notas.txt"))
            {
            	string[] lines = rtb_notas.Lines;
            	System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Gastos_App\notas.txt");
		        foreach (string line in lines)
		        {
		        	file.WriteLine(line);
		        }
		       file.Close();
            }
		}		
		
	}
}
