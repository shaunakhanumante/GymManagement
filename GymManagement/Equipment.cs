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

    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Availability aForm = new Availability();
            aForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usage uForm = new Usage();
            uForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Maintain mForm = new Maintain();
            mForm.ShowDialog();
        }
    }
}
