/*
 * Created by SharpDevelop.
 * User: Дмитрий
 * Date: 31.12.2015
 * Time: 17:23
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
		private System.Windows.Forms.TextBox tb_Cena;
		private System.Windows.Forms.TextBox tb_Kurs;
		private System.Windows.Forms.Label l_Price;
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
			this.tb_Cena = new System.Windows.Forms.TextBox();
			this.tb_Kurs = new System.Windows.Forms.TextBox();
			this.l_Price = new System.Windows.Forms.Label();
			this.b_Pereschet = new System.Windows.Forms.Button();
			this.b_Close = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите курс, цену в долларах и щелкните на кнопке Пересчет";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Цена (USD)";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Курс (RUB/USD)";
			// 
			// tb_Cena
			// 
			this.tb_Cena.Location = new System.Drawing.Point(110, 42);
			this.tb_Cena.Name = "tb_Cena";
			this.tb_Cena.Size = new System.Drawing.Size(85, 20);
			this.tb_Cena.TabIndex = 1;
			this.tb_Cena.TextChanged += new System.EventHandler(this.Tb_CenaTextChanged);
			this.tb_Cena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_CenaKeyPress);
			// 
			// tb_Kurs
			// 
			this.tb_Kurs.Location = new System.Drawing.Point(110, 62);
			this.tb_Kurs.Name = "tb_Kurs";
			this.tb_Kurs.Size = new System.Drawing.Size(85, 20);
			this.tb_Kurs.TabIndex = 1;
			this.tb_Kurs.TextChanged += new System.EventHandler(this.Tb_KursTextChanged);
			this.tb_Kurs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KursKeyPress);
			// 
			// l_Price
			// 
			this.l_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.l_Price.Location = new System.Drawing.Point(12, 85);
			this.l_Price.Name = "l_Price";
			this.l_Price.Size = new System.Drawing.Size(183, 43);
			this.l_Price.TabIndex = 0;
			// 
			// b_Pereschet
			// 
			this.b_Pereschet.Location = new System.Drawing.Point(12, 131);
			this.b_Pereschet.Name = "b_Pereschet";
			this.b_Pereschet.Size = new System.Drawing.Size(82, 23);
			this.b_Pereschet.TabIndex = 2;
			this.b_Pereschet.Text = "Пересчет";
			this.b_Pereschet.UseVisualStyleBackColor = true;
			this.b_Pereschet.Click += new System.EventHandler(this.B_PereschetClick);
			// 
			// b_Close
			// 
			this.b_Close.Location = new System.Drawing.Point(110, 131);
			this.b_Close.Name = "b_Close";
			this.b_Close.Size = new System.Drawing.Size(85, 23);
			this.b_Close.TabIndex = 2;
			this.b_Close.Text = "Завершить";
			this.b_Close.UseVisualStyleBackColor = true;
			this.b_Close.Click += new System.EventHandler(this.B_CloseClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(203, 163);
			this.ControlBox = false;
			this.Controls.Add(this.b_Close);
			this.Controls.Add(this.b_Pereschet);
			this.Controls.Add(this.tb_Kurs);
			this.Controls.Add(this.tb_Cena);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.l_Price);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Конвертер валют";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
