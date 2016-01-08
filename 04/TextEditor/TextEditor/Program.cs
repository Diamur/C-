
using System;
using System.Windows.Forms;
using TextEditor.BL;

namespace TextEditor
{

	internal sealed class Program
	{

		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			//---собственный код----
			MainForm form = new MainForm();
			MessageService service = new MessageService();
			FileManager manager = new FileManager();
			
			Presenter presenter = new Presenter(form, manager, service );
			//----------------------
						
			Application.Run(form);
		}
		
	}
}
