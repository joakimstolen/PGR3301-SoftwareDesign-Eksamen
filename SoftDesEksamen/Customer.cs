using System;
using System.Collections;
using System.Collections.Generic;

namespace SoftDesEksamen
{
	public class Customer : ThreadProxy
	{
		private CarShop _carShop;

		public SalesMan SalesMan
		{
			get => _salesMan;
			set => _salesMan = value;
		}

		public string _name { get; set; }
		private ICar _car { get; set; }


		SalesMan _salesMan = new SalesMan();
		



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
				
				ICar bought = _carShop.BuyCar();
				if (bought != null)
				{
					Console.WriteLine(
						"\t\t\t\t\t\t\t\t\t\t {0} purchased {1} with {2} color and {3} horsepower", _name, bought.getType(), bought.getColour(), bought.getHorsePower());
				}    
			}
		}
	}
}
