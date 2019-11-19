using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace SoftDesEksamen {
	class Program {
		static void Main(string[] args)
			{
				CarShop shop = new CarShop();
				Random random = new Random();

				/*
				List<SalesMan> salesmen = new List<SalesMan>()
				{
					new SalesMan("Tommy", shop),
					new SalesMan("Fredrik", shop),
					new SalesMan("Anders", shop),
					new SalesMan("Rob", shop)
				};
				*/


				List<Customer> customers = new List<Customer>()
				{
					new Customer("Jon"),
					new Customer("Joakim"),
					new Customer("Fredrik"),
					new Customer("Eskild"),
					new Customer("Jonathan"),
					new Customer("Brage"),
					new Customer("Maya"),
					new Customer("Per"),
				};
				

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
					new AssignCustomerToSalesman(customer1, salesMan1, shop),
					new AssignCustomerToSalesman(customer2, salesMan2, shop)
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
