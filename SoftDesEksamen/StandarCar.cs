using System;
namespace SoftDesEksamen {
	public class StandarCar : ICar{

		private readonly int _price = 100000;
		private readonly string _colour = "Basic color";
		private readonly int _horsePower = 500;
		private readonly string _type = "Basic car";

		
		public StandarCar(int price, string colour, int horsePower, string type)
			{
			price = _price;
			colour = _colour;
			horsePower = _horsePower;
			type = _type;
			
			}


		public virtual double getPrice()
			{
			return _price;
			}

		public virtual string getColour()
			{
			return _colour;
			}

		public int getHorsePower()
		{
			return _horsePower;
		}
		

		public string getType()
		{
			return _type;
		}
	}
	}
