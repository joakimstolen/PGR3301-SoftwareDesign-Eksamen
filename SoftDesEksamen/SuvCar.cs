﻿using System;
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
			return base.getColour() + " White";
			}

		public override int getSeats()
			{
			return base.getSeats() + 2;
			}

		public override int getHorsePower()
			{
			return base.getHorsePower() + 99;
			}


		}
	}