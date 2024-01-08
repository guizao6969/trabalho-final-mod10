/*
 * Created by SharpDevelop.
 * User: guies
 * Date: 20/11/2023
 * Time: 09:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace trabalho_final
{
	/// <summary>
	/// Description of bilhete.
	/// </summary>
	public partial class bilhete : Form
	{
		public bilhete()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	 switch (comboBox1.SelectedIndex)
		{
			case 0:
	 		radioButton1.Visible=true;
	 		radioButton2.Visible=true;
	 		radioButton3.Visible=false;
			radioButton4.Visible=false;
			radioButton6.Visible=false;
			radioButton7.Visible=false;
			groupBox1.Visible=true;
			groupBox2.Visible=true;
			break;
			case 1:
				radioButton1.Visible=false;
			radioButton2.Visible=false;
			radioButton3.Visible=true;
			radioButton4.Visible=true;
			radioButton6.Visible=false;
			radioButton7.Visible=false;
			groupBox1.Visible=true;
			groupBox2.Visible=true;
			
			break;
			case 2:
				radioButton1.Visible=false;
			radioButton2.Visible=false;
			radioButton3.Visible=false;
			radioButton4.Visible=false;
			radioButton6.Visible=true;
			radioButton7.Visible=true;
			groupBox1.Visible=true;
			groupBox2.Visible=true;
			break;
		}
		
	}
		void BilheteLoad(object sender, EventArgs e)
		{
			radioButton1.Visible=false;
			radioButton2.Visible=false;
			radioButton3.Visible=false;
			radioButton4.Visible=false;
			radioButton6.Visible=false;
			radioButton7.Visible=false;
			groupBox2.Visible=false;
			groupBox1.Visible=false;
		}
		void Button2Click(object sender, EventArgs e)
		{
	MessageBox.Show("Sua Compra foi Efetuada", "Compra", MessageBoxButtons.OK);
	Close();
		}
	}}
