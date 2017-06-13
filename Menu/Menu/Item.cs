using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu {
    class Item {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Item(string line) {
            string[] content = line.Split(':');
            Name = content[0];

            content = content[1].Split('$');
            Price = double.Parse(content[1]);
        }
    }
}
