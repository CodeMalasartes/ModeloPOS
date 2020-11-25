using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloPOS
{
    public class Customer : Person
    {
        public Customer() { }

        private int CustomerId;
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int CustomerNIF { get; set; }

        //static List<Customer> customers;

        public Customer(Customer customer)
        {
            this.CustomerId += PersonId;
            this.CustomerName = customer.CustomerName;
            this.CustomerAddress = customer.CustomerAddress;
            this.CustomerNIF = customer.CustomerNIF;
        }
        public void ShowCustomers(List<Customer> c)
        {
           foreach(Customer item in c)
            {
                Console.WriteLine("ID: " + item.CustomerId + " Nome: " + item.CustomerName
                                + " Morada: " + item.CustomerAddress + " NIF: " + item.CustomerNIF);
            }
            
        }

        /*public bool AddCustomer(Customer customer)
        {
            customers = new List<Customer>();
            Console.WriteLine("Criando Customer...");
            customers.Add(customer);
            ShowCustomers(customers);
            return true;
        }*/
    
        public void RemoveCustomer(Customer customer)
        {
            //customers.Remove(customer);
        }

    }
}
