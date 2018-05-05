using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndreyAndBilliard
{
    class Program
    {
        static void Main()
        {
            
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();

            getProductsAndPrices(products);

            string line = Console.ReadLine();
            List<Customer> customers = new List<Customer>();
            while(line != "end of clients")
            {
                var info = line.Split(new char[] { '-',','});
                string name = info[0];
                string product = info[1];
                int quantity = int.Parse(info[2]);

                if (products.ContainsKey(product))
                {
                    Customer customer = new Customer();
                    customer.Name = name;
                    customer.productsAndQuantity = new Dictionary<string, int>();
                    customer.productsAndQuantity.Add(product, quantity);
                    
                    

                    if (customers.Any(x => x.Name == customer.Name))
                    {
                        var cust = customers.Where(x => x.Name == customer.Name).First();
                        if (cust.productsAndQuantity.ContainsKey(product))
                        {
                            cust.productsAndQuantity[product] += quantity;
                        }
                        else
                        {
                            cust.productsAndQuantity.Add(product, quantity);
                        }

                        //cust.Bill = customer.Bill + products[product] * quantity;
                    }

                    else
                    {
                        customers.Add(customer);
                    }
                    
                }
                line = Console.ReadLine();

                foreach (var c in customers)
                {
                    foreach (var item in c.productsAndQuantity)
                    {
                        foreach (var p in products)
                        {
                            if (item.Key == p.Key)
                            {
                                c.Bill = item.Value * p.Value;
                            }
                    }
                    }
                }
            }

            decimal totalBill = 0m;
            foreach (var c in customers.OrderBy(s => s.Name))
            {
                Console.WriteLine(c.Name);
                foreach (var productAndQuantity in c.productsAndQuantity)
                {
                    Console.WriteLine($"-- {productAndQuantity.Key} - {productAndQuantity.Value}");
                }
                Console.WriteLine($"Bill: {c.Bill:f2}");
                totalBill += c.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }

        private static void getProductsAndPrices(Dictionary<string, decimal> products)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split('-');
                var product = line[0];
                var price = decimal.Parse(line[1]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, 0);
                }
                products[product] = price;
            }
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> productsAndQuantity { get; set; }
        public decimal Bill { get; set; }
    }
}
