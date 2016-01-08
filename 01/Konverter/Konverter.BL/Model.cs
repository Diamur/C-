using System;

namespace Konverter.BL
{
  
    public interface IModel
    {
    	double  GetValuta(double price, double kurs);
    }
    
    public class Model: IModel  
    {
        // Поля текущего класса
        
        // Задачи, которые решает программа
        // Вычисляем валюту по курсу
        
        public double  GetValuta(double price, double kurs)
        {
        	return price * kurs ;
        }
        

    }
    
}