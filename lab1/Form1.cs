using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void unitsBtn_Click(object sender, EventArgs e)
        {
            Units unit = new Units();
            unit.Show();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
        }

        private void dishTypeBtn_Click(object sender, EventArgs e)
        {
            DishType dishType = new DishType();
            dishType.Show();
        }

        private void dishBtn_Click(object sender, EventArgs e)
        {
            Dish dish = new Dish();
            dish.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }
    }
}
