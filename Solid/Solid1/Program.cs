using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    // Порушено Single responsibility principle
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    class Order
    {
        private List<Item> itemList;

        public List<Item> ItemList
        {
            get { return itemList; }
            set { itemList = value; }
        }

        public void AddItem(Item item)
        {
            itemList.Add(item);
        }

        public void DeleteItem(Item item)
        {
            itemList.Remove(item);
        }

        public int GetItemCount()
        {
            return itemList.Count;
        }

        public void ShowOrder()
        {
            foreach (var item in itemList)
            {
                Console.WriteLine($"Item: {item.Name}, Price: {item.Price}");
            }
        }
    }

    class Invoice
    {
        public decimal CalculateTotalSum(Order order)
        {
            decimal total = 0;
            foreach (var item in order.ItemList)
            {
                total += item.Price;
            }
            return total;
        }
    }
    class OrderService
    {
        public void Load(Order order)
        {
            Console.WriteLine("Order loaded.");
        }

        public void Save(Order order)
        {
            Console.WriteLine("Order saved.");
        }

        public void Update(Order order)
        {
            Console.WriteLine("Order updated.");
        }

        public void Delete(Order order)
        {
            Console.WriteLine("Order deleted.");
        }
    }

    class Program
    {
        static void Main()
        {
            Order order = new Order();
            order.AddItem(new Item("Item1", 10.0m));
            order.AddItem(new Item("Item2", 20.0m));
            order.AddItem(new Item("Item3", 30.0m));

            order.ShowOrder();

            Invoice invoice = new Invoice();
            decimal totalSum = invoice.CalculateTotalSum(order);
            Console.WriteLine($"Total Sum: {totalSum}");

            OrderService orderService = new OrderService();
            orderService.Save(order);
            orderService.Load(order);
            orderService.Update(order);
            orderService.Delete(order);
        }
    }
}
