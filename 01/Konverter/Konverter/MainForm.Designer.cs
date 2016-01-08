/*
 * Created by SharpDevelop.
 * User: Дмитрий
 * Date: 02.01.2016
 * Time: 19:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Konverter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label l_Valuta;
		private System.Windows.Forms.TextBox tb_Price;
		private System.Windows.Forms.TextBox tb_Kurs;
		private System.Windows.Forms.Button b_Pereschet;
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.l_Valuta = new System.Windows.Forms.Label();
			this.tb_Price = new System.Windows.Forms.TextBox();
			this.tb_Kurs = new System.Windows.Forms.TextBox();
			this.b_Pereschet = new System.Windows.Forms.Button();
			this.b_Close = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(177, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите курс, цену в долларах";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Цена (USD)";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Курс (RUB/USD)";
			// 
			// l_Valuta
			// 
			this.l_Valuta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.l_Valuta.Location = new System.Drawing.Point(12, 96);
			this.l_Valuta.Name = "l_Valuta";
			this.l_Valuta.Size = new System.Drawing.Size(215, 25);
			this.l_Valuta.TabIndex = 0;
			// 
			// tb_Price
			// 
			this.tb_Price.Location = new System.Drawing.Point(127, 29);
			this.tb_Price.Name = "tb_Price";
			this.tb_Price.Size = new System.Drawing.Size(100, 20);
			this.tb_Price.TabIndex = 1;
			this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_PriceKeyPress);
			// 
			// tb_Kurs
			// 
			this.tb_Kurs.Location = new System.Drawing.Point(127, 52);
			this.tb_Kurs.Name = "tb_Kurs";
			this.tb_Kurs.Size = new System.Drawing.Size(100, 20);
			this.tb_Kurs.TabIndex = 1;
			this.tb_Kurs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KursKeyPress);
			// 
			// b_Pereschet
			// 
			this.b_Pereschet.Location = new System.Drawing.Point(10, 136);
			this.b_Pereschet.Name = "b_Pereschet";
			this.b_Pereschet.Size = new System.Drawing.Size(96, 23);
			this.b_Pereschet.TabIndex = 2;
			this.b_Pereschet.Text = "Пересчет";
			this.b_Pereschet.UseVisualStyleBackColor = true;
			this.b_Pereschet.Click += new System.EventHandler(this.B_PereschetClick);
			// 
			// b_Close
			// 
			this.b_Close.Location = new System.Drawing.Point(131, 136);
			this.b_Close.Name = "b_Close";
			this.b_Close.Size = new System.Drawing.Size(96, 23);
			this.b_Close.TabIndex = 2;
			this.b_Close.Text = "Завершить";
			this.b_Close.UseVisualStyleBackColor = true;
			this.b_Close.Click += new System.EventHandler(this.B_CloseClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(241, 170);
			this.Controls.Add(this.b_Close);
			this.Controls.Add(this.b_Pereschet);
			this.Controls.Add(this.tb_Kurs);
			this.Controls.Add(this.tb_Price);
			this.Controls.Add(this.l_Valuta);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Konverter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
