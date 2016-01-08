using System;
using System.IO;
using System.Text;

namespace TextEditor.BL
{
	public interface IFileManager
	{
		
	}
	
	
	public class FileManager
	{
		// Поля текущего класса
		private readonly Encoding _defaultencoding = Encoding.GetEncoding(1251);
		
        // Задачи, которые решает программа
        // Контент и файл
        // - Взять контент, открыв файл с указанием кодировки
        public string  GetContent(string filePath, Encoding encoding )
        {
        	return File.ReadAllText(filePath, encoding);
        }
        
        // - Взять контент, открыв файл с кодировкой по-умолчанию
        
        // Описание задачи2
        // -Подзадача1
        // -Подзадача2
	
	
	}
}
