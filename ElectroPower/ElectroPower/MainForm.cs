
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ElectroPower
{
	public partial class MainForm : Form, IMainForm
	{
		public MainForm()
		{
			InitializeComponent();
			b_Price.Enabled=false;
		}

		#region IMainForm implementation


		public event EventHandler PriceClick;


		public void SetPrice(string priceFinalText)
		{
			l_Price.Text = priceFinalText;
		}


		public int Val1 {
			get { return int.Parse(tb_Val1.Text); }
		}


		public int Val2 {
			get { return int.Parse(tb_Val2.Text); }
		}

		public double Cena {
			get { return double.Parse(tb_Price.Text);	}
		}

		#endregion

		void B_CloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void Tb_Val1KeyPress(object sender, KeyPressEventArgs e)
		{
			 if(!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))  e.Handled = true;
		    if(e.KeyChar.Equals((char)13)) tb_Val2.Focus();
				 
		}
		
		void Tb_Val2KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))  e.Handled = true;
			if(e.KeyChar.Equals((char)13)) tb_Price.Focus();			
	    }

				
		void Tb_PriceKeyPress(object sender, KeyPressEventArgs e)
		{
		    if(!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString()==",") && (tb_Price.Text.IndexOf(",")==-1))) e.Handled = true;
            }
		    
		    if(e.KeyChar.Equals((char)13)) b_Price.Focus();
	
		}
		
		void B_PriceClick(object sender, EventArgs e)
		{
			if(PriceClick!= null) PriceClick(this,EventArgs.Empty );
		}

		
	#region  Контроль доступности кнопок	
		void Tb_Val1KeyUp(object sender, KeyEventArgs e)
		{
			// Контроль доступности кнопок
			if( (tb_Val1.Text.Length > 0) &&
			    (tb_Val2.Text.Length > 0) &&
			    (tb_Price.Text.Length >0))
				b_Price.Enabled= true ;
			else
				b_Price.Enabled=false;
			
		}
		void Tb_Val2KeyUp(object sender, KeyEventArgs e)
		{
			// Контроль доступности кнопок
			if( (tb_Val1.Text.Length > 0) &&
			    (tb_Val2.Text.Length > 0) &&
			    (tb_Price.Text.Length >0))
				b_Price.Enabled= true ;
			else
				b_Price.Enabled=false;
	
		}
		void Tb_PriceKeyUp(object sender, KeyEventArgs e)
		{
			// Контроль доступности кнопок
			if( (tb_Val1.Text.Length > 0) &&
			    (tb_Val2.Text.Length > 0) &&
			    (tb_Price.Text.Length >0))
				b_Price.Enabled= true ;
			else
				b_Price.Enabled=false;
		}
	#endregion 

	}
	
		public interface IMainForm
	{
        //Поля для управляющего кода
        int Val1 {get;}
        int Val2 {get;}
        double Cena{get;}
        
        //Методы для управляющего кода для действий над формой
        void SetPrice(string  priceFinalText);
                
        //События для управляющего кода
        event EventHandler PriceClick;
        
	}
}
