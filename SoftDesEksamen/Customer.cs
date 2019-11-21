using System;
using System.Collections;
using System.Collections.Generic;

namespace SoftDesEksamen
{
	public class Customer : ThreadProxy
	{
		private CarShop _carShop;
		public string _name { get; set; }
		private ICar _car { get; set; }
		

		public Customer(string name, CarShop carShop)
		{
			_name = name;
			_carShop = carShop;
			
		}
		

		public override void Task()
		{
			
            
		}
		public override void Task2()
		{
			
			while (_carShop.hasCar && _running)
			{
				SalesMan salesMan = new SalesMan();
				ICar bought = _carShop.BuyCar();
				if (bought != null)
				{
					Console.WriteLine(
						"\t\t\t\t\t\t\t\t\t\t {0} purchased {1} with {2} color and {3}", _name, bought.getType(), bought.getColour(), bought.getHorsePower());
				}    
			}
		}
	}
}
