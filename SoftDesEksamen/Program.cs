using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace SoftDesEksamen {
	class Program {
		static void Main(string[] args)
			{
				CarShop shop = new CarShop();
				List<Customer> customers = new List<Customer>()
				{
					new Customer("Jon", shop),
					new Customer("Joakim", shop),
					new Customer("Eskild", shop),
					new Customer("Kris", shop)
				};
				
				shop.Start();
				foreach (var customer in customers)
				{
					customer.Start();
				}
				
				Thread.Sleep(3000);

				foreach (var customer in customers)
				{
					customer.Stop();
				}
				
				shop.Stop();
				
				Console.WriteLine("\n\n Press any key to Exit");
				Console.ReadKey();
			}
		}
	}
