﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace SoftDesEksamen {
	public class CarShop : ThreadProxy
	{
		private List<ICar> _cars;
		private List<SalesMan> _salesMen;
		Random random;

		private readonly object _lock = new Object();
		
		public bool hasCar
		{
			get => _cars.Count > 0;
		}

		public CarShop()
		{
			_cars = new List<ICar>();
			_salesMen = new List<SalesMan>();
			random = new Random();
		}

		public override void Task()
		{
			Thread.Sleep(random.Next(50, 400));
			PublishCar();
		}

		public override void Task2()
		{
			Thread.Sleep(random.Next(50, 400));
			BuyCar();
		}
		

		public ICar BuyCar()
		{
			lock (_lock)
			{
				if (_cars.Count > 0)
				{
					var test = _cars[0];
					_cars[0].getType();
					Thread.Sleep(100);
					_cars.RemoveAt(0);
					return test;
				}
				else
				{
					return null;
				}
			}
		}

		void MakeCar()
		{
			lock (_lock)
			{
				_cars.Add(CarFactory.CreateRandomCar());
			}
		}

		public ICar PublishCar()
		{
			lock (_lock)
			{
				if (_cars.Count >= 0)
				{
					var test = CarFactory.CreateRandomCar(); 
					Thread.Sleep(100);
					_cars.Add(test);
					return test;
				}
				else
				{
					return null;
				}
			}
		}
	}
	}
