
using System;
using System.Windows.Forms;
using ElectroPower.BL;

namespace ElectroPower
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            MainForm form = new MainForm ();
            Model model = new Model();
            MessageService     messageService= new MessageService();
            
            Presenter presenter = new Presenter (form, model, messageService );
        
            Application.Run(form);
		}
		
	}
}
