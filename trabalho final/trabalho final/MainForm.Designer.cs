/*
 * Created by SharpDevelop.
 * User: guies
 * Date: 17/11/2023
 * Time: 15:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace trabalho_final
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(1, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 48);
			this.button1.TabIndex = 0;
			this.button1.Text = "Jogos ";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(0, 42);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(154, 57);
			this.button2.TabIndex = 3;
			this.button2.Text = "Bilhetes";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button3.FlatAppearance.BorderSize = 3;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(149, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(499, 362);
			this.button3.TabIndex = 5;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(0, 93);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(142, 60);
			this.button4.TabIndex = 6;
			this.button4.Text = "História";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.Location = new System.Drawing.Point(12, 247);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(116, 104);
			this.button5.TabIndex = 7;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Transparent;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Bold);
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(1, 157);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(141, 48);
			this.button6.TabIndex = 8;
			this.button6.Text = "Roupa";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(649, 363);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Benfica ";
			this.ResumeLayout(false);

		}
	}
}
