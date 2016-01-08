
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Konverter
{

	public partial class MainForm : Form, IMainForm 
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		#region IMainForm implementation


		public event EventHandler PereschetClick;


		public void SetValuta(string valutaFinal)
		{
			l_Valuta.Text=valutaFinal ;
		}


		public string Price {
			get { return tb_Price.Text ;		}
		}

		public string Kurs {
			get {return tb_Kurs.Text ;			}
		}


		#endregion

		void Tb_PriceKeyPress(object sender, KeyPressEventArgs e)
		{
			            if(!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString()==",") && (tb_Price.Text.IndexOf(",")==-1))) e.Handled = true;
            }
	
		}
		void Tb_KursKeyPress(object sender, KeyPressEventArgs e)
		{
	            if(!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString()==",") && (tb_Kurs.Text.IndexOf(",")==-1))) e.Handled = true;
            }
		}
		
		void B_PereschetClick(object sender, EventArgs e)
		{
			if(PereschetClick!= null) PereschetClick(this, EventArgs.Empty);
		}
		
		// Закрыть
		void B_CloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
	
	public interface IMainForm
	{
		// Поля
		string Price{get;}
		string Kurs{get;}
		
		// Методы
		void SetValuta(string valutaFinal);
		
		// События
		event EventHandler PereschetClick;
		
	}
}
