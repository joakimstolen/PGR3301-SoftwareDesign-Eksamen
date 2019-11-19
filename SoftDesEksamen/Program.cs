using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace SoftDesEksamen {
	class Program {
		static void Main(string[] args)
			{
				CarShop shop = new CarShop();

				/*
				List<SalesMan> salesmen = new List<SalesMan>()
				{
					new SalesMan("Tommy", shop),
					new SalesMan("Fredrik", shop),
					new SalesMan("Anders", shop),
					new SalesMan("Rob", shop)
				};
				*/
				

				List<string> customers = new List<string>()
				{
					"Joakim",
					"Jan",
					"Brage"
				};

				
				var random = new Random();
				int index = random.Next(0, customers.Count);
				Customer randomCustomer = new Customer(customers[index]);
				Console.WriteLine(randomCustomer);
				
				
				
				
				
				

				Customer customer1 = new Customer("Jon");
				Customer customer2 = new Customer("Joakim");
				Customer customer3 = new Customer("Eskild");
				Customer customer4 = new Customer("Jens");
				
				SalesMan salesMan1 = new SalesMan("Tommy");
				SalesMan salesMan2 = new SalesMan("Geir");
				SalesMan salesMan3 = new SalesMan("Andy");
				SalesMan salesMan4 = new SalesMan("Birger");
				
				
				List<AssignCustomerToSalesman> customerAndSalesman = new List<AssignCustomerToSalesman>()
				{
					new AssignCustomerToSalesman(randomCustomer, salesMan1, shop),
					new AssignCustomerToSalesman(randomCustomer, salesMan2, shop)
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
