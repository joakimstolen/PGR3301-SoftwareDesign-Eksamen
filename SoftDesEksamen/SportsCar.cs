﻿using System;
namespace SoftDesEksamen {
	public class SportsCar : CarDecorator {

		public SportsCar(ICar originalCar)
			: base(originalCar)
			{

			}

		public override double getPrice()
			{
			return base.getPrice() + 2_500_000;
			}
		
		public override string getColour()
			{
			return "Red";
			}
		

		public override int getHorsePower()
			{
			return base.getHorsePower() + 450;
			}

		public override string getType()
		{
			return "Sports car";
		}
	}
	}
