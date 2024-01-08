/*
 * Created by SharpDevelop.
 * User: guies
 * Date: 20/11/2023
 * Time: 23:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace trabalho_final
{
	/// <summary>
	/// Description of roupa.
	/// </summary>
	public partial class roupa : Form
	{
		dados d=new dados();
		public roupa()
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
			Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
	    d.Numero = Convert.ToInt32(textBox2.Text);
         d.Quantidade = Convert.ToInt32(textBox9.Text);
          d.Codig = Convert.ToInt32(textBox6.Text);
          d.Nome= textBox1.Text;
			d.Pais= textBox4.Text;
			d.Morada= textBox7.Text;
			d.Tamanho= textBox3.Text;
			d.Distrito= textBox5.Text;
          
			MessageBox.Show(d.menssagens());
			Close();
            
          
		}
	}
}
