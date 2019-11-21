using System;
using System.Collections.Generic;
using System.Threading;

namespace SoftDesEksamen
{
    public class AssignCustomerToSalesman : ThreadProxy
    {

        private List<Customer> _customer;
        private List<SalesMan> _salesMan;
        private List<ICar> _cars;
        private CarShop _carShop;
        
        
        
        
        Random random = new Random();

        public AssignCustomerToSalesman(List<Customer> customer, List<SalesMan> salesMan, CarShop carShop)
        {
            _customer = customer;
            _salesMan = salesMan;
            _carShop = carShop;
        }

        public override void Task()
        {
            while (!_carShop.hasCar && _running)
            {
                ICar published = _carShop.PublishCar();
                if (published != null)
                {
                    var index = random.Next(_customer.Count);
                    var index2 = random.Next(_salesMan.Count);
                    Console.WriteLine("{0} published a {1} for sale", _salesMan[index2]._name, published.getType());
                    //Console.WriteLine("\t\t\t\t\t\t\t\t\t\t {0} purchased {1} from {2}", _customer[index]._name, published.getType(), _salesMan[index2]._name);
                    Thread.Sleep(100);
                }
            }
        }

        public override void Task2()
        {
            while (_carShop.hasCar && _running)
            {
                ICar buy = _carShop.CustomerBuyCar();
                if (_cars != null)
                {
                    var index = random.Next(_customer.Count);
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t {0} purchased {1} ", _customer[index]._name, buy.getType());
                    Thread.Sleep(200);

                }
                else
                {
                    Console.WriteLine("No car Availible.");
                    Thread.Sleep(200);
                }
            }

        }

        protected void Create()
        {
            while (_carShop.hasCar) ;
            ICar published = _carShop.PublishCar();
            _cars.Add(published);
            int i = 0;
            i++;
            Console.WriteLine(" published a {0} for sale", published.getType());
            if (i > 10) ;
            {
                return;
            }
           
        }
        
        /* Self NOTE!!
         To make this crap work this is what i have to do:
         fix the new loops in Program, buy and sell.
         Make the List in CarShop WOrk Propperly, then two threads starded the same way as the for each in program are started.
         make 2 buyers buy simultaniously, then call a final method if a thread is sucsessful or not.
         Make the thread for salesman call on the make method.
         Writing to the console have to be done by the thread, called by referance, t1-t3 with each variable of input.
         
         If this does not work i give upp completly.
         */
        
/*
        protected void Buy()
        {
            while (_cars.Count > 0);
            {
                var index = random.Next(_customer.Count);
                var index2 = random.Next(_salesMan.Count);
                _cars.RemoveAt[0];
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t {0} purchased {1} from {2}", _customer[index]._name, _cars.getType(), _salesMan[index2]._name);
            }
        }
        */

    }
}