using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Customers
    {
        public static List<Customer> CustomerList = new List<Customer> { };

        public bool Add(Customer customer)
        {
            customer.Id = CustomerList.Count;
            CustomerList.Add(customer);
            return true;
        }

        public int getLength() { return CustomerList.Count; }

        public Customer getCustomerById(int Id)
        {
            return CustomerList[Id];
        }

        public bool Clear()
        {
            CustomerList.Clear();
            return true;
        }

        
    }
}
