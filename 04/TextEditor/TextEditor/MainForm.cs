using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor
{    
    //Интерфейс
    public interface IMainForm
    {
        //Поля для управляющего кода
        string FilePath{get;}
        string Content{get;set;}
        
        //Методы для управляющего кода для действий над формой
        void SetSymbolCount(int count);
        
        //События для управляющего кода
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;  
    }
    
    public partial class MainForm : Form , IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            // Генерация событий на форме          
            // Слить, залить, вычислить
            //bFileOpen.Click += BFileOpenClick;
            // События внутри формы без выхода наружи(Задать)
            
        }

		#region IMainForm implementation
		public event EventHandler FileOpenClick;
		public event EventHandler FileSaveClick;
		public event EventHandler ContentChanged;
		
		public void SetSymbolCount(int count)
		{
			tsslblSymbolCount.Text=count.ToString() ;
		}
		public string FilePath {
			get {
				return tbFilePath.Text;
			}
		}
		public string Content {
			get {
				return tbContent.Text;
			}
			set {
				tbContent.Text = value;
			}
		}
		#endregion
        
        #region IMainForm event проброс для управляющего кода -- if (FileOPenClick !=0) FileOPenClick(this, EventArgs.Empty ); --
        
        void BFileOpenClick(object sender, EventArgs e)
		{
        	if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
		}
		
		void TbContentTextChanged(object sender, EventArgs e)
		{
			if(ContentChanged != null ) ContentChanged(this, EventArgs.Empty);
		}
		
		void BFileSaveClick(object sender, EventArgs e)
		{
			if(FileSaveClick != null) FileSaveClick(this, EventArgs.Empty);
		}
        #endregion
        
        #region MainForm event
        // Выбрать путь к файлу
        void BFileSelectClick(object sender, EventArgs e)
		{
        	OpenFileDialog dlg = new OpenFileDialog();
        		
        	dlg.Filter = "Текстовой файл|*.txt|Все файлы|*.*";
        		
        	if (dlg.ShowDialog() == DialogResult.OK )
        		{
        			tbFilePath.Text  = dlg.FileName;
        		if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        		}		

		}
        
        // Размер шрифта
        void NudFontSizeValueChanged(object sender, EventArgs e)
		{
        	tbContent.Font = new Font("arial", (float)nudFontSize.Value );	
		}
        
        #endregion
                        
    }
}