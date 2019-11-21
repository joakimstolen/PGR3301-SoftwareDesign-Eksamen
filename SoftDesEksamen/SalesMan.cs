using System;
namespace SoftDesEksamen {
	public class SalesMan : ThreadProxy
	{
		private CarShop _carShop;
		public string _name { get; set; }
		

		public SalesMan(string name, CarShop carShop)
		{
			_name = name;
			_carShop = carShop;
		}

		public override void Task() {
			while (!_carShop.hasCar && _running)
			{
				ICar published = _carShop.PublishCar();
					if (published != null) { 
						Console.WriteLine("{0} published a {1} for sale for {2} kr", _name, published.getType(), published.getPrice());
				}
			}
		}

		public override void Task2()
		{
			return;
		}
	}
	}
