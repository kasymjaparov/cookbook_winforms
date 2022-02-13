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
    public partial class Product : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        ProductQueries productQueries = new ProductQueries();
        UnitsQueries unitQueries = new UnitsQueries();
        SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter dataadapter;
        SqlDataReader reader;
        SqlCommand command;
        Messages messages = new Messages();
        public Product()
        {
            InitializeComponent();
            getAll();
            getUnits();
        }
        private void btnUnitUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand(productQueries.update, connection);

            command.Parameters.Add("@name", SqlDbType.VarChar);
            command.Parameters["@name"].Value = textBoxName.Text;

            command.Parameters.Add("@price", SqlDbType.Int);
            command.Parameters["@price"].Value = textBoxPrice.Text;

            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters["@id"].Value = textBoxId.Text;

            command.Parameters.Add("@unitName", SqlDbType.VarChar);
            command.Parameters["@unitName"].Value = comboBoxUnits.SelectedItem;

            var unit = command.ExecuteNonQuery();
            connection.Close();
            getAll();
            textBoxName.Clear();
            textBoxId.Clear();
            textBoxPrice.Clear();
            MessageBox.Show(messages.successChanged);
        }

        private void addBtnClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxPrice.Text))
                {
                    MessageBox.Show(messages.validationPriceNameForm);
                }
                else {
                    connection.Open();
                    command = new SqlCommand(productQueries.add, connection);
                    command.Parameters.Add("@name", SqlDbType.VarChar);
                    command.Parameters["@name"].Value = textBoxName.Text;
                    command.Parameters.Add("@price", SqlDbType.Int);
                    command.Parameters["@price"].Value = textBoxPrice.Text;
                    command.Parameters.Add("@unitName", SqlDbType.VarChar);
                    command.Parameters["@unitName"].Value = comboBoxUnits.SelectedItem;
                    var unit = command.ExecuteNonQuery();
                    connection.Close();
                    getAll();
                    MessageBox.Show(messages.successAdded);
                    connection.Close();
                }            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                textBoxName.Clear();
                textBoxPrice.Clear();
                textBoxId.Clear();
                connection.Close();
            }
            
        }
        private void getAll()
        {
            try
            {
                command = new SqlCommand(productQueries.getAll, connection);
                dataadapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                connection.Open();
                dataadapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
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

        private void btnUnitsDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show(messages.validationIdForm);
            }
            else
            {
                connection.Open();
                command = new SqlCommand(productQueries.delete, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = textBoxId.Text;
                var unit = command.ExecuteNonQuery();
                connection.Close();
                getAll();
                textBoxId.Clear();
                MessageBox.Show(messages.successDeleted);
            }
        }
        private void getUnits()
        {
            List<string> units = new List<string>();
            connection.Open();
            command = new SqlCommand(unitQueries.getAllUnitForComboBox, connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    units.Add((string)reader.GetValue(0));
                }
            }
            foreach (string unitName in units)
            {
                comboBoxUnits.Items.Add(unitName);
            }
            comboBoxUnits.SelectedIndex = 0;
            comboBoxUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            connection.Close();
        }

        private void BtnAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Удалить - заполните поле ID \n\nДобавить - заполните поля Название, Ед.изм, Цена\n\nИзменить - заполните поля ID, Ед.изм, Название, Цена");
        }
    }
}
