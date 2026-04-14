using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Log : Form
    {
        private int _memberID;
        private string _exerciseName;
        public Log(int memberID, string exerciseName)
        {
            InitializeComponent();
            _memberID = memberID;
            _exerciseName = exerciseName;

            label1.Text = _exerciseName;

            textBox1.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Convert input into DateTime object
            DateTime logDate;
            if (!DateTime.TryParse(textBox1.Text, out logDate))
            {
                //Catches incorrect formatting error
                MessageBox.Show("Please enter the date in mm/dd/yyyy format.");
                return;
            }

            string connection = @"Data Source=(localdb)\ProjectModels;Initial Catalog=GymDB;Integrated Security=True";
            string query = "INSERT INTO WorkoutLogs (MemberID, ExerciseName, Sets, Reps, Weight, LogDate) " +
                           "VALUES (@id, @ex, @s, @r, @w, @d)";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _memberID);
                    cmd.Parameters.AddWithValue("@ex", _exerciseName);
                    cmd.Parameters.AddWithValue("@s", numericUpDown1.Value);
                    cmd.Parameters.AddWithValue("@r", numericUpDown2.Value);
                    cmd.Parameters.AddWithValue("@w", numericUpDown3.Value);

                    
                    cmd.Parameters.AddWithValue("@d", logDate);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Workout Logged!");
                    this.Close();
                }
            }
        }
    }
}
