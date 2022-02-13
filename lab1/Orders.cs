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
    public partial class Orders : Form
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
        public Orders()
        {
            InitializeComponent();
            getAll();
            getDishes();
        }
        public void getDishes()
        {

            List<string> dishes = new List<string>();
            connection.Open();
            command = new SqlCommand(ordersQueries.getDishes, connection);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dishes.Add((string)reader.GetValue(0));
                }
            }

            string[] products = dishes.ToArray();
            checkBoxProducts.Items.AddRange(products);
            connection.Close();

        }

        private void getAll()
        {
            try
            {
                connection.Open();
                command = new SqlCommand(ordersQueries.getAllOrders, connection);
                dataadapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
               
                dataadapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void addBtn(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxProducts.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Не выбраны блюда");
                }
                else
                {
                    connection.Open();
                    command = new SqlCommand(ordersQueries.addEmpty, connection);
                    int id = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    var orderMap = new Dictionary<string, object>();
                    orderMap.Add("orders", checkBoxProducts);
                    orderMap.Add("id",id);
                    Orders_optional orders_optional = new Orders_optional(orderMap);
                    orders_optional.Show();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { 
            
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Заполните поле Id");
            }
            else
            {
                connection.Open();
                command = new SqlCommand(ordersQueries.delete, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = textBoxId.Text;
                var unit = command.ExecuteNonQuery();
                connection.Close();
                getAll();
                textBoxId.Clear();
                MessageBox.Show("Успешно удалено");
            }
        }

        private void Cell_click(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void Cell_doubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            StringBuilder products = new StringBuilder("В заказе присутствуют такие блюда как:\n");
            Console.WriteLine("dbl");
            connection.Open();
            command = new SqlCommand(ordersQueries.getDescAboutorder, connection);
            command.Parameters.Add("@orderId", SqlDbType.Int);
            command.Parameters["@orderId"].Value = orderId;
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object name = reader.GetValue(0);
                    object amount = reader.GetValue(1);
                    object unit = reader.GetValue(2);
                    products.Append($"{name} в количестве {amount} {unit}, ");
                }
                products.Remove(products.Length - 2, 2);
            }
            connection.Close();
            MessageBox.Show(products.ToString());
        }

        private void desc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалить - заполните поле ID \n\nДобавить - выберите блюда");
        }
    }
}
