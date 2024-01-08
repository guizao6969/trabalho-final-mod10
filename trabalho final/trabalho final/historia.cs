/*
 * Created by SharpDevelop.
 * User: guies
 * Date: 20/11/2023
 * Time: 09:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace trabalho_final
{
	/// <summary>
	/// Description of historia.
	/// </summary>
	public partial class historia : Form
	{
		public historia()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button2Click(object sender, EventArgs e)
		{
	pictureBox1.Image = Image.FromFile("imagem\\novo.jpeg");
	label1.Visible=true;
	label2.Visible=false;
		}
		void Button1Click(object sender, EventArgs e)
		{
	pictureBox1.Image = Image.FromFile("imagem\\velho.PNG");
	label2.Visible=true;
	label1.Visible=false;
		}
		void HistoriaLoad(object sender, EventArgs e)
		{
			label1.Visible=false;
			label2.Visible=false;
		}
		void Button3Click(object sender, EventArgs e)
		{
			Close();
		}
		
	}
}
