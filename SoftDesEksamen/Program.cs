using System;
using System.Collections.Generic;
using System.Threading;

namespace SoftDesEksamen {
	class Program {
		static void Main(string[] args)
		{
			carshop(out var shop, out var customers, out var salesMen, out var customerAndSalesman);
			AssignCustomerToSalesman acts = new AssignCustomerToSalesman(carshop(customers), carshop(shop), );
		}

		private static void carshop(out CarShop shop, out List<Customer> customers, out List<SalesMan> salesMen, out List<AssignCustomerToSalesman> customerAndSalesman)
		{
			shop = new CarShop();
			customers = new List<Customer>()
			{
				new Customer("Brage"),
				new Customer("Joakim"),
				new Customer("Jon")
			};
			salesMen = new List<SalesMan>()
			{
				new SalesMan("Kristoffer"),
				new SalesMan("JonPus"),
				new SalesMan("Tangen")
			};


			customerAndSalesman = new List<AssignCustomerToSalesman>()
			{
				new AssignCustomerToSalesman(customers, salesMen, shop)
			};

			Thread t1 = new Thread(new ThreadStart(customerAndSalesman.Task));
			Thread t2 = new Thread(new ThreadStart(shop.Task2));
			Thread t3 = new Thread(new ThreadStart(shop.Task2));

			Console.WriteLine("CarShop is now open, Welcome!");
			
			t1.Start();
			t2.Start();
			t3.Start();
			
			foreach (var assigner in customerAndSalesman)
			{
				assigner.Start();
			}

			for (int i = 0; i < 10; i++)
			{
			}


			Thread.Sleep(2000);


			foreach (var assigner in customerAndSalesman)
			{
				assigner.Stop();
			}


			Console.WriteLine("\n\n Press any key to Exit");
			Console.ReadKey();
		}
	}
	}
