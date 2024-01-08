/*
 * Created by SharpDevelop.
 * User: guies
 * Date: 20/11/2023
 * Time: 09:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace trabalho_final
{
	partial class historia
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historia));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(12, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(226, 50);
			this.button1.TabIndex = 3;
			this.button1.Text = "História do Estádio Velho";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(555, 23);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(223, 50);
			this.button2.TabIndex = 4;
			this.button2.Text = "História do Estádio Novo";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Enabled = false;
			this.pictureBox1.Location = new System.Drawing.Point(28, 100);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(390, 240);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(542, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 240);
			this.label1.TabIndex = 6;
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Enabled = false;
			this.label2.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(542, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(236, 240);
			this.label2.TabIndex = 7;
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button3.FlatAppearance.BorderSize = 3;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(691, 344);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(87, 55);
			this.button3.TabIndex = 8;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// historia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(790, 410);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "historia";
			this.Text = "historia";
			this.Load += new System.EventHandler(this.HistoriaLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
