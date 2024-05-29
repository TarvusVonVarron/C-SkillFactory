using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module7.FinalTask
{

    abstract class Delivery
    {
        private string _adress;
        public string Address { get; set; }
        public abstract void CalculateDeliveryCost();

    }

    class HomeDelivery : Delivery
    {
        public string CourierName { get; set; }
        public override void CalculateDeliveryCost() { }
    }

    class PickPointDelivery : Delivery
    {
        public string PickPointAddress { get; set; }
        public string Company { get; set; }
        public override void CalculateDeliveryCost() { }
    }

    class ShopDelivery : Delivery
    {
        public string ShopName { get; set; }

        public override void CalculateDeliveryCost() { }
    }

    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery { get; set; }
        public List<Product> Products { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        public void CalculateTotalCost() { }
        public void PrintDetails<T>(T item) { }
        public void CreateDelivery<T2>(params object[] args) where T2 : Delivery { }
        public static Order<TDelivery> operator +(Order<TDelivery> order1, Order<TDelivery> order2) { return new Order<TDelivery>(); }
    }
    class OrderCollection<TDelivery> where TDelivery : Delivery
    {
        public static List<Order<TDelivery>> Orders { get; set; }
        public void AddOrder(Order<TDelivery> order) { }
        public void RemoveOrder(int orderNumber) { }
    }
    class ExtendedOrder<TDelivery, TProduct> : Order<TDelivery> where TDelivery : Delivery
    {
        public string ProductDetails { get; set; }
        public void AddProduct(TProduct product) { }
    }
    class Customer
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Customer(string name, string phoneNumber, string email) { }
    }

    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price, int quantity) { }
    }
    static class CustomerExtensions
    {
        public static bool IsValidEmail(this Customer customer)
        {
            return true;
        }
    }

    class OrderAggregator <TDelivery> where TDelivery: Delivery
    {
        public List<Order<TDelivery>> Orders { get; set; }
        public void GetTotalOrders() { }
        public void GetTotalRevenue() { }
    }
    class OrderIndexer<TDelivery> where TDelivery : Delivery
    {
        public Order<TDelivery>[] OrderList { get; set; }
        public Order<TDelivery> this[int index]
        {
            get
            {
                return OrderList[index];
            }

            private set
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < OrderList.Length)
                {
                    OrderList[index] = value;
                }
            }
        }

    }
    internal class FinalTask
    {

        public static void Run()
        {

        }
    }
}
