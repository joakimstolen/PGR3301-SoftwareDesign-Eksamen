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
				
				List<SalesMan> salesmen = new List<SalesMan>()
				{
					new SalesMan("Tommy", shop),
					new SalesMan("Fredrik", shop),
					new SalesMan("Anders", shop),
					new SalesMan("Rob", shop)
				};

				
				Console.WriteLine("CarShop is now open, Welcome!");
				
				shop.Start();

				foreach (var salesman in salesmen)
				{
					salesman.Start();
				}
				
				foreach (var customer in customers)
				{
					customer.Start();
				}
				
				Thread.Sleep(3000);
				
				foreach (var salesman in salesmen)
				{
					salesman.Stop();
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
