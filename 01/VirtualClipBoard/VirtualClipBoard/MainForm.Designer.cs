/*
 * Created by SharpDevelop.
 * User: Дмитрий
 * Date: 05.01.2016
 * Time: 13:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VirtualClipBoard
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox autoload;
		private System.Windows.Forms.NumericUpDown history_size;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown size_tray;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Button clear;
		//private System.Windows.Forms.TextBox _notifyIcon;
		//private System.Windows.Forms.NotifyIcon _notifyIcon;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.size_tray = new System.Windows.Forms.NumericUpDown();
			this.exit = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			//this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			//this.tb_Content = new System.Windows.Forms.TextBox();
			this.history_size = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.autoload = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.size_tray)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.history_size)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(506, 281);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Кол-во в трее";
			// 
			// size_tray
			// 
			this.size_tray.Location = new System.Drawing.Point(506, 303);
			this.size_tray.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.size_tray.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.size_tray.Name = "size_tray";
			this.size_tray.Size = new System.Drawing.Size(120, 20);
			this.size_tray.TabIndex = 3;
			this.size_tray.Value = new decimal(new int[] {
			5,
			0,
			0,
			0});
			this.size_tray.ValueChanged += new System.EventHandler(this.size_tray_ValueChanged);
			// 
			// exit
			// 
			this.exit.Location = new System.Drawing.Point(12, 346);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(139, 23);
			this.exit.TabIndex = 4;
			this.exit.Text = "Выход";
			this.exit.UseVisualStyleBackColor = true;
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(495, 346);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(139, 23);
			this.clear.TabIndex = 4;
			this.clear.Text = "Очистить история";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// _notifyIcon
			// 
			this._notifyIcon.Text = "notifyIcon1";
			this._notifyIcon.Visible = true;
			// 
			// tb_Content
			// 
			this.tb_Content.AcceptsReturn = true;
			this.tb_Content.Location = new System.Drawing.Point(12, 12);
			this.tb_Content.Multiline = true;
			this.tb_Content.Name = "tb_Content";
			this.tb_Content.Size = new System.Drawing.Size(622, 236);
			this.tb_Content.TabIndex = 5;
			// 
			// history_size
			// 
			this.history_size.Location = new System.Drawing.Point(185, 303);
			this.history_size.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.history_size.Minimum = new decimal(new int[] {
			2,
			0,
			0,
			0});
			this.history_size.Name = "history_size";
			this.history_size.Size = new System.Drawing.Size(120, 20);
			this.history_size.TabIndex = 3;
			this.history_size.Value = new decimal(new int[] {
			50,
			0,
			0,
			0});
			this.history_size.ValueChanged += new System.EventHandler(this.history_size_ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(185, 281);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Размер истории";
			// 
			// autoload
			// 
			this.autoload.Location = new System.Drawing.Point(12, 276);
			this.autoload.Name = "autoload";
			this.autoload.Size = new System.Drawing.Size(167, 24);
			this.autoload.TabIndex = 2;
			this.autoload.Text = "Автозагрузка с Windows";
			this.autoload.UseVisualStyleBackColor = true;
			this.autoload.CheckedChanged += new System.EventHandler(this.autoload_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 384);
			this.Controls.Add(this.tb_Content);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.size_tray);
			this.Controls.Add(this.history_size);
			this.Controls.Add(this.autoload);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "VirtualClipBoard";
			((System.ComponentModel.ISupportInitialize)(this.size_tray)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.history_size)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
