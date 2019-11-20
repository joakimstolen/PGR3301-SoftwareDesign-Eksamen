using System;
using System.Collections.Generic;
using System.Threading;

namespace SoftDesEksamen {
	class Program {
		static void Main(string[] args)
			{
				CarShop shop = new CarShop();

				List<Customer> customers = new List<Customer>()
				{
					new Customer("Brage"), 
					new Customer("Joakim"), 
					new Customer("Jon"),
					new Customer("Bjarne"),
					new Customer("Hans")
				};
				List<SalesMan> salesMen = new List<SalesMan>()
				{
					new SalesMan("Kristoffer"), 
					new SalesMan("JonPus"), 
					new SalesMan("Tangen"),
					new SalesMan("Per"),
					new SalesMan("Tomas")
				};


				List<AssignCustomerToSalesman> customerAndSalesman = new List<AssignCustomerToSalesman>()
				{
					new AssignCustomerToSalesman(customers, salesMen, shop)
				};
				
				
				Console.WriteLine("CarShop is now open, Welcome!");

				shop.Start();


				foreach (var assigner in customerAndSalesman)
				{
					assigner.Start();
				}
				
				Thread.Sleep(4000);

				foreach (var assigner in customerAndSalesman)
				{
					assigner.Stop();
				}
				
				
				
				shop.Stop();
				
				
				Console.WriteLine("\n\n Press any key to Exit");
				Console.ReadKey();
			}
		}
	}
