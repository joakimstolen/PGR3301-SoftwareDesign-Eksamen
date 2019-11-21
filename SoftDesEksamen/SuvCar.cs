using System;
namespace SoftDesEksamen {
	public class SuvCar : CarDecorator{

		public SuvCar(ICar originalCar)
			: base(originalCar)
			{

			}

		public override double getPrice()
			{
			return base.getPrice() + 499_999;
			}
		public override string getColour()
			{
			return "White";
			}
		

		public override int getHorsePower()
			{
			return base.getHorsePower() + 99;
			}

		public override string getType()
		{
			return "SUV";
		}
	}
	}
