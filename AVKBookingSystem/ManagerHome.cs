using AVKBookingSystem.EF_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVKBookingSystem
{
    public partial class ManagerHome : Form
    {
        BobsSalonEntities context;

        public ManagerHome()
        {
            InitializeComponent();
            richTextBoxSalaryReport.ReadOnly = true;
            context = new BobsSalonEntities();
            buttonAllBookings.Click += ButtonAllBookings_Click;
            buttonSalesReport.Click += ButtonSalesReport_Click;
            buttonStaffDetails.Click += ButtonStaffDetails_Click;
            buttonSalaryReport.Click += ButtonSalaryReport_Click;
            buttonUpdateStaff.Click += ButtonUpdateStaff_Click;
        }

        private void ButtonUpdateStaff_Click(object sender, EventArgs e)
        {
            richTextBoxSalaryReport.Text = "";

            context.Staffs.Load();
            dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResults.DataSource = context.Staffs.Local.ToBindingList();

            dataGridViewResults.Columns["Staff_ID"].ReadOnly = true;
            dataGridViewResults.Columns["Staff_First_Name"].ReadOnly = true;
            dataGridViewResults.Columns["BookingDetails"].Visible = false;
            dataGridViewResults.Columns["Staff_Time_Tracker"].Visible = false;


            context.SaveChanges();

        }

        private void ButtonSalaryReport_Click(object sender, EventArgs e)
        {
            richTextBoxSalaryReport.Text = "";
            context.Staff_Time_Tracker.Load();
            dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StringBuilder st = new StringBuilder("**********Salary Report****************",256);

            
            var staffTimeTrackersQuery = context.Staff_Time_Tracker
                 .Where(i => i.Date.Year == 2018)
                 .GroupBy(i => new { i.Date.Month, i.Staff.Staff_First_Name })
                 .Select(i => new
                 {
                     Month_ofyear2018 = i.Key.Month,
                     staff_id = i.Key.Staff_First_Name,
                     Hours = i.Sum(f => f.Staff_Hours),
                     Salary = i.Sum(f => f.Staff_Hours) * 15,       

                 }).ToList();
            st.AppendLine("");
            st.AppendLine("_________________________");

            foreach (var v in staffTimeTrackersQuery)
            {
                st.Append(v.staff_id+ " is having salary for the month "+ v.Month_ofyear2018+ " is :"+ v.Salary);
                st.AppendLine("");
            }

            st.AppendLine("_________________________");

            richTextBoxSalaryReport.Text = st.ToString();
          //  dataGridViewResults.DataSource = staffTimeTrackersQuery;


        }

        private void ButtonStaffDetails_Click(object sender, EventArgs e)
        {
            richTextBoxSalaryReport.Text = "";

            context.Staff_Time_Tracker.Load();
            dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            var staffTimeTrackersQuery = context.Staff_Time_Tracker
                 .Where(i => i.Date.Year == 2018)
                 .GroupBy(i => new { i.Date.Month , i.Staff.Staff_First_Name})
                 .Select(i => new
                 {
                    
                     Total_Hours = i.Sum(f=>f.Staff_Hours),
                     Month_ofyear2018 = i.Key.Month,
                     staff_id = i.Key.Staff_First_Name
   
                 }).ToList();

            dataGridViewResults.DataSource = staffTimeTrackersQuery;


        }


        

        private void ButtonSalesReport_Click(object sender, EventArgs e)
        {
            richTextBoxSalaryReport.Text = "";

            ManagerSalesReport salesReport = new ManagerSalesReport();
            salesReport.ShowDialog();
        }

      

        private void ButtonAllBookings_Click(object sender, EventArgs e)
        {
            richTextBoxSalaryReport.Text = "";

            context.BookingDetails.Load();
            var bookingDetailsquery = context.BookingDetails
                              .Select(x => new BookingData
                              {
                                  BookingID = x.Booking_ID,
                                  ClientPhNum = x.Client_PhoneNumber,
                                  ServiceName = x.Service.Service_Name,
                                  StaffName = x.Staff.Staff_First_Name,
                                  ServiceDate = x.Service_Date,
                                  ServiceStartTime = x.Service_StartTime,
                                  ServiceEndTime = x.Service_EndTime

                              }).ToList();

            dataGridViewResults.DataSource = bookingDetailsquery;
        }

        private class BookingData
        {
            [DisplayName("Booking ID")]
            public int BookingID { get; set; }

            [DisplayName("Client PhoneNumber")]
            public string ClientPhNum { get; set; }

            [DisplayName("Service ID")]
            public string ServiceName { get; set; }

            [DisplayName("Staff ID")]
            public string StaffName { get; set; }

            [DisplayName("Service Date")]
            public DateTime ServiceDate { get; set; }

            [DisplayName("Service StartTime")]
            public DateTime ServiceStartTime { get; set; }

            [DisplayName("Service EndTime")]
            public DateTime ServiceEndTime { get; set; }


        }

    }
}
