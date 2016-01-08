/*
 * Created by SharpDevelop.
 * User: Дмитрий
 * Date: 31.12.2015
 * Time: 17:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Konverter
{
	public interface IMainForm
	{
		// Поля
		string  Cena{get;set;}
		string  Kurs{get;set;}
		
		//Метод
		void SetPrice(string price);
		
		//Событие пересчет
		event EventHandler PereschetClick;
		
	}

	public partial class MainForm : Form, IMainForm 
	{
		public MainForm()
		{

			InitializeComponent();

		}

		#region IMainForm implementation
		public event EventHandler PereschetClick;
		public string  Cena {
			get { if(tb_Cena.Text !="") return tb_Cena.Text ; else return "0" ;	}
			set { tb_Cena.Text=value.ToString() ;	}
		}
		public string  Kurs {
			get { if(tb_Kurs.Text != "") return tb_Kurs.Text; else return "0";			}
			set { tb_Kurs.Text = value.ToString();			}
		}

		public void SetPrice(string   price)
		{
			l_Price.Text = price.ToString();
			
		}

		#endregion		
		
		
		void Tb_CenaTextChanged(object sender, EventArgs e)
		{
	
		}
		void Tb_KursTextChanged(object sender, EventArgs e)
		{
	
		}
		void B_PereschetClick(object sender, EventArgs e)
		{
			if(PereschetClick != null) PereschetClick(this, EventArgs.Empty);	
		}
		
		void B_CloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void Tb_CenaKeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
			{
				if (!((e.KeyChar.ToString()==",") && (tb_Cena.Text.IndexOf(",")==-1))) e.Handled = true;
			}
		}
		void Tb_KursKeyPress(object sender, KeyPressEventArgs e)
		{
	            if(!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString()==",") && (tb_Kurs.Text.IndexOf(",")==-1))) e.Handled = true;
            }
		}
	}
}
