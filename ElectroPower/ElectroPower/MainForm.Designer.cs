/*
 * Created by SharpDevelop.
 * User: Дмитрий
 * Date: 02.01.2016
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ElectroPower
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_Val2;
		private System.Windows.Forms.TextBox tb_Val1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_Price;
		private System.Windows.Forms.Label l_Price;
		private System.Windows.Forms.Button b_Price;
		private System.Windows.Forms.Button b_Close;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tb_Val2 = new System.Windows.Forms.TextBox();
			this.tb_Val1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_Price = new System.Windows.Forms.TextBox();
			this.l_Price = new System.Windows.Forms.Label();
			this.b_Price = new System.Windows.Forms.Button();
			this.b_Close = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tb_Val2);
			this.groupBox1.Controls.Add(this.tb_Val1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(248, 79);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Показания счетчика";
			// 
			// tb_Val2
			// 
			this.tb_Val2.Location = new System.Drawing.Point(105, 42);
			this.tb_Val2.Name = "tb_Val2";
			this.tb_Val2.Size = new System.Drawing.Size(134, 20);
			this.tb_Val2.TabIndex = 1;
			this.tb_Val2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Val2KeyPress);
			this.tb_Val2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tb_Val2KeyUp);
			// 
			// tb_Val1
			// 
			this.tb_Val1.Location = new System.Drawing.Point(105, 23);
			this.tb_Val1.Name = "tb_Val1";
			this.tb_Val1.Size = new System.Drawing.Size(134, 20);
			this.tb_Val1.TabIndex = 0;
			this.tb_Val1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Val1KeyPress);
			this.tb_Val1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tb_Val1KeyUp);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Предыдущие";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Предыдущие";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(27, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "Цена (руб/кВт)";
			// 
			// tb_Price
			// 
			this.tb_Price.Location = new System.Drawing.Point(117, 97);
			this.tb_Price.Name = "tb_Price";
			this.tb_Price.Size = new System.Drawing.Size(134, 20);
			this.tb_Price.TabIndex = 2;
			this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_PriceKeyPress);
			this.tb_Price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tb_PriceKeyUp);
			// 
			// l_Price
			// 
			this.l_Price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.l_Price.Location = new System.Drawing.Point(12, 128);
			this.l_Price.Name = "l_Price";
			this.l_Price.Size = new System.Drawing.Size(248, 36);
			this.l_Price.TabIndex = 0;
			this.l_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// b_Price
			// 
			this.b_Price.Location = new System.Drawing.Point(12, 167);
			this.b_Price.Name = "b_Price";
			this.b_Price.Size = new System.Drawing.Size(99, 23);
			this.b_Price.TabIndex = 3;
			this.b_Price.Text = "Вычислить";
			this.b_Price.UseVisualStyleBackColor = true;
			this.b_Price.Click += new System.EventHandler(this.B_PriceClick);
			// 
			// b_Close
			// 
			this.b_Close.Location = new System.Drawing.Point(161, 167);
			this.b_Close.Name = "b_Close";
			this.b_Close.Size = new System.Drawing.Size(99, 23);
			this.b_Close.TabIndex = 4;
			this.b_Close.Text = "Завершить";
			this.b_Close.UseVisualStyleBackColor = true;
			this.b_Close.Click += new System.EventHandler(this.B_CloseClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 198);
			this.Controls.Add(this.b_Close);
			this.Controls.Add(this.b_Price);
			this.Controls.Add(this.tb_Price);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.l_Price);
			this.Controls.Add(this.label3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Электроэнергия";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
