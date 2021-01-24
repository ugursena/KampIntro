using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jack Smith
            Individual customer1 = new Individual();
            customer1.Id = 8;
            customer1.CustomerNo = "12345";
            customer1.Name = "Jack";
            customer1.Surname = "Smith";
            customer1.TcNo = "98765432100";

            //Kodlama.io

            Cooparete customer2 = new Cooparete();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri 
            //Solid

            Customer musteri3 = new Individual();
            Customer musteri4 = new Cooparete();

            CustomerManager  customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



        }
    }
}
