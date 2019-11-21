﻿using System;
using System.Collections.Generic;
 using System.Security.Cryptography.X509Certificates;
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
			Thread.Sleep(random.Next(20, 200));
			PublishCar();
		}

		public override void Task2()
		{
			Thread.Sleep(random.Next(200,500));
			CustomerBuyCar();
		}


		/*
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
		*/

		public ICar PublishCar()
		{
			lock (_lock)
			{
				int i = 0;
				if (_cars.Count < 10)
				{
					
					var makeCar = CarFactory.CreateRandomCar();
					_cars.Add(makeCar);
					ICar carsToSell = _cars[0];
					Console.WriteLine("Published a car of type {0}", carsToSell.getType());
					i++;
					return carsToSell;
				}
				else
				{
					Console.WriteLine("Nothing Published");
					return null;
				}
			}
		}

		public ICar CustomerBuyCar()
		{
			lock(_lock)
			{
				if (_cars.Count > 0)
				{
					ICar carsToSell = _cars[0];
					_cars.RemoveAt(0);
					Console.WriteLine("\t\t\t\t\t\t\t\t\t\tCustomer bought a car");
					return carsToSell;
					
				}
				else
				{
					Console.WriteLine("NothingBuyed");
					return null;
				}
			}
		}
	}
 }
