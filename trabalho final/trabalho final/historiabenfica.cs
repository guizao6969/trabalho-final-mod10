/*
 * Created by SharpDevelop.
 * User: guies
 * Date: 20/11/2023
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace trabalho_final
{
	/// <summary>
	/// Description of historiabenfica.
	/// </summary>
	public partial class historiabenfica : Form
	{
		public historiabenfica()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			button1.Visible=false;
			pictureBox1.Visible=true;
			label1.Visible=true;
		}
		void Button2Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
