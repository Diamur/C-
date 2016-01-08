/*
 * Created by SharpDevelop.
 * User: Дмитрий
 * Date: 27.12.2015
 * Time: 14:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TextEditor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbFilePath;
		private System.Windows.Forms.NumericUpDown nudFontSize;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel tsslblSymbolCount;
		private System.Windows.Forms.Button bFileSelect;
		private System.Windows.Forms.Button bFileOpen;
		private System.Windows.Forms.TextBox tbContent;
		private System.Windows.Forms.Button bFileSave;
		
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
			this.tbFilePath = new System.Windows.Forms.TextBox();
			this.nudFontSize = new System.Windows.Forms.NumericUpDown();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslblSymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.bFileSelect = new System.Windows.Forms.Button();
			this.bFileOpen = new System.Windows.Forms.Button();
			this.tbContent = new System.Windows.Forms.TextBox();
			this.bFileSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Выбрать файл:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Шрифт:";
			// 
			// tbFilePath
			// 
			this.tbFilePath.Location = new System.Drawing.Point(100, 6);
			this.tbFilePath.Name = "tbFilePath";
			this.tbFilePath.Size = new System.Drawing.Size(385, 20);
			this.tbFilePath.TabIndex = 1;
			// 
			// nudFontSize
			// 
			this.nudFontSize.Location = new System.Drawing.Point(62, 30);
			this.nudFontSize.Maximum = new decimal(new int[] {
			72,
			0,
			0,
			0});
			this.nudFontSize.Minimum = new decimal(new int[] {
			6,
			0,
			0,
			0});
			this.nudFontSize.Name = "nudFontSize";
			this.nudFontSize.Size = new System.Drawing.Size(50, 20);
			this.nudFontSize.TabIndex = 2;
			this.nudFontSize.Value = new decimal(new int[] {
			6,
			0,
			0,
			0});
			this.nudFontSize.ValueChanged += new System.EventHandler(this.NudFontSizeValueChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1,
			this.tsslblSymbolCount});
			this.statusStrip1.Location = new System.Drawing.Point(0, 334);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(655, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 17);
			this.toolStripStatusLabel1.Text = "Количество символов:";
			// 
			// tsslblSymbolCount
			// 
			this.tsslblSymbolCount.Name = "tsslblSymbolCount";
			this.tsslblSymbolCount.Size = new System.Drawing.Size(0, 17);
			// 
			// bFileSelect
			// 
			this.bFileSelect.Location = new System.Drawing.Point(491, 4);
			this.bFileSelect.Name = "bFileSelect";
			this.bFileSelect.Size = new System.Drawing.Size(75, 23);
			this.bFileSelect.TabIndex = 4;
			this.bFileSelect.Text = "Выбрать";
			this.bFileSelect.UseVisualStyleBackColor = true;
			this.bFileSelect.Click += new System.EventHandler(this.BFileSelectClick);
			// 
			// bFileOpen
			// 
			this.bFileOpen.Location = new System.Drawing.Point(569, 4);
			this.bFileOpen.Name = "bFileOpen";
			this.bFileOpen.Size = new System.Drawing.Size(75, 23);
			this.bFileOpen.TabIndex = 4;
			this.bFileOpen.Text = "Открыть";
			this.bFileOpen.UseVisualStyleBackColor = true;
			this.bFileOpen.Click += new System.EventHandler(this.BFileOpenClick);
			// 
			// tbContent
			// 
			this.tbContent.Location = new System.Drawing.Point(12, 56);
			this.tbContent.Multiline = true;
			this.tbContent.Name = "tbContent";
			this.tbContent.Size = new System.Drawing.Size(632, 231);
			this.tbContent.TabIndex = 1;
			this.tbContent.TextChanged += new System.EventHandler(this.TbContentTextChanged);
			// 
			// bFileSave
			// 
			this.bFileSave.Location = new System.Drawing.Point(569, 293);
			this.bFileSave.Name = "bFileSave";
			this.bFileSave.Size = new System.Drawing.Size(75, 23);
			this.bFileSave.TabIndex = 4;
			this.bFileSave.Text = "Сохранить";
			this.bFileSave.UseVisualStyleBackColor = true;
			this.bFileSave.Click += new System.EventHandler(this.BFileSaveClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(655, 356);
			this.Controls.Add(this.bFileSave);
			this.Controls.Add(this.bFileOpen);
			this.Controls.Add(this.bFileSelect);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.nudFontSize);
			this.Controls.Add(this.tbContent);
			this.Controls.Add(this.tbFilePath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Текстовой редактор";
			((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
