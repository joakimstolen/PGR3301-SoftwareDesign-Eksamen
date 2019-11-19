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

		protected override void Task()
		{
			Thread.Sleep(random.Next(50, 400));
			MakeCar();
		}

		public ICar BuyCar()
		{
			lock (_lock)
			{
				if (_cars.Count > 0)
				{
					ICar carsToSell = _cars[0];
					_cars.RemoveAt(0);
					return carsToSell;
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
				if (_cars.Count > 0)
				{
					ICar carsToSell = _cars[0];
					_cars.RemoveAt(0);
					return carsToSell;
				}
				else
				{
					return null;
				}
			}
		}
	}
	}
