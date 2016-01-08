/*
 * Created by SharpDevelop.
 * User: Дмитрий
 * Date: 20.12.2015
 * Time: 0:56
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
			this.textBoxFilePath = new System.Windows.Forms.TextBox();
			this.buttonOpenFile = new System.Windows.Forms.Button();
			this.buttonFileSelect = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.textBoxContent = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblSymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.buttonSaveFile = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Выбрать файл:";
			// 
			// textBoxFilePath
			// 
			this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFilePath.Location = new System.Drawing.Point(95, 11);
			this.textBoxFilePath.Name = "textBoxFilePath";
			this.textBoxFilePath.Size = new System.Drawing.Size(426, 20);
			this.textBoxFilePath.TabIndex = 1;
			// 
			// buttonOpenFile
			// 
			this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOpenFile.Location = new System.Drawing.Point(608, 9);
			this.buttonOpenFile.Name = "buttonOpenFile";
			this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
			this.buttonOpenFile.TabIndex = 2;
			this.buttonOpenFile.Text = "Открыть";
			this.buttonOpenFile.UseVisualStyleBackColor = true;
			this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFileClick);
			// 
			// buttonFileSelect
			// 
			this.buttonFileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFileSelect.Location = new System.Drawing.Point(527, 8);
			this.buttonFileSelect.Name = "buttonFileSelect";
			this.buttonFileSelect.Size = new System.Drawing.Size(75, 23);
			this.buttonFileSelect.TabIndex = 2;
			this.buttonFileSelect.Text = "Выбрать";
			this.buttonFileSelect.UseVisualStyleBackColor = true;
			this.buttonFileSelect.Click += new System.EventHandler(this.ButtonFileSelectClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Шрифт:";
			// 
			// numericUpDown
			// 
			this.numericUpDown.Location = new System.Drawing.Point(55, 47);
			this.numericUpDown.Maximum = new decimal(new int[] {
									72,
									0,
									0,
									0});
			this.numericUpDown.Minimum = new decimal(new int[] {
									6,
									0,
									0,
									0});
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new System.Drawing.Size(34, 20);
			this.numericUpDown.TabIndex = 3;
			this.numericUpDown.Value = new decimal(new int[] {
									6,
									0,
									0,
									0});
			this.numericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDownValueChanged);
			// 
			// textBoxContent
			// 
			this.textBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxContent.Location = new System.Drawing.Point(12, 75);
			this.textBoxContent.Multiline = true;
			this.textBoxContent.Name = "textBoxContent";
			this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxContent.Size = new System.Drawing.Size(667, 353);
			this.textBoxContent.TabIndex = 4;
			this.textBoxContent.TextChanged += new System.EventHandler(this.TextBoxContentTextChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1,
									this.lblSymbolCount});
			this.statusStrip1.Location = new System.Drawing.Point(0, 478);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(691, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
			this.toolStripStatusLabel1.Text = "Кол-во символов:";
			// 
			// lblSymbolCount
			// 
			this.lblSymbolCount.Name = "lblSymbolCount";
			this.lblSymbolCount.Size = new System.Drawing.Size(0, 17);
			// 
			// buttonSaveFile
			// 
			this.buttonSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveFile.Location = new System.Drawing.Point(608, 434);
			this.buttonSaveFile.Name = "buttonSaveFile";
			this.buttonSaveFile.Size = new System.Drawing.Size(75, 23);
			this.buttonSaveFile.TabIndex = 2;
			this.buttonSaveFile.Text = "Сохранить";
			this.buttonSaveFile.UseVisualStyleBackColor = true;
			this.buttonSaveFile.Click += new System.EventHandler(this.ButtonSaveFileClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(691, 500);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.textBoxContent);
			this.Controls.Add(this.numericUpDown);
			this.Controls.Add(this.buttonFileSelect);
			this.Controls.Add(this.buttonSaveFile);
			this.Controls.Add(this.buttonOpenFile);
			this.Controls.Add(this.textBoxFilePath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Текстовой редактор";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripStatusLabel lblSymbolCount;
		private System.Windows.Forms.Button buttonSaveFile;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TextBox textBoxContent;
		private System.Windows.Forms.NumericUpDown numericUpDown;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonFileSelect;
		private System.Windows.Forms.Button buttonOpenFile;
		private System.Windows.Forms.TextBox textBoxFilePath;
		private System.Windows.Forms.Label label1;
	}
}
