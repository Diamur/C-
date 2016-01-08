/*
 * Created by SharpDevelop.
 * User: Дмитрий
 * Date: 09.01.2016
 * Time: 15:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hi
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
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
		void MainFormPaint(object sender, PaintEventArgs e)
		{
			string st;
			int x, y ;
			SizeF stSize;
			
			Font hFont = new Font("Tahoma", 20 , FontStyle.Bold);
			Font tFont = new Font("Tahoma", 15 , FontStyle.Italic );
			
			
			st = "Загаловок";
			
			stSize = e.Graphics.MeasureString(st, hFont);
			
			x= (int)(this.ClientSize.Width - stSize.Width)/2;
			y = 50;
			
			
			e.Graphics.DrawString(st, hFont, Brushes.Black, x, y);
			
			stSize = e.Graphics.MeasureString(st, tFont);
			
			x= (int)(this.ClientSize.Width - stSize.Width)/2;
			y += (int)stSize.Height;
			
			
			e.Graphics.DrawString(st, tFont, Brushes.Black, x, y);
			
			Pen p = new Pen(Color.Black, 1);
			e.Graphics.DrawArc(p,10,10,50,50,0,360);
	
		}
		void MainFormResize(object sender, EventArgs e)
		{
			this.Refresh();
	
		}
	}
}
