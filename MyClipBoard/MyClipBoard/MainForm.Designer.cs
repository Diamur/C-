/*
 * Created by SharpDevelop.
 * User: Дмитрий
 * Date: 08.01.2016
 * Time: 10:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MyClipBoard
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox tb_Content;
		private System.Windows.Forms.Button b_Copy;
		private System.Windows.Forms.Button b_Clear;
		private System.Windows.Forms.NotifyIcon ni_Tray;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tb_Content = new System.Windows.Forms.TextBox();
			this.b_Copy = new System.Windows.Forms.Button();
			this.b_Clear = new System.Windows.Forms.Button();
			this.ni_Tray = new System.Windows.Forms.NotifyIcon(this.components);
			this.SuspendLayout();
			// 
			// tb_Content
			// 
			this.tb_Content.Location = new System.Drawing.Point(12, 12);
			this.tb_Content.Multiline = true;
			this.tb_Content.Name = "tb_Content";
			this.tb_Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_Content.Size = new System.Drawing.Size(418, 270);
			this.tb_Content.TabIndex = 0;
			// 
			// b_Copy
			// 
			this.b_Copy.Location = new System.Drawing.Point(355, 288);
			this.b_Copy.Name = "b_Copy";
			this.b_Copy.Size = new System.Drawing.Size(75, 23);
			this.b_Copy.TabIndex = 1;
			this.b_Copy.Text = "Копировать";
			this.b_Copy.UseVisualStyleBackColor = true;
			this.b_Copy.Click += new System.EventHandler(this.B_CopyClick);
			// 
			// b_Clear
			// 
			this.b_Clear.Location = new System.Drawing.Point(274, 288);
			this.b_Clear.Name = "b_Clear";
			this.b_Clear.Size = new System.Drawing.Size(75, 23);
			this.b_Clear.TabIndex = 1;
			this.b_Clear.Text = "Очистить";
			this.b_Clear.UseVisualStyleBackColor = true;
			this.b_Clear.Click += new System.EventHandler(this.B_ClearClick);
			// 
			// ni_Tray
			// 
			this.ni_Tray.Text = "Накопитель Буфера Обмена";
			this.ni_Tray.Visible = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 325);
			this.Controls.Add(this.b_Clear);
			this.Controls.Add(this.b_Copy);
			this.Controls.Add(this.tb_Content);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Накопитель Буфера";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
