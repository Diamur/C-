using System.Windows.Forms;

namespace TextEditor
{	
	//Интерфейс
	public interface IMainForm
	{
		//Поля для управляющего кода
		
		//Методы для управляющего кода
		
		//События для управляющего кода		
		
	}

	public partial class MainForm : Form, IMainForm 
	{
		public MainForm()
		{
			InitializeComponent();
			// Генерация событий на форме
			// Слить, залить, вычислить
			// 
		}
		
		#region IMainForm implemant
		#endregion
		
		#region IMainForm event
		#endregion
		
		#region MainForm event
		#endregion
						
	}
}
