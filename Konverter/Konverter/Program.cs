
using System;
using System.Windows.Forms;
using Konverter.BL;

namespace Konverter
{

	internal sealed class Program
	{

		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			MainForm form = new MainForm();
			Model model =new Model();
			MessageService mess = new MessageService();
			Presenter presenter = new Presenter ( form, model, mess );
			
			
			Application.Run(form );
		}
		
	}
}
