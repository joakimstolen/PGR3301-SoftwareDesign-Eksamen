using System;

namespace SoftDesEksamen
{
    public class AssignCustomerToSalesman : ThreadProxy
    {

        private Customer _customer;
        private SalesMan _salesMan;
        private CarShop _carShop;

        public AssignCustomerToSalesman(Customer customer, SalesMan salesMan, CarShop carShop)
        {
            _customer = customer;
            _salesMan = salesMan;
            _carShop = carShop;
        }
        
        protected override void Task()
        {
            while (!_carShop.hasCar && _running) ;
            ICar published = _carShop.PublishCar();
            if (published != null)
            {
                Console.WriteLine("{0} published a {1} for sale", _salesMan._name, published.getType());
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t {0} purchased {1} from {2}", _customer._name, published.getType(), _salesMan._name);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t {0} purchased {1} from {2}", _customer._name, published.getType(), _salesMan._name);
            }
        }
        
        
    }
}