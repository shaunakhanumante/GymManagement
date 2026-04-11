using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace GymManagement
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaring variables to be stored
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();
            string phoneNumber = textBox4.Text.Trim();

            //Loop to store workout plans in a list
            List<string> plans = new List<string>();
            foreach (object item in checkedListBox1.CheckedItems)
            {
                plans.Add(item.ToString());
            }
            string selectedPlans = string.Join(",", plans);

            string connection = @"Data Source=(localdb)\ProjectModels;Initial Catalog=GymDB;Integrated Security=True";
            string query = "INSERT INTO Members (FirstName, LastName, Email, PhoneNumber, WorkoutPlans) " +
                   "VALUES (@fname, @lname, @email, @phone, @plans)";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phoneNumber);
                    cmd.Parameters.AddWithValue("@plans", selectedPlans);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery(); //sends the data to SQL
                        MessageBox.Show("Registration Successful!");
                        this.Close(); // Close form after saving
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving to database: " + ex.Message);
                    }
                }
            }
        }
    }
}
