using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class MemberInfo : Form
    {
        private string _fullName;
        private string _email;
        private string _pNum;
        private string _Workouts;
        private string _DateJoin; 
        public MemberInfo(string name, string email, string pNum, string Workouts, string DateJoin)
        {
            InitializeComponent();
            _fullName = name;
            _email = email;
            _pNum = pNum;
            _Workouts = Workouts;
            _DateJoin = DateJoin;
            this.Load += new EventHandler(MemberInfo_Load);
        }

        private void MemberInfo_Load(object sender, EventArgs e)
        {
            label2.Text = $"Name: {_fullName}";
            label3.Text = $"Email: {_email}";
            label4.Text = $"Phone Number: {_pNum}";
            label5.Text = $"Date Joined: {_DateJoin}";
            label6.Text = $"Workouts: {_Workouts}";
        }
    }
}
