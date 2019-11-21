﻿﻿using System;
 using System.Collections.Generic;

 namespace SoftDesEksamen {
	public class CarFactory {

		public static ICar CreateRandomCar()
			{

			Random random = new Random();
			ICar car = new StandarCar(random.Next(250_000,579_890), "green", 240, 5, "classic car");
			List<ICar> _car;
			
			if (random.Next(2) == 1) {
				car = new SuvCar(car);
			} else if (random.Next(2) == 1) {
				car = new TruckCar(car);
			} else if (random.Next(2) == 1) {
				car = new SportsCar(car);
			}

			return car;

			}


		}
	}
