using System;


namespace Konverter.BL
{
	public interface IModel
	{
		double  GetPrice(double cena, double kurs);
	}

	public class Model: IModel 
	{
		// Подсчитать курс по цене
		
		public double  GetPrice(double cena, double kurs)
		{
			return cena * kurs;
		}
	}
}
