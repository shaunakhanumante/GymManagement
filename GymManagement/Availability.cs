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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                string selectedItem = checkedListBox1.Items[e.Index].ToString();

                switch (selectedItem)
                {
                    case "Bench":
                        Data.benchCount++;
                        System.Diagnostics.Debug.WriteLine($"DEBUG: Bench count is now {Data.benchCount}");
                        break;
                    case "Squat Rack":
                        Data.squatCount++;
                        break;
                    case "Treadmill":
                        Data.treadCount++;
                        break;
                    case "Pull-Up Machine":
                        Data.pullCount++;
                        break;
                    default:
                        MessageBox.Show($"Error: {selectedItem}");
                        break;
                }
            }
        }
    }
}
