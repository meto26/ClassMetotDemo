using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName ="Mete Han ";
            customer1.LastName = "Çavdar";            
            customer1.EMail = "metehan262626@gmail.com";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Meto";
            customer2.LastName = "Meto";            
            customer2.EMail = "metometo@gmail.com";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Engin";
            customer3.LastName = "Demiroğ";
            customer3.EMail = "Engindemirog@gmail.com";


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.List();


           

        }
    }
}
