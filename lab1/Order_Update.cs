using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Order_Update : Form
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

        private List<Label> labels = new List<Label>();
        private List<TextBox> textBoxes = new List<TextBox>();
        private int orderId;
        public Order_Update(Dictionary<string, object> orderState)
        {
            InitializeComponent();
            var orders = (CheckedListBox)orderState["orders"];
            this.orderId = (int)orderState["orderId"];
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
        }
       
       
        private void addBtn_Click(object sender, EventArgs e)
        {
            StringBuilder successMessage = new StringBuilder($"\tВаш заказ № {orderId}\n");
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
                command = new SqlCommand(ordersQueries.getOrderPrice, connection);
                command.Parameters.Add("@orderId", SqlDbType.Int);
                command.Parameters["@orderId"].Value = orderId;
                reader = command.ExecuteReader();
                int sum = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int price = (int)reader.GetValue(0);
                        int amount = (int)reader.GetValue(1);
                        sum += price * amount;
                    }
                }
                sum += (int)Math.Round(sum * 0.1);
                connection.Close();
                connection.Open();
                command = new SqlCommand(ordersQueries.updateOrder, connection);
                command.Parameters.Add("@price", SqlDbType.Int);
                command.Parameters["@price"].Value = sum;

                DateTime localDate = DateTime.Now;
                command.Parameters.Add("@date", SqlDbType.DateTime);
                command.Parameters["@date"].Value = localDate;

                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = orderId;
                
                var updateOrder = command.ExecuteNonQuery();
                connection.Close();
                writeOrder(successMessage, sum);
                this.Close();
                Orders ordersForm = new Orders();
                ordersForm.Show();
            }
            else
            {
                MessageBox.Show("Заполните все формы");
            }
        }
        private void writeOrder(StringBuilder message,int sum)
        {
            string writePath = @"C:\Users\Professional\Desktop\orders\order" + orderId+".txt";
            connection.Open();
            command = new SqlCommand(ordersQueries.getFullInfoOrder, connection);
            command.Parameters.Add("@orderId", SqlDbType.Int);
            command.Parameters["@orderId"].Value = orderId;

            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    string name = reader.GetValue(0).ToString();
                    int amount = (int)reader.GetValue(1);
                    int price = (int)reader.GetValue(2);
                    int totalPrice = (int)reader.GetValue(3);
                    string date = reader.GetValue(4).ToString();
                    message.Append($"{name} - {price}сом * {amount} = {amount*price} сом\n");
                }
            }
            message.Append("+10% чаевых\n");
            message.Append($"Сумма {sum}сом");
            MessageBox.Show(message.ToString());
            
            connection.Close();
            FileInfo fileInf = new FileInfo(writePath);
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(message);
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
