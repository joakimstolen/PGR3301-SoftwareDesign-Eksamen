using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SoftDesEksamen {
	class Program {
		
		
		static void Main(string[] args)
			{
				CarShop shop = new CarShop();
				Random random = new Random();


				List<Customer> customers = new List<Customer>()
				{
					new Customer("Brage", shop), 
					new Customer("Joakim", shop), 
					new Customer("Jon", shop),
					new Customer("Bjarne", shop),
					new Customer("Hans", shop)
				};
				
				List<SalesMan> salesMen = new List<SalesMan>()
				{
					new SalesMan("Kristoffer", shop), 
					new SalesMan("JonPus", shop), 
					new SalesMan("Tangen", shop),
					new SalesMan("Per", shop),
					new SalesMan("Tomas", shop)
				};
				
				
				
				Console.WriteLine("CarShop is now open, Welcome!");

				shop.Start();

				Console.WriteLine("\t\t\t\t\t\t<---------------Cars are being put out for sale--------------->");

				
				
				
				foreach (var salesman in salesMen) 
				{
					salesman.Start();
					

				}
				Thread.Sleep(5000);
				
				
				
				foreach (var salesman in salesMen)
				{
					salesman.Stop();
				}
				
				Console.WriteLine("\t\t\t\t\t\t<---------------Some customers are interested...--------------->");
				
				foreach (var customer in customers)
				{
					
					customer.Start();

				}

				foreach (var customer in customers) 
				{ 
					
					customer.Stop();
				}
				
				

				




				shop.Stop();
				Console.WriteLine("\t\t\t\t\t\t<---------------Store is closed--------------->");
				
				
				Console.WriteLine("\n\n Press any key to Exit");
				Console.ReadKey();
			}
		}
	}
