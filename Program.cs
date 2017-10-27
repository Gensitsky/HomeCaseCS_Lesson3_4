/*
    Описать структуру Request содержащую поля: код
    заказа; клиент; дата заказа; перечень заказанных товаров;
    сумма заказа (реализовать вычисляемым свойством).
*/
using System;
using System.Linq;

namespace HomeCaseCS_Lesson3_4
{
    struct Request
    {
        private int orderId;
        private string orderClient;
        private DateTime orderDate;
        private string[] orderItems;
        private double[] orderUnits;
        private double orderTotal;

        public Request(int id, string client, DateTime date,
            string[] items, double[] units)
        {
            orderId = id;
            orderClient = client;
            orderDate = date;
            orderItems = items;
            orderUnits = units;
            orderTotal = units.Sum();
        }

        public void PrintRequest()
        {
            Console.WriteLine($"Id: {orderId}");
            Console.WriteLine($"Client: {orderClient}");
            Console.WriteLine($"Date: {orderDate}");
            Console.Write("Order Items: ");
            foreach (var item in orderItems)
            {
                Console.Write(item + " | ");
            }
            Console.Write("\nOrder Units: ");
            foreach (var item in orderUnits)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine($"\nTotal: {orderTotal}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] items1 = { "Notebook", "Printer", "Desktop" };
            double[] units1 = { 18000, 5000, 10000 };
            string[] items2 = { "Notebook", "Smartphone", "Desktop" };
            double[] units2 = { 18000, 15000, 10000 };


            Request order1 = new Request(1, "Vadim Gensitsky",
                DateTime.Now.Date, items1, units1);
            Request order2 = new Request(2, "Vlad Tkachenko",
                DateTime.Now.Date, items2, units2);

            order1.PrintRequest();
            order2.PrintRequest();

            Console.ReadKey();
        }
    }
}
