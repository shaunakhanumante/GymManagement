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


namespace GymManagement
{
    public partial class Track : Form
    {
        public Track()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID;
            if (int.TryParse(textBox1.Text, out ID))
            {
                string connection = @"Data Source=(localdb)\ProjectModels;Initial Catalog=GymDB;Integrated Security=True";
                string query = "SELECT FirstName, LastName, WorkoutPlans FROM Members WHERE MemberID = @ID";

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);

                        try
                        {
                            conn.Open();
                            SqlDataReader read = cmd.ExecuteReader();

                            if (read.Read()) //finds match
                            {
                                //Display Information
                                string firstName = read["FirstName"].ToString();
                                string lastName = read["LastName"].ToString();
                                string Workout = read["WorkoutPlans"].ToString();
                                label2.Text = firstName + " " + lastName + "\n" + Workout;

                                //Array Workout Plans
                                string[] plansArray = Workout.Split(',');
                                listBox1.Items.Clear();
                                //Loop for each plan (if more than 1)
                                foreach (string plan in plansArray)
                                {
                                    switch (plan)
                                    {
                                        case "Strength":
                                            listBox1.Items.AddRange(new string[] { "Bench", "Squat", "Deadlift" });
                                            break;
                                        case "Cardio":
                                            listBox1.Items.AddRange(new string[] { "Treadmill", "Jumping Jacks", "Box Jumps" });
                                            break;
                                        case "Calesthenics":
                                            listBox1.Items.AddRange(new string[] { "Push-Ups", "Pull-Ups", "Planks" });
                                            break;
                                        case "Yoga":
                                            listBox1.Items.AddRange(new string[] { "Downward Dog", "Shoulder Stand", "Cobra" });
                                            break;
                                    }
                                }

                                //Show log and progress button
                                button2.Visible = true;
                                button2.Enabled = true;
                                button3.Visible = true;
                                button3.Enabled = true;
                            }

                            else
                            {
                                label2.Text = "No member found";
                            }
                        }

                        catch (Exception ex) 
                        {
                            MessageBox.Show("Database Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                label2.Text = "Error: Please Enter A Valid Input!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (listBox1.SelectedItem != null)
            {

                if (int.TryParse(textBox1.Text, out int memberID))
                {
                    string exercise = listBox1.SelectedItem.ToString();

                    Log logForm = new Log(memberID, exercise);
                    logForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Member ID first.");
                }
            }
            else
            {
                MessageBox.Show("Please select an exercise from the list to log.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int id))
            {
                Progress progressTrack = new Progress(id);
                progressTrack.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please enter or search for a Member ID first!");
            }
        }
    }
}
