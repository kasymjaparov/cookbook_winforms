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

    public partial class Dish : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        DishQueries dishQueries = new DishQueries();
        UnitsQueries unitQueries = new UnitsQueries();
        ProductQueries productsQueries = new ProductQueries();
        SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter dataadapter;
        SqlDataReader reader;
        SqlCommand command;
        Messages messages = new Messages();
        public Dish()
        {
            InitializeComponent();
            getAll();
            getUnits();
            getTypes();
            getProducts();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалить - заполните поле ID \n\nДобавить - заполните поля Название, Ед.изм, Цена, Тип блюда\n\nИзменить - заполните поля ID, Ед.изм, Название, Цена, Тип блюда");
        }

        private void addDish_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxPrice.Text) || checkBoxProducts.CheckedItems.Count == 0)
                {
                    MessageBox.Show(messages.validationPriceNameProductForm);
                }
                else
                {
                    connection.Open();
                    command = new SqlCommand(dishQueries.add, connection);
                    command.Parameters.Add("@name", SqlDbType.VarChar);
                    command.Parameters["@name"].Value = textBoxName.Text;
                    command.Parameters.Add("@price", SqlDbType.Int);
                    command.Parameters["@price"].Value = textBoxPrice.Text;
                    command.Parameters.Add("@unitName", SqlDbType.VarChar);
                    command.Parameters["@unitName"].Value = comboBoxUnits.SelectedItem;
                    command.Parameters.Add("@typeName", SqlDbType.VarChar);
                    command.Parameters["@typeName"].Value = comboBoxTypes.SelectedItem;
                    var unit = command.ExecuteNonQuery();
                    connection.Close();
                    getAll();
                    
                    connection.Close();

                    var recipeMap = new Dictionary<string, object>();
                    recipeMap.Add("name", textBoxName.Text);
                    recipeMap.Add("price", textBoxPrice.Text);
                    recipeMap.Add("unitName", comboBoxUnits.SelectedItem);
                    recipeMap.Add("typeName", comboBoxTypes.SelectedItem);
                    recipeMap.Add("products", checkBoxProducts);
                    Recipe recipe = new Recipe(recipeMap,"add");
                    recipe.Show();
                }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally
            {
                textBoxName.Clear();
                textBoxPrice.Clear();
                textBoxId.Clear();
                connection.Close();
            }
        }

        private void changeDish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxPrice.Text) || string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show(messages.validationPriceNameForm);
            }
            else
            {
                connection.Open();
                command = new SqlCommand(dishQueries.update, connection);

                command.Parameters.Add("@name", SqlDbType.VarChar);
                command.Parameters["@name"].Value = textBoxName.Text;

                command.Parameters.Add("@price", SqlDbType.Int);
                command.Parameters["@price"].Value = textBoxPrice.Text;

                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = textBoxId.Text;

                command.Parameters.Add("@unitName", SqlDbType.VarChar);
                command.Parameters["@unitName"].Value = comboBoxUnits.SelectedItem;

                command.Parameters.Add("@typeName", SqlDbType.VarChar);
                command.Parameters["@typeName"].Value = comboBoxTypes.SelectedItem;


                var unit = command.ExecuteNonQuery();
                connection.Close();
                getAll();
                

                var recipeMap = new Dictionary<string, object>();
                recipeMap.Add("id", textBoxId.Text);
                recipeMap.Add("name", textBoxName.Text);
                recipeMap.Add("price", textBoxPrice.Text);
                recipeMap.Add("unitName", comboBoxUnits.SelectedItem);
                recipeMap.Add("typeName", comboBoxTypes.SelectedItem);
                recipeMap.Add("products", checkBoxProducts);
                Recipe recipe = new Recipe(recipeMap, "change");
                recipe.Show();
            }
        }

        private void deleteDish_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show(messages.validationIdForm);
            }
            else
            {
                connection.Open();
                command = new SqlCommand(dishQueries.delete, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = textBoxId.Text;
                var unit = command.ExecuteNonQuery();
                connection.Close();
                getAll();
                textBoxId.Clear();
                MessageBox.Show(messages.successDeleted);
            }

        }
        private void getAll()
        {
            try
            {
                command = new SqlCommand(dishQueries.getAll, connection);
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
        private void getTypes()
        {
            List<string> units = new List<string>();
            connection.Open();
            command = new SqlCommand(dishQueries.getAllType, connection);
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
                comboBoxTypes.Items.Add(unitName);
            }
            comboBoxTypes.SelectedIndex = 0;
            comboBoxTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            connection.Close();
        }
        private void getProducts()
        {
            List<string> units = new List<string>();
            connection.Open();
            command = new SqlCommand(productsQueries.getProductsName, connection);
            reader = command.ExecuteReader();
           
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    units.Add((string)reader.GetValue(0));
                }
            }

            string[] products = units.ToArray();
            checkBoxProducts.Items.AddRange(products);
            connection.Close();
        }

        private void ClickRowEvent(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxTypes.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxUnits.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void DoubleClickRowEvent(object sender, DataGridViewCellEventArgs e)
        {
            string dishName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            StringBuilder products = new StringBuilder("Продукты использованные для данного блюда:\n");

            connection.Open();
            command = new SqlCommand(dishQueries.getAllProducts, connection);
            command.Parameters.Add("@dishName", SqlDbType.VarChar);
            command.Parameters["@dishName"].Value = dishName;
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
    }
}
