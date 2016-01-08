using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyClipBoard
{   

        
    
    public partial class MainForm : Form , IMainForm 
    {
        public MainForm()
        {
            InitializeComponent();
            // Генерация событий на форме, если с формы не заданы автоматом
            // Слить, залить, вычислить
            // События внутри формы без выхода наружи(Задать)
            
        }

		#region IMainForm implementation
		public void SetContent()
		{
			tb_Content.Text = Clipboard.GetText;
		}
		public string Bufer {
			get { return Clipboard.GetText() ;			}
			set { Clipboard.SetText(value) ;			}
		}

		public string Content {
			get { return tb_Content.Text ; 		}
			set { tb_Content.Text = value ;			}
		}

		public event EventHandler b_CopyClick;

		public event EventHandler b_ClearClick;

		#endregion        


        
        #region IMainForm event проброс для управляющего кода -- if (FileOPenClick !=null) FileOPenClick(this, EventArgs.Empty ); --
//if ( !=null) (this, EventArgs.Empty );

		void B_ClearClick(object sender, EventArgs e)
		{			if ( b_ClearClick!=null) b_ClearClick(this, EventArgs.Empty );
		}
		void B_CopyClick(object sender, EventArgs e)
		{
			if(b_CopyClick != null) b_CopyClick(this, EventArgs.Empty);
	
		}
        #endregion
        
        #region MainForm event
        
        
        #endregion
                        
    }
    
    	//Интерфейс
    public interface IMainForm
    {
        //Поля для управляющего кода
        string Bufer{get;set;}
        string Content{get;set ;}
        
        //Методы для управляющего кода для действий над формой
        void SetContent();
        
        //События для управляющего кода        
        event EventHandler b_CopyClick;
        event EventHandler b_ClearClick;
    }     
    
    
}