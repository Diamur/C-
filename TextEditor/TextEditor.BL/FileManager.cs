using System.IO;
using System.Text;

namespace TextEditor.BL
{
	public class FileManager
	{
		// Добавим кодировку по-умолчанию
		private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);
	
		// Проверяем существования файла
		public bool IsExist(string filePath)
		{
			bool isExist = File.Exists(filePath);
			return isExist;
		}
				
		// Добавляем перегруженный метод который вызывает основной метод 
		public string GetContent(string filePath)
		{
			return GetContent(filePath, _defaultEncoding);
		}
		
		// 1. Открыть текстовой файл
		public string GetContent(string filePath, Encoding encoding)
		{
			string content = File.ReadAllText(filePath,encoding );
			return content;
		}
		
		// Добавляем перегруженный метод для сохранения с кодировкой по-умолчанию
		public void SaveContent(string content, string filePath)
		{
			SaveContent(content, filePath, _defaultEncoding);
		}		
				
		// 2. Сохраняем файл
		public void SaveContent(string content, string filePath, Encoding encoding)
		{
			File.WriteAllText(filePath,content,encoding);
		}
		
		// 3. Подсчет количества символов в тексте
		public int GetSymbolCount(string content)
		{
			int count = content.Length;
			return count;
		}
		
	}
}
