using System;
namespace SoftDesEksamen {
	public class SalesMan : ThreadProxy
	{
		private CarShop _carShop;
		public string _name { get; set; }

		public virtual string getName()
		{
			return _name;
		}

		public SalesMan()
		{
			_name = getName();
		}
		

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
						Console.WriteLine("{0} published a {1} for sale", _name, published.getType());
				}
			}
		}

		public override void Task2()
		{
			
		}
	}
	}
