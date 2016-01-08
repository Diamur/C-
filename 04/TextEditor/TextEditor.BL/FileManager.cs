using System;
using System.IO;
using System.Text;

namespace TextEditor.BL
{
	public interface IFileManager
	{
		bool IsExist(string filePath);
		string  GetContent(string filePath, Encoding encoding);
		string GetContent(string filePath);
		void SaveContent(string filePath, string content, Encoding encoding);
		void SaveContent(string filePath, string content);
		int GetSymbolCount(string content);
	}

	public class FileManager: IFileManager 
	{
		//Поля
		private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);
		
		//Проверить существования файла
		public bool IsExist(string filePath)
		{
			return File.Exists(filePath);
		}
		
		//Взять контент с файла
		// с кодировкой
		public string  GetContent(string filePath, Encoding encoding)
		{
			return File.ReadAllText(filePath, encoding);
		}
		
		// без кодировки
		public string GetContent(string filePath)
		{
			return GetContent(filePath, _defaultEncoding );
		}
		
		//сохранить файл
		// с кодировкой 
		public void SaveContent(string filePath, string content, Encoding encoding)
		{
			File.WriteAllText(filePath,content,encoding);
		}
		
		//без кодировкой
		public void SaveContent(string filePath, string content)
		{
			SaveContent(filePath,content , _defaultEncoding);
		}
		
		//Взять кол-во символов из текста	
		public int GetSymbolCount(string content)
		{
			return content.Length;
		}

	}
}
