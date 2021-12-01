using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class CustomerManager
    {
        public void Listele(Customer customer)
        {
            Console.WriteLine("Müşteri Listelendi." + " " + customer.Name + " " + customer.LastName);
        }

        public void Ekle(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi." + " " + customer.Name + " " + customer.LastName);
        }

        public void Sil(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi." + " " + customer.Name + " " + customer.LastName);
        }
    }
}
