﻿using System;

namespace OOPGeneral
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Oslo";
            customer.Id = 1;
            customer.FirstName = "Denny";
            customer.LastName = "Denver";

            Customer customer2 = new Customer
            {
                Id = 2, City = "Paris", FirstName = "Ramos", LastName = "Sergio"
            };

            Console.WriteLine(customer2.FirstName);

        }

        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Customer Added");
            }

            public void Update()
            {
                Console.WriteLine("Customer Updated");
            }
        }

        class ProductManager
        {
            public void Add()
            {
                Console.WriteLine("Customer Added");
            }

            public void Update()
            {
                Console.WriteLine("Customer Updated");
            }
        }
    }
}
