using BusBookingSystem_.BBS_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusBookingSystem_
{
    public static class CurrentSession
    {
        public static Employee LoggedInUser { get; set; }

        public static void ShowWindow(Form openWindow, Form closeWindow, Form MDI)
        {
            closeWindow.Close();
            openWindow.WindowState = FormWindowState.Maximized;
            openWindow.MdiParent = MDI;
            openWindow.Show();
        }
    }
}
