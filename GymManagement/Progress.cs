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
    public partial class Progress : Form
    {
        private int _memberID;

        public Progress(int memberID)
        {
            InitializeComponent();
            _memberID = memberID;

            LoadMemberData();
        }

        private void LoadMemberData()
        {
            string connection = @"Data Source=(localdb)\ProjectModels;Initial Catalog=GymDB;Integrated Security=True";
            string query = "SELECT LogDate, ExerciseName, Sets, Reps, Weight FROM WorkoutLogs " +
                           "WHERE MemberID = @id ORDER BY LogDate DESC";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _memberID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.ReadOnly = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
