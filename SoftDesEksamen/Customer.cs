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
				Console.WriteLine("{0} bought a {1}", _name, bought.getPrice());
			}
		}
	}
}
