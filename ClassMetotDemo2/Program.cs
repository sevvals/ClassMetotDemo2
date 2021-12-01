using System;

namespace ClassMetotDemo2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Name = "Ali";
            c1.LastName = "Yılmaz";
            c1.Id = 1;

            Customer c2 = new Customer();
            c2.Name = "Ayşe";
            c2.LastName = "Ay";
            c2.Id = 2;

            Customer c3 = new Customer();
            c3.Name = "Emine";
            c3.LastName = "Yıldız";
            c3.Id = 3;

            Customer c4 = new Customer();
            c4.Name = "Aslı";
            c4.LastName = "Öz";
            c4.Id = 4;

            Customer[] customers = new Customer[] { c1, c2, c3, c4 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Listele(c3);
            customerManager.Ekle(c1);
            customerManager.Sil(c4);

        }
    }
}
