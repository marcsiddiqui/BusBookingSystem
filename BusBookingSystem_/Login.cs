using BusBookingSystem_.BBS_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusBookingSystem_
{
    public partial class Login : Form
    {
        BusBookingSystemEntities busBookingSystemEntities = new BusBookingSystemEntities();

        public Login()
        {
            InitializeComponent();
        }

        private void Login__Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text))
                MessageBox.Show("All fields are required!", "Error");

            var employee = busBookingSystemEntities.Employees.Where(x => x.Username == Username.Text && x.Password == Password.Text).FirstOrDefault();
            if (employee == null)
                MessageBox.Show("Invalid username or password!", "Error");
            else
            {
                CurrentSession.LoggedInUser = employee;
                // close login form
                // open the other form

                Dashboard busDesign = new Dashboard();
                CurrentSession.ShowWindow(busDesign, this, MDI.ActiveForm);
            }
        }
    }
}
