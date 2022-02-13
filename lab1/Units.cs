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
    public partial class Units : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        UnitsQueries unitsQueries = new UnitsQueries();
        SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter dataadapter;
        SqlCommand command;
        Messages messages = new Messages();
        public Units()
        {
            InitializeComponent();
            getAll();
        }

        private void btnUnitUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxId.Text) || String.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show(messages.validationIdNameForm);
            }
            else
            {
                connection.Open();
                command = new SqlCommand(unitsQueries.update, connection);
                command.Parameters.Add("@name", SqlDbType.VarChar);
                command.Parameters["@name"].Value = textBoxName.Text;
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = textBoxId.Text;
                var unit = command.ExecuteNonQuery();
                connection.Close();
                getAll();
                textBoxName.Clear();
                textBoxId.Clear();
                MessageBox.Show(messages.successChanged);
            }
           
        }

        private void addBtnClick(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxName.Text))
                {
                    MessageBox.Show(messages.validationNameForm);
                }
                else
                {
                    connection.Open();
                    command = new SqlCommand(unitsQueries.add, connection);
                    command.Parameters.Add("@name", SqlDbType.VarChar);
                    command.Parameters["@name"].Value = textBoxName.Text;
                    var unit = command.ExecuteNonQuery();
                    connection.Close();
                    getAll();
                    MessageBox.Show(messages.successAdded);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
                textBoxName.Clear();
            }    
        }
        private void getAll()
        {
            try
            {
                command = new SqlCommand(unitsQueries.getAll, connection);
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
            catch (Exception ex) {
                Console.WriteLine("get all exeption");
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
                command = new SqlCommand(unitsQueries.delete, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = textBoxId.Text;
                var unit = command.ExecuteNonQuery();
                connection.Close();
                getAll();
                textBoxId.Clear();
                MessageBox.Show(messages.successDeleted);
            }
                
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалить - заполните поле ID \n\nДобавить - заполните поля Название\n\nИзменить - заполните поля ID, Название");
        }
    }
}
