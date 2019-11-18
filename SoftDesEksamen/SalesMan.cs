using System;
namespace SoftDesEksamen {
	public class SalesMan : ThreadProxy
	{
		private CarShop _carShop;
		private string _name;

		public SalesMan(string name, CarShop carShop)
		{
			_name = name;
			_carShop = carShop;
		}


		protected override void Task()
		{
			while (!_carShop.hasCar && _running);
			ICar published = _carShop.PublishCar();
			if (published != null)
			{
				Console.WriteLine("{0} published a {1} for sale", _name, published.getType());
			}
		}
	}
	}
