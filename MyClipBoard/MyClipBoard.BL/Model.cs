using System;


namespace MyClipBoard.BL
{
  // Копировать отсюда 
 
    public interface IModel
    {
    	string GetContent( string content);
    	
    }
    
    public class Model: IModel
    {
        // Поля текущего класса
        
        // Взять контент
        public string GetContent(string content)
        {
        	return content;
        }
        
        
    }
    
}

