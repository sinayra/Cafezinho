using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Menu {
    class Order {
        List<string> orders = new List<string>();

        public Order(string path) {
            string[] content = File.ReadAllLines(path);

            orders = content.ToList();
        }

        public double SumTotal(List<Item> items) {
            double total = 0;
            foreach(string order in orders) {
                Item result = items.Find(x => x.Name == order);
                total += result.Price;
            }

            return total;

        }
    }
}
