/*
 * Created by SharpDevelop.
 * User: guies
 * Date: 20/11/2023
 * Time: 09:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace trabalho_final
{
	/// <summary>
	/// Description of jogos.
	/// </summary>
	public partial class jogos : Form
	{
		public jogos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
		Process.Start("https://www.youtube.com/watch?v=P5aVJEm9Yr0");
		}
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
	Process.Start("https://www.youtube.com/watch?v=QMfH6X0m1Sw");
		}
		void Button1Click(object sender, EventArgs e)
		{
	 bilhete bil=new bilhete();
			bil.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
