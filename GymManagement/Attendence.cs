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
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckIn formIn = new CheckIn();
            formIn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CheckOut formOut = new CheckOut();
            formOut.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            History historyForm = new History();
            historyForm.ShowDialog();
        }
    }
}
