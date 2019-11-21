using System;
namespace SoftDesEksamen {
	public class TruckCar : CarDecorator {

		public TruckCar(ICar originalCar)
			: base(originalCar)
			{

			}

		public override double getPrice()
			{
			return base.getPrice() + 759_000;
			}
		public override string getColour()
			{
			return "Yellow";
			}
		

		public override int getHorsePower()
			{
			return base.getHorsePower() + 240;
			}

		public override string getType()
		{
			return "Truck";
		}
	}
	}