﻿using System;
namespace SoftDesEksamen {
	public class CarFactory {

		public static ICar CreateRandomCar()
			{

			Random random = new Random();
			ICar car = new StandarCar(random.Next());

			}


		}
	}
