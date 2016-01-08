/*
 * Created by SharpDevelop.
 * User: Дмитрий
 * Date: 20.12.2015
 * Time: 0:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
//using TextEditor.IMainForm;

namespace TextEditor
{
	// Cоздаем интерфейс формы
	
	public interface IMainForm
	{
		
		string FilePath{get;} // Возвращает тот путь к файла
		string Content {get; set;} // Контент для получения и отображания
		void SetSymbolCount(int count); // Устанавливает кол-во символов
		
		//события
		event EventHandler FileOpenClick; // нажатие на кн. "открыть файл"
		event EventHandler FileSaveClick; // нажатие на кн. "записать файл"
		event EventHandler ContentChanged; //Изменение кол-ва символов в контекте
	}

	
	
	public partial class MainForm : Form, IMainForm
	{
		public MainForm()
		{
			InitializeComponent();
			
			buttonOpenFile.Click += ButtonOpenFileClick;
			buttonSaveFile.Click += ButtonSaveFileClick;
			textBoxContent.TextChanged += TextBoxContentTextChanged;
			buttonFileSelect.Click += ButtonFileSelectClick;
			numericUpDown.ValueChanged +=NumericUpDownValueChanged ;
		}
		
	#region Проброс событий
	
	//нажатие кнопки "Открыть"
		void ButtonOpenFileClick(object sender, EventArgs e)
		{
			if (FileOpenClick != null ) FileOpenClick(this , EventArgs.Empty );
		}
		
	//нажатие кнопки "Сохранить"
		void ButtonSaveFileClick(object sender, EventArgs e)
		{
			if (FileSaveClick != null ) FileSaveClick(this , EventArgs.Empty );
		}
	
	//нажатие в поле редактирования текста
		void TextBoxContentTextChanged(object sender, EventArgs e)
		{
		  	if (ContentChanged != null ) ContentChanged(this , EventArgs.Empty );
		}
		
	#endregion
	
	#region Реализация интерфейса IMainForm
		public string FilePath {
			get { return this.textBoxFilePath.Text ;	}
		}
		
		public string Content {
			get { return this.textBoxContent.Text  ;	}
			set { this.textBoxContent.Text = value ;	}
		}
		
		public void SetSymbolCount(int count)
		{
			this.lblSymbolCount.Text=count.ToString();
		}

		// события для интерфейса
		public event EventHandler FileOpenClick;
		public event EventHandler FileSaveClick;
		public event EventHandler ContentChanged;
	#endregion		
	
	#region Внутренний свой код обработки событий  
	
		
		void ButtonFileSelectClick(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter="Текстовые файлы|*.txt|Все файлы|*.*";
			
			if(dlg.ShowDialog()== DialogResult.OK)
			{
				textBoxFilePath.Text= dlg.FileName;
				if (FileOpenClick != null ) FileOpenClick(this, EventArgs.Empty);
			}
		}
	
		// Выбор шрифта редакт. текста
		void NumericUpDownValueChanged(object sender, EventArgs e)
		{
			textBoxContent.Font=new Font("Calibri", (float )numericUpDown.Value );
		}
	#endregion		
	
	}
}
