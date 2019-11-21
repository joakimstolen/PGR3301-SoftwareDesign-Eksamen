using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace SoftDesEksamen
{
	public class Customer : ThreadProxy
	{
		private CarShop _carShop;
		public string _name { get; set; }




		public Customer(string name, CarShop carShop)
		{
			_name = name;
			_carShop = carShop;
			
		}
		

		public override void Task() 
		{
			return;
		}
		
		
		public override void Task2()
		{
			
			while (_carShop.hasCar && _running)
			{
				
				ICar bought = _carShop.BuyCar();
				if (bought != null)
				{
					Console.WriteLine(
						"\t\t\t\t\t\t\t\t\t\t {0} purchased {1} with {2} color and {3} horsepower for {4} kr", _name, bought.getType(), bought.getColour(), bought.getHorsePower(), bought.getPrice());
				}    
			}
		}
	}
}
