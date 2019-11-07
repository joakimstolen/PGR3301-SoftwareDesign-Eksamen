using System;
namespace SoftDesEksamen {
	public class Customer : IPerson {

		private readonly string _firstName;
		private readonly string _lastName;


		public Customer(string firstName, string lastName)
			{
			firstName = _firstName;
			lastName = _lastName;
			}


		public virtual string getFirstName()
			{
			return _firstName;
			}
		public virtual string getLastName()
			{
			return _lastName;
			}



		}
	}
