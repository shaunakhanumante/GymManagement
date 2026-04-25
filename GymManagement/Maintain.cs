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
    public partial class Maintain : Form
    {
        public Maintain()
        {
            InitializeComponent();
        }

        private void Maintain_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

          
            DateTime nextMonth = today.AddMonths(1);
            DateTime firstOfNextMonth = new DateTime(nextMonth.Year, nextMonth.Month, 1);

            
            label1.Text = "Next Maintance Date " + firstOfNextMonth.ToString("D");
        }
    }
}
