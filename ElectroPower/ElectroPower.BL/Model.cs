
using System;

namespace ElectroPower.BL
{
	public interface IModel
	{
		double GetPrice(int val1, int val2, double cena);
		
	}

	public class Model: IModel 
	{
		// Задачи
		// Посчитать Стоимость
		
		public double GetPrice(int val1, int val2, double cena)
		{
			return (val2 - val1) * cena ;
		}
		

	}
}
