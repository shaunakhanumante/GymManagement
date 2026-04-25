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
    public partial class Reports : Form
    {
        private string NameForReport;
        private string EmailForReport;
        private string pNumForReport;
        private string ExerciseForReport;
        private string DateJoinForReport;
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID;
            if (int.TryParse(textBox1.Text, out ID))
            {
                string connection = @"Data Source=(localdb)\ProjectModels;Initial Catalog=GymDB;Integrated Security=True";
                string query = "SELECT FirstName, LastName, Email, PhoneNumber, DateJoin, WorkoutPlans FROM Members WHERE MemberID = @ID";

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);

                        try
                        {
                            conn.Open();
                            SqlDataReader read = cmd.ExecuteReader();

                            if (read.Read()) // Finds match
                            {
                                //For Reports
                                NameForReport = read["FirstName"].ToString() + " " + read["LastName"].ToString();
                                EmailForReport = read["Email"].ToString();
                                pNumForReport = read["PhoneNumber"].ToString();
                                ExerciseForReport = read["WorkoutPlans"].ToString();
                                DateJoinForReport = read["DateJoin"].ToString();


                                // Display Information
                                string firstName = read["FirstName"].ToString();
                                string lastName = read["LastName"].ToString();
                                string email = read["Email"].ToString();
                                string number = read["PhoneNumber"].ToString();
                                string Workout = read["WorkoutPlans"].ToString();
                                string joinDate = read["DateJoin"].ToString();
                                label2.ForeColor = Color.Blue;
                                label2.Text = firstName + " " + lastName;

                                //Enable buttons
                                button2.Visible = true;
                                button2.Enabled = true;
                               
                            }
                            else
                            {
                                label2.Text = "Member not found.";

                                //Disable buttons
                                button2.Visible = false;
                                button2.Enabled = false;
                                
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    } 
                } 
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemberInfo memberInfo = new MemberInfo(NameForReport, EmailForReport, pNumForReport, ExerciseForReport, DateJoinForReport);
            memberInfo.ShowDialog();
        }
    }
}
