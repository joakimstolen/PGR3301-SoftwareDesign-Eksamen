﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace SoftDesEksamen {
	public class CarShop : ThreadProxy
	{
		private List<ICar> _cars;
		Random random;

		private readonly object _lock = new Object();
		
		public bool hasCar
		{
			get => _cars.Count > 0;
		}

		public CarShop()
		{
			_cars = new List<ICar>();
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
					Thread.Sleep(2000);
					_cars[0].getType();
					_cars.RemoveAt(0);
					return test;
				}
				else
				{
					return null;
				}
			}
		}
		

		public ICar PublishCar()
		{
			lock (_lock)
			{
				if (_cars.Count >= 0)
				{
					Thread.Sleep(2000);
					var test = CarFactory.CreateRandomCar();
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
