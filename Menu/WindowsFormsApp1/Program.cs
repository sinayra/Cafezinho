using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Menu;

namespace WindowsFormsApp1 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string path = "../../../Menu/items.txt";
            string[] content = File.ReadAllLines(path);
            List<Item> items = new List<Item>();

            for (int i = 0; i < content.Length; i++) {

                items.Add(new Item(content[i]));
            }

            Application.Run(new CoffeeShop(items));
        }
    }
}
