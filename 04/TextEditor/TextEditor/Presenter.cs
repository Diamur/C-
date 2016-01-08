using System;
using TextEditor.BL;

namespace TextEditor
{
    public class Presenter
    {
        private readonly IMainForm _view;
        private readonly IFileManager _manager;
        private readonly IMessageService _messageService;
        private string _currentFilePath;
        
        public Presenter( IMainForm view, IFileManager manager, IMessageService service)
        {
            _view = view;
            _manager = manager;
            _messageService = service;
            
        //События которые нужно залить слить обсчитать
        // _view.FileOPenClick += new EventHandler(_view_FileOPenClick);
        _view.ContentChanged += new EventHandler(_view_ContentChanged);
        _view.FileOpenClick += new EventHandler (_view_FileOpenClick);
        _view.FileSaveClick += new EventHandler (_view_FileSaveClick);
        
        _view.SetSymbolCount(0);
                
        
        }
       
        
		// Изменение контента
		void _view_ContentChanged(object sender, EventArgs e)
		{
			string content = _view.Content ;
			
			int count = _manager.GetSymbolCount (content );
			
			_view.SetSymbolCount(count);
		}
		
		// Открыть файл	
		void _view_FileOpenClick(object sender, EventArgs e)
		{
			try 
            {
				
				string filePath = _view.FilePath ;
				
				bool isExist = _manager.IsExist(filePath);
				
				if (!isExist)
				{
					_messageService.ShowExclamation ("Выбранного файла не существует");
					return;
				}
				
				_currentFilePath = filePath;
				
				string content = _manager.GetContent(filePath);
				
				_view.Content= content ;
				
				int count = _manager.GetSymbolCount(content);
				
				_view.SetSymbolCount(count);
				
				
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }

		}
				
		// Сохранить файл
		void _view_FileSaveClick(object sender, EventArgs e)
		{
			try 
            {
				string content = _view.Content ;
				
				_manager.SaveContent (_currentFilePath, content);
				
				_messageService.ShowMessage ("Файл успешно сохранен");
                
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
			
		}
    }
}