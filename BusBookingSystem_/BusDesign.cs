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
    public partial class BusDesign : Form
    {
        BusBookingSystemEntities busBookingSystemEntities = new BusBookingSystemEntities();

        public BusDesign()
        {
            InitializeComponent();
        }

        private void GenerateDesign_Click(object sender, EventArgs e)
        {
            int totalSeats = 1;
            int x = 520;
            int y = 10;

            SeatsArea.Controls.Clear();

            int rows = Convert.ToInt32(RowsCount.Text);
            int columns = Convert.ToInt32(ColumnsCount.Text);

            var separator = columns / 2;
            separator = separator > 1 ? separator - 1 : separator;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // x, y
                    #region Button Design Code

                    Button btn = new Button();
                    SeatsArea.Controls.Add(btn);

                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = Color.Black;
                    btn.Image = Properties.Resources.icons8_seat_45;
                    btn.ImageAlign = ContentAlignment.TopCenter;
                    btn.Location = new Point(x, y);
                    btn.Name = "BookSeat_" + totalSeats.ToString();
                    btn.Size = new Size(59, 70);
                    btn.TabIndex = 3;
                    btn.Text = totalSeats.ToString();
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += BookSeat__Click;

                    #endregion

                    if (j == separator)
                        x = x - 120;
                    else
                        x = x - 65;

                    totalSeats++;
                }

                y = y + 76;
                x = 520;
            }
        }

        private void BookSeat__Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("Seat # " + btn.Text + " Clicked");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SaveBusData_Click(object sender, EventArgs e)
        {
           
        }
    }
}
