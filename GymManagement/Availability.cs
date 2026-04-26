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
    public partial class Availability : Form
    {

        
        public Availability()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Data.benchCount++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.squatCount ++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data.treadCount++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Data.pullCount++;
        }
    }
}
