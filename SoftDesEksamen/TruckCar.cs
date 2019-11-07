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
			return base.getColour() + " Yellow";
			}

		public override int getSeats()
			{
			return base.getSeats() - 1;
			}

		public override int getHorsePower()
			{
			return base.getHorsePower() + 240;
			}


		}
	}