using System;
using System.Collections.Generic;

namespace SoftDesEksamen
{
    public class AssignCustomerToSalesman : ThreadProxy
    {

        private List<Customer> _customer;
        private List<SalesMan> _salesMan;
        private CarShop _carShop;
        Random random = new Random();

        public AssignCustomerToSalesman(List<Customer> customer, List<SalesMan> salesMan, CarShop carShop)
        {
            _customer = customer;
            _salesMan = salesMan;
            _carShop = carShop;
        }

        protected override void Task()
        {
            while (!_carShop.hasCar && _running);
            ICar published = _carShop.PublishCar();
            if (published != null)
            {
                var index = random.Next(_customer.Count);
                var index2 = random.Next(_salesMan.Count);
                Console.WriteLine("{0} published a {1} for sale", _salesMan[index2]._name, published.getType());
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t {0} purchased {1} from {2}", _customer[index]._name, published.getType(), _salesMan[index2]._name);
            }
        }
        
        
    }
}