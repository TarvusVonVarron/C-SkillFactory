using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.FinalTask
{
    abstract class Delivery
    {
        public string Address;
    }

    class HomeDelivery : Delivery
    {
        /* ... */
    }

    class PickPointDelivery : Delivery
    {
        /* ... */
    }

    class ShopDelivery : Delivery
    {
        /* ... */
    }

    class Order<TDelivery,
    TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;
        public List<Product> Products;

        public int Number;

        public string Description;

        public void DisplayAddress(List<Product> products)
        {
            this.Products = products;
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
    }

    class Product
    {
        public string Name;
        public string Description;
        public int Cost;

        public Product[] Products;
    }

    internal class FinalTask
    {
        public static void Run()
        {

        }
    }
}
