using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime inDate;
            if (!DateTime.TryParse(textBox1.Text, out inDate))
            {
                label5.Text = "Please enter valid date";
                return;
            }

            DateTime inTime;
            if (!DateTime.TryParse(textBox2.Text, out inTime))
            {
                label5.Text = "Please enter valid time";
                return;
            }

            DateTime fullTime = inDate.Date + inTime.TimeOfDay;

            int mID;
            if (!int.TryParse(textBox3.Text, out mID))
            {
                label5.Text = "Please enter valid MemberID";
                return;
            }

            string connection = @"Data Source=(localdb)\ProjectModels;Initial Catalog=GymDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string nameQuery = "SELECT FirstName, LastName FROM Members WHERE MemberID = @id";
                    string fName = "";
                    string lName = "";

                    using (SqlCommand getName = new SqlCommand(nameQuery, conn))
                    {
                        getName.Parameters.AddWithValue("@id", mID);
                        using (SqlDataReader reader = getName.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fName = reader["FirstName"].ToString();
                                lName = reader["LastName"].ToString();
                            }
                            else
                            {
                                label5.Text = "Member ID not found!";
                                return;
                            }
                        }
                    }

                    string insertQuery = "INSERT INTO Attendance (MemberID, FirstName, LastName, Date) VALUES (@id, @fn, @ln, @dt)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", mID);
                        cmd.Parameters.AddWithValue("@fn", fName);
                        cmd.Parameters.AddWithValue("@ln", lName);
                        cmd.Parameters.AddWithValue("@dt", fullTime);

                        cmd.ExecuteNonQuery();
                        label5.Text = "Successfully logged for " + fName + " " + lName;

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    label5.Text = "Database Error: " + ex.Message;
                }
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
