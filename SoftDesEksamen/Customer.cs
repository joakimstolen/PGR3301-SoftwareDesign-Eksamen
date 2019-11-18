using System;

namespace SoftDesEksamen
{
	public class Customer : ThreadProxy
	{
		private CarShop _carShop;
		private string _name;

		public Customer(string name, CarShop carShop)
		{
			_name = name;
			_carShop = carShop;
		}

		protected override void Task()
		{
			while (!_carShop.hasCar && _running) ;
			ICar bought = _carShop.BuyCar();
			if (bought != null)
			{
				Console.WriteLine("\t\t\t\t\t\t\t\t\t\t {0} bought a {1} that has {2} seats, with color {3} and price {4}", _name, bought.getType(), bought.getSeats(), bought.getColour(), bought.getPrice());
			}
		}
	}
}
