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
    public partial class DishType : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        DishTypeQueries unitsQueries = new DishTypeQueries();
        SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter dataadapter;
        SqlCommand command;
        Messages messages = new Messages();
        private int id=-1;
        public DishType()
        {
            InitializeComponent();
            getAll();
        }
        private void btnUnitUpdate_Click(object sender, EventArgs e)
        {
            if (id<1 || String.IsNullOrEmpty(textBoxName.Text))
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
                command.Parameters["@id"].Value = id;
                var unit = command.ExecuteNonQuery();
                connection.Close();
                getAll();
                textBoxName.Clear();
                
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
                textBoxName.Clear();
                connection.Close();
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
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
            }
            catch (Exception ex)
            {
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
            if (id<1)
            {
                MessageBox.Show(messages.validationIdForm);
            }
            else
            {
                connection.Open();
                command = new SqlCommand(unitsQueries.delete, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = id;
                var unit = command.ExecuteNonQuery();
                connection.Close();
                getAll();
                textBoxName.Clear();
                MessageBox.Show(messages.successDeleted);
            }
        }
        private void moreInfoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалить - заполните поле ID \n\nДобавить - заполните поля Название\n\nИзменить - заполните поля ID, Название");
        }

        private void CellBtn_Click(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
