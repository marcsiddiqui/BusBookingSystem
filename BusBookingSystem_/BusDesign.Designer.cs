using System.Drawing;
using System.Windows.Forms;

namespace BusBookingSystem_
{
    partial class BusDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColumnsCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RowsCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SeatsArea = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GenerateDesign = new System.Windows.Forms.Button();
            this.BusName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DepartTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SaveBusData = new System.Windows.Forms.Button();
            this.Stops = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColumnsCount
            // 
            this.ColumnsCount.Location = new System.Drawing.Point(174, 240);
            this.ColumnsCount.Name = "ColumnsCount";
            this.ColumnsCount.Size = new System.Drawing.Size(200, 25);
            this.ColumnsCount.TabIndex = 7;
            this.ColumnsCount.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Columns";
            // 
            // RowsCount
            // 
            this.RowsCount.Location = new System.Drawing.Point(174, 271);
            this.RowsCount.Name = "RowsCount";
            this.RowsCount.Size = new System.Drawing.Size(200, 25);
            this.RowsCount.TabIndex = 8;
            this.RowsCount.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rows";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SeatsArea);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(703, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 496);
            this.panel1.TabIndex = 4;
            // 
            // SeatsArea
            // 
            this.SeatsArea.AutoScroll = true;
            this.SeatsArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeatsArea.Location = new System.Drawing.Point(0, 0);
            this.SeatsArea.Name = "SeatsArea";
            this.SeatsArea.Size = new System.Drawing.Size(667, 452);
            this.SeatsArea.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 44);
            this.panel2.TabIndex = 0;
            // 
            // GenerateDesign
            // 
            this.GenerateDesign.Location = new System.Drawing.Point(174, 342);
            this.GenerateDesign.Name = "GenerateDesign";
            this.GenerateDesign.Size = new System.Drawing.Size(200, 35);
            this.GenerateDesign.TabIndex = 10;
            this.GenerateDesign.Text = "Generate Design";
            this.GenerateDesign.UseVisualStyleBackColor = true;
            this.GenerateDesign.Click += new System.EventHandler(this.GenerateDesign_Click);
            // 
            // BusName
            // 
            this.BusName.Location = new System.Drawing.Point(174, 48);
            this.BusName.Name = "BusName";
            this.BusName.Size = new System.Drawing.Size(200, 25);
            this.BusName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bus Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DepartTime
            // 
            this.DepartTime.Location = new System.Drawing.Point(174, 174);
            this.DepartTime.Name = "DepartTime";
            this.DepartTime.Size = new System.Drawing.Size(200, 25);
            this.DepartTime.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Departure Time";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Arrival Time Time";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.Location = new System.Drawing.Point(174, 207);
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Size = new System.Drawing.Size(200, 25);
            this.ArrivalTime.TabIndex = 6;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(174, 141);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(200, 25);
            this.Price.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ticket Price";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(174, 79);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(200, 25);
            this.From.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "From";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(174, 110);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(200, 25);
            this.To.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "To";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // SaveBusData
            // 
            this.SaveBusData.Location = new System.Drawing.Point(174, 383);
            this.SaveBusData.Name = "SaveBusData";
            this.SaveBusData.Size = new System.Drawing.Size(200, 35);
            this.SaveBusData.TabIndex = 11;
            this.SaveBusData.Text = "Save Bus Data";
            this.SaveBusData.UseVisualStyleBackColor = true;
            this.SaveBusData.Click += new System.EventHandler(this.SaveBusData_Click);
            // 
            // Stops
            // 
            this.Stops.Location = new System.Drawing.Point(174, 302);
            this.Stops.Name = "Stops";
            this.Stops.Size = new System.Drawing.Size(200, 25);
            this.Stops.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Stops";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(174, 17);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(200, 25);
            this.CompanyName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Company Name";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // BusDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 496);
            this.Controls.Add(this.ArrivalTime);
            this.Controls.Add(this.DepartTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveBusData);
            this.Controls.Add(this.GenerateDesign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.RowsCount);
            this.Controls.Add(this.Stops);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.BusName);
            this.Controls.Add(this.ColumnsCount);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ColumnsCount;
        private Label label1;
        private TextBox RowsCount;
        private Label label2;
        private Panel panel1;
        private Panel SeatsArea;
        private Panel panel2;
        private Button GenerateDesign;
        private TextBox BusName;
        private Label label3;
        private DateTimePicker DepartTime;
        private Label label4;
        private Label label5;
        private DateTimePicker ArrivalTime;
        private TextBox Price;
        private Label label6;
        private TextBox From;
        private Label label7;
        private TextBox To;
        private Label label8;
        private Button SaveBusData;
        private TextBox Stops;
        private Label label9;
        private TextBox CompanyName;
        private Label label10;
    }
}

