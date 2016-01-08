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
        
        public Presenter( IMainForm view, IModel model , IMessageService messageService)
        {
            _view = view;
            _model = model;
            _messageService = messageService;
            
        //События которые нужно залить слить обсчитать
        // _view.FileOPenClick += new EventHandler(_view_FileOPenClick);
               
        // Задание параметров формы при первоначальном запуске программы
        
        _view.Cena="0";
        _view.Kurs="0";
        _view.PereschetClick+= new EventHandler(_view_PereschetClick);  
        }
                 
        
		void _view_PereschetClick(object sender, EventArgs e)
		{
			
			
			
			try 
            {
				
				if (_view.Cena=="0" || _view.Kurs =="0")
				{
					_messageService.ShowExclamation("Введтие данные");
					return;
				}
				
				_view.SetPrice(double.Parse(_view.Cena).ToString("N") + " USD = " + _model.GetPrice(double.Parse(_view.Cena), double.Parse(_view.Kurs )).ToString("C"));
                
            }
            catch (Exception ex)
            {
            	_messageService.ShowError(ex.Message );
		        //_messageService.ShowError(ex.Message);
            }
			
		}
    
     }
}
         