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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusDesign busDesign = new BusDesign();
            CurrentSession.ShowWindow(busDesign, this, MDI.ActiveForm);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (CurrentSession.LoggedInUser.Username == "arsalan")
            {
                button2.Hide();
                button3.Hide();
                button4.Hide();
                button5.Hide();
            }
            else
            {
                button2.Show();
                button3.Show();
                button4.Show();
                button5.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
