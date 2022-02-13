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
    public partial class Orders_optional : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        DishQueries dishQueries = new DishQueries();
        UnitsQueries unitQueries = new UnitsQueries();
        ProductQueries productsQueries = new ProductQueries();
        OrdersQueries ordersQueries = new OrdersQueries();
        SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter dataadapter;
        SqlDataReader reader;
        SqlCommand command;
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<Label> labels = new List<Label>();
        private int orderId;
        private int totalPrice = 0;
        private List<int> prices = new List<int>();
        public Orders_optional(Dictionary<string, object> dishState)
        {
            InitializeComponent();
            var orders = (CheckedListBox)dishState["orders"];
            this.orderId=(int)dishState["id"];
            for (int x = 0; x < orders.CheckedItems.Count; x++)
            {
                Label label = new Label();
                TextBox productTextBox = new TextBox();

                label.Location = new Point(100, 0 + x * 40);
                productTextBox.Location = new Point(0, 0 + x * 40);

                label.Text = orders.CheckedItems[x].ToString();

                panel1.Controls.Add(label);
                panel1.Controls.Add(productTextBox);

                textBoxes.Add(productTextBox);
                labels.Add(label);
            }
            getPrices();
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (textBoxes.Any(tb => tb.Text.Length != 0))
            {
                for (int i = 0; i < textBoxes.Count; i++)
                {
                    connection.Open();
                    command = new SqlCommand(ordersQueries.add, connection);
                    command.Parameters.Add("@amount", SqlDbType.VarChar);
                    command.Parameters["@amount"].Value = textBoxes[i].Text;

                    command.Parameters.Add("@orderId", SqlDbType.Int);
                    command.Parameters["@orderId"].Value = orderId;

                    command.Parameters.Add("@dishName", SqlDbType.VarChar);
                    command.Parameters["@dishName"].Value = (string)labels[i].Text;

                    var unit = command.ExecuteNonQuery();
                    connection.Close();
                }
                connection.Open();
                command = new SqlCommand(ordersQueries.updateOrder, connection);
                for (int i = 0; i < textBoxes.Count; i++)
                {
                    Console.WriteLine(prices[i]);
                    totalPrice += prices[i] * int.Parse(textBoxes[i].Text);
                }
                command.Parameters.Add("@price", SqlDbType.Int);
                command.Parameters["@price"].Value =totalPrice+totalPrice*0.1;//10% чаевых

                DateTime localDate = DateTime.Now;
                command.Parameters.Add("@date", SqlDbType.DateTime);
                command.Parameters["@date"].Value = localDate;

                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = orderId;
                var updateOrder = command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Заказ успешно создан");
                this.Close();
                Orders ordersForm = new Orders();
                ordersForm.Show();
            }
            else
            {
                MessageBox.Show("Заполните все формы");
            }
        }
        private void getPrices()
        {
            try
            {
                for (int i = 0; i < labels.Count; i++)
                {
                    connection.Open();
                    command = new SqlCommand(ordersQueries.getPrice, connection);
                    command.Parameters.Add("@dishName", SqlDbType.VarChar);
                    command.Parameters["@dishName"].Value = labels[i].Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            prices.Add((int)reader.GetValue(0));
                        }
                    }
                    connection.Close();
                }
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine("get all exception");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
