using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            string connection = @"Data Source=(localdb)\ProjectModels;Initial Catalog=GymDB;Integrated Security=True";
            string query = "Insert ....";
        }
    }
}
