using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //101
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35, };
            Product product3 = new Product { Id = 3, CategoryId = 9, UnitInStock = 4, ProductName = "Telefon", UnitPrice = 1000, };

            //PascalCase  //camelCase
            //case sensitive 
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Update(product2);
            Console.WriteLine(product2.ProductName);
            productManager.Delete(product3);
            Console.WriteLine(product3.Id); 


        }
    }
}
