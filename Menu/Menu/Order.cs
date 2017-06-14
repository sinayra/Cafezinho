using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Menu {
    public class Order {
        private List<string> orders = new List<string>();

        public Order(string path) {
            string[] content = File.ReadAllLines(path);

            orders = content.ToList();
        }

        public Order(List<Item> items) {
            foreach(Item item in items) {
                orders.Add(item.Name);
            }
        }

        public double SumTotal(List<Item> items) {
            //double total = 0;
            //foreach(string order in orders) {
            //    Item result = items.Find(x => x.Name == order);
            //    total += result.Price;
            //}

            //Select
            //Where
            //Aggregate
            double total = orders.Select(order => items.First(item => item.Name == order).Price).Sum();

            return total;
        }
    }
}
