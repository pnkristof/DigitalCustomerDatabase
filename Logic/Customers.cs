using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class Customers
    {
        public static List<Customer> CustomerList = new List<Customer> { };

        public bool Add(Customer customer)
        {
            customer.Id = CustomerList.Max(x => x.Id)+1;
            CustomerList.Add(customer);
            return true;
        }

        public bool Remove(int Id)
        {
            CustomerList.Remove(getCustomerById(Id));
            return true;
        }

        public int getLength() { return CustomerList.Count; }

        public Customer getCustomerById(int Id)
        {
            return CustomerList.SingleOrDefault(x => x.Id == Id);
        }

        public bool Clear()
        {
            CustomerList.Clear();
            return true;
        }


    }
}
