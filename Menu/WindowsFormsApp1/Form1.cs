using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu;

namespace WindowsFormsApp1 {
    public partial class CoffeeShop : Form {
        private List<Item> Items = new List<Item>();

        public CoffeeShop(List<Item> items) {
            Items = items;
            InitializeComponent();

            for (int i = 0; i < Items.Count; i++) {
                listBoxItems.Items.Add(Items[i]);
            }

            listBoxItems.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {
            Item item = Items[listBoxItems.SelectedIndex];
            listBoxOrder.Items.Add(item);
        }

        private void listBoxOrder_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e) {
            List < Item > items = listBoxOrder.Items.Cast<Item>().ToList();
            Order orders = new Order(items);

            double total = orders.SumTotal(Items);

            MessageBox.Show(string.Format("{0:C}", total), "Total to pay");
            listBoxOrder.Items.Clear();
        }
    }
}
