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
    public partial class Otchet : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        OtchetQueries oq = new OtchetQueries();
        SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter dataadapter;
        SqlDataReader reader;
        SqlCommand command;
        int sumDishesOrder = 0;
        public Otchet()
        {
            InitializeComponent();
            getAll();
            getSumOfDishesFromOrder();
            label_sum.Text = $"Общий заработок {sumDishesOrder} сом";
        }
        private void getAll()
        {
            try
            {
                command = new SqlCommand(oq.getDishesFromOrders, connection);
                dataadapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                connection.Open();
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
        private void getSumOfDishesFromOrder()
        {
            try
            {
                connection.Open();
                command = new SqlCommand(oq.getSumDishesFromOrders, connection);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sumDishesOrder +=(int)reader.GetValue(0);
                    }
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
