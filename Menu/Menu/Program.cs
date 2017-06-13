using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Menu {
    class Program {
        static void Main(string[] args) {

            //Itens
            string path = "../../items.txt";
            string[] content = File.ReadAllLines(path);
            List<Item> items = new List<Item>();
            List<Order> orders = new List<Order>();

            for (int i = 0; i < content.Length; i++) {

                items.Add(new Item(content[i]));
            }

            for(int i = 0; i < items.Count; i++) {
                Console.WriteLine($"{i + 1}: {items[i].Name} - R${items[i].Price}");
            }

            //Orders
            for(int i = 0; i < 2; i++) {
                path = $"../../orders{i + 1}.txt";
                orders.Add(new Order(path));
            }

            for(int i = 0; i < orders.Count; i++) {
                Console.WriteLine($"Pedido { i + 1} - R${orders[i].SumTotal(items)}");
            }
            Console.ReadKey();
        }
    }
}
