﻿using System;
namespace SoftDesEksamen {
	public class StandarCar : ICar{

		private readonly int _price;
		private readonly string _colour;
		private readonly int _horsePower;
		private readonly int _seats;

		
		//constructor We have to choose what we will use in the random in car, evry parameter have to be called on there
		public StandarCar(int price, string colour, int horsePower, int seats)
			{
			price = _price;
			colour = _colour;
			horsePower = _horsePower;
			seats = _seats;
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
			throw new NotImplementedException();
		}
		
		public virtual int getSeats()
			{
			return _seats;
			}






		}
	}
