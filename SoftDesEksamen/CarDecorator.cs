﻿namespace SoftDesEksamen {
	public class CarDecorator : ICar{

		private readonly ICar _originalCar;

		protected CarDecorator(ICar originalCar)
			{
			_originalCar = originalCar;
			}

		public virtual double getPrice()
			{
			return _originalCar.getPrice();
			}

		public virtual string getColour()
			{
			return _originalCar.getColour();
			}

		public virtual int getHorsePower()
			{
			return _originalCar.getHorsePower();
			}
		

		public virtual string getType()
		{
			return _originalCar.getType();
		}
		
	}
	}
