
using System;
using Konverter.BL;

namespace Konverter
{
     public class Presenter
    {
        private readonly IMainForm _view;
        private readonly IModel _model;
        private readonly IMessageService _messageService;
// собственные поля для многократного использования в этом классе 
        
        public Presenter( IMainForm view, IModel model, IMessageService messageService)
        {
            _view = view;
            _model = model;
            _messageService = messageService;
            
        //События которые нужно залить слить обсчитать
        // _view.FileOPenClick += new EventHandler(_view_FileOPenClick);
               
        // Задание параметров формы при первоначальном запуске программы
        _view.PereschetClick+= new EventHandler(_view_PereschetClick);
        
        }
        
		void _view_PereschetClick(object sender, EventArgs e)
		{
			try 
            {
				double valuta = _model.GetValuta(double.Parse(_view.Price), double.Parse(_view.Kurs));
				string valutafinal = double.Parse(_view.Price).ToString("N") + " USD = " + valuta.ToString("C");
				_view.SetValuta( valutafinal );
				
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
		}
    }
}