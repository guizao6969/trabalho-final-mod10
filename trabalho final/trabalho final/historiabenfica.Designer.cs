/*
 * Created by SharpDevelop.
 * User: guies
 * Date: 20/11/2023
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace trabalho_final
{
	partial class historiabenfica
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historiabenfica));
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(492, 387);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Enabled = false;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 35);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(252, 284);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Enabled = false;
			this.label1.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro Blac", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(294, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 244);
			this.label1.TabIndex = 2;
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button2.FlatAppearance.BorderSize = 2;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(402, 318);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(74, 52);
			this.button2.TabIndex = 3;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// historiabenfica
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Khaki;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(488, 382);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Name = "historiabenfica";
			this.Text = "historiabenfica";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
