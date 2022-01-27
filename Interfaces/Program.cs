using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Dolby", LastName = "Tomas", Address = "Viyana" });

            Student student = new Student
            {
                Id = 1,
                FirstName = "Alex",
                LastName = "Albert",
                Department = "Computer Science"
            };

            manager.Add(student);
            Customer customer = new Customer();
            manager.Add(customer);
        }
    }

    interface IPerson // soyut nesnedir.
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson //Interface de yer alan bilgiler burada implement (uygulamak) edilir.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }
    class Student : IPerson //Interface de yer alan bilgiler burada implement (uygulamak) edilir.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
