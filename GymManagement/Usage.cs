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
    public partial class Usage : Form
    {
        public Usage()
        {
            InitializeComponent();
            this.Load += new EventHandler(UsageForm_Load);
            timer1.Start();
        }

        private void UsageForm_Load(object sender, EventArgs e)
        {
    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = $"Bench: {Data.benchCount}";
            label3.Text = $"Squat Rack: {Data.squatCount}";
            label4.Text = $"Treadmill: {Data.treadCount}";
            label5.Text = $"Pull-Up Machine: {Data.pullCount}";
        }
    }
}
