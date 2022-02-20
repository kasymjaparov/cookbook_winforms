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
    public partial class Recipe : Form
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
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<Label> labels = new List<Label>();
        private string dishName;
        private string unitName;
        private string dishType;

        public Recipe(Dictionary<string, object> dish, string actionType)
        {
            InitializeComponent();

          
            this.dishName = (string)dish["name"];
            this.unitName = (string)dish["unitName"];
            this.dishType = (string)dish["typeName"];
            

            Console.WriteLine("dish name "+ dish["name"]);
            dishNameLabel.Text = $"Название блюда - {(string)dish["name"]}";
            dishPriceLabel.Text = $"Цена блюда - {(string)dish["price"]} сом";
            dishTypeLabel.Text = $"Тип блюда - {(string)dish["typeName"]}";
            dishUnitName.Text = $"Единица измерения - {(string)dish["unitName"]}";
            var products = (CheckedListBox)dish["products"];

            for (int x = 0; x < products.CheckedItems.Count; x++)
            {
                Label label = new Label();
                TextBox productTextBox = new TextBox();

                
              
                label.Location = new Point(100, 0 + x * 40);
                productTextBox.Location = new Point(0, 0 + x * 40);

                label.Text = products.CheckedItems[x].ToString();

                panel1.Controls.Add(label);
                panel1.Controls.Add(productTextBox);

                textBoxes.Add(productTextBox);
                labels.Add(label);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (textBoxes.Any(tb => tb.Text.Length != 0))
            {
                deleteRecipes();
                for (int i = 0; i < textBoxes.Count; i++)
                {
                    connection.Open();
                    command = new SqlCommand(dishQueries.addRecipes, connection);
                    command.Parameters.Add("@amount", SqlDbType.VarChar);
                    command.Parameters["@amount"].Value = textBoxes[i].Text;

                    command.Parameters.Add("@dishName", SqlDbType.VarChar);
                    command.Parameters["@dishName"].Value = dishName;

                    command.Parameters.Add("@productName", SqlDbType.VarChar);
                    command.Parameters["@productName"].Value = labels[i].Text;

                    var unit = command.ExecuteNonQuery();
                    connection.Close();

                }
                MessageBox.Show(messages.successAdded);
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
            connection.Close();
        }
        private void deleteRecipes()
        {
            connection.Open();
            command = new SqlCommand(dishQueries.deleteRecipe, connection);

            command.Parameters.Add("@dishName", SqlDbType.VarChar);
            command.Parameters["@dishName"].Value = dishName;

            var unit = command.ExecuteNonQuery();
            connection.Close();
        }
        private string getPrice(string productName)
        {
            string pName="ds";
            connection.Open();
            command = new SqlCommand(dishQueries.getProductPrice, connection);

            command.Parameters.Add("@productName", SqlDbType.VarChar);
            command.Parameters["@productName"].Value = productName;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               pName= (string)reader[0];
            }
            connection.Close();
            return pName;
        }
    }
}
