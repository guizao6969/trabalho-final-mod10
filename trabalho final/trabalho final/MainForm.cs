/*
 * Created by SharpDevelop.
 * User: guies
 * Date: 17/11/2023
 * Time: 15:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace trabalho_final
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button3Click(object sender, EventArgs e)
		{
	 historia hist=new historia();
			hist.Show();
		}
		void Button4Click(object sender, EventArgs e)
		{
	 historiabenfica histben=new historiabenfica();
			histben.Show();
		}
		void Button1Click(object sender, EventArgs e)
		{
	 jogos jog=new jogos();
			jog.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
	bilhete bil=new bilhete();
			bil.Show();
		}
		void Button5Click(object sender, EventArgs e)
		{
			var resposta =DialogResult;
			resposta = MessageBox.Show("Tem a certeza que quer sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (resposta == DialogResult.Yes)
				Close();
			
		}
		void Button6Click(object sender, EventArgs e)
		{
	roupa roup=new roupa();
			roup.Show();
		}
		
	}
}
