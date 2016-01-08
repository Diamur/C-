
using System;
using ElectroPower.BL;

namespace ElectroPower
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
        _view.PriceClick+= new EventHandler(_view_PriceClick);
               
        // Задание параметров формы при первоначальном запуске программы
        
               
        }
        
        
		void _view_PriceClick(object sender, EventArgs e)
		{
			
			
			try 
            {
				
				if(_view.Val2 > _view.Val1 )
				{
					double price = _model.GetPrice(_view.Val1 , _view.Val2 , _view.Cena);
					string finalPriceTextm = price.ToString("C");
					                               
					_view.SetPrice(finalPriceTextm);
				}
                else 
                	_messageService.ShowExclamation("Ошибка исходных данных!");
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
			
		}
    }
}
         