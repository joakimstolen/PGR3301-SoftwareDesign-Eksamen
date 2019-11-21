using System;
namespace SoftDesEksamen {
	public class StandarCar : ICar{

		private readonly int _price = 0;
		private readonly string _colour = "Basic color";
		private readonly int _horsePower = 500;
		private readonly int _seats = 5;
		private readonly string _type = "Basic car";


		//constructor We have to choose what we will use in the random in car, evry parameter have to be called on there
		public StandarCar(int price, string colour, int horsePower, int seats, string type)
			{
			price = _price;
			colour = _colour;
			horsePower = _horsePower;
			seats = _seats;
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
		
		public virtual int getSeats()
			{
			return _seats;
			}

		public string getType()
		{
			return _type;
		}
	}
	}
