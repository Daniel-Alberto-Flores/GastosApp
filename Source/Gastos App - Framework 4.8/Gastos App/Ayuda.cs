/*
 * Creado por SharpDevelop.
 * Usuario: ZEiryu
 * Fecha: 2/8/2020
 * Hora: 22:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gastos_App
{
	public partial class Ayuda : Form
	{

		
		public Ayuda()
		{
			InitializeComponent();
			
			//Acomodamos el tamaño del formulario al primer ingreso
			this.MinimumSize = new Size (498,260);
           	this.MaximumSize = new Size (498,260);
           	this.AutoScroll = false;
			
			//Tool tips
			tip_editar.SetToolTip(pb_editar, "Editar");
            tip_quitar.SetToolTip(pb_quitar, "Quitar");
            tip_nuevo.SetToolTip(pb_nuevo, "Nuevo");
			tip_lenguaje.SetToolTip(pb_lenguaje, "C#");
			tip_db.SetToolTip(pb_db, "SQLite");
			
			//Acomodamos los textos en negrita
			lb_guia_bold_1.BringToFront();
			lb_guia_bold_2.BringToFront();
			lb_guia_bold_3.BringToFront();
			lb_guia_bold_4.BringToFront();
			lb_guia_bold_5.BringToFront();
			lb_guia_bold_6.BringToFront();
			lb_guia_bold_7.BringToFront();
			lb_guia_bold_8.BringToFront();
			lb_guia_bold_9.BringToFront();
			lb_guia_bold_10.BringToFront();
			lb_guia_bold_11.BringToFront();
			lb_guia_bold_12.BringToFront();
			lb_guia_bold_13.BringToFront();
			lb_guia_bold_14.BringToFront();
			lb_guia_bold_15.BringToFront();
			lb_guia_bold_16.BringToFront();
			
			//Acomodamos las imágenes
			pb_editar.BringToFront();
			pb_quitar.BringToFront();
			pb_nuevo.BringToFront();
			pb_calculadora.BringToFront();
			
		}
		void AyudaFormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();			
			MainForm principal = new MainForm();
			principal.Show();
		}
		
		void Tc_principalSelectedIndexChanged(object sender, EventArgs e)
		{
			//Establecemos los tamaños de las tabs
			if (tc_principal.SelectedTab.Text == "Introducción")
			{				
           		this.MinimumSize = new Size (498,260);
           		this.MaximumSize = new Size (498,260);
           		this.AutoScroll = false;
			}
						
			if (tc_principal.SelectedTab.Text == "Guía de uso")
			{				
           		this.MinimumSize = new Size (500,560);
           		this.MaximumSize = new Size (500,560);
           		this.AutoScroll = true;
          	    this.AutoScrollMargin = new Size (0,570);
				this.AutoScrollMinSize = new Size (0,570);
			}
			
			if (tc_principal.SelectedTab.Text == "Acerca de")
			{
				this.MinimumSize = new Size (450,210);
           		this.MaximumSize = new Size (450,210);
           		this.AutoScroll = false;
			}			
		}
		void Llb_acerca_de_1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
				
		}
	}
}
