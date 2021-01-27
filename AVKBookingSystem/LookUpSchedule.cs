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
    public partial class LookUpSchedule : Form

    {
        BobsSalonEntities context;


        public LookUpSchedule()
        {
            InitializeComponent();
            context = new BobsSalonEntities();
            InitializeMyComponent();
            buttonLookUpSchedule.Click += ButtonLookUpSchedule_Click;
        }

        private void ButtonLookUpSchedule_Click(object sender, EventArgs e)
        {
            context.BookingDetails.Load();
            DateTime date = dateTimePickerDate.Value.Date;
            int staffId = -1;

            if (string.IsNullOrEmpty(textBoxStaffId.Text))
            {
                //  MessageBox.Show("Please enter the Staff Id");
                //  return;
            }
            else
            {
                staffId = Convert.ToInt32(textBoxStaffId.Text);

            }

            string currentTime = DateTime.Now.ToString("HH:mm");
            DateTime time = DateTime.Parse(currentTime);




            var query = context.BookingDetails
                .Where(x => x.Staff_ID == staffId && x.Service_Date.Day == date.Day && x.Service_Date.Month == date.Month && x.Service_Date.Year == date.Year || x.Service_Date.Day == date.Day && x.Service_Date.Month == date.Month && x.Service_Date.Year == date.Year && staffId == -1)
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

            dataGridView1DisplaySchedule.DataSource = query;
            dataGridView1DisplaySchedule.Refresh();

            textBoxTotalBookings.Text = query.Count().ToString();

            int counter = 0;

            foreach (BookingData b in query)
            {

                if (time > b.ServiceEndTime)
                {
                    dataGridView1DisplaySchedule.Rows[counter].DefaultCellStyle.BackColor = Color.Red;
                }
                else if(time > b.ServiceStartTime && time < b.ServiceEndTime)
                {
                    dataGridView1DisplaySchedule.Rows[counter].DefaultCellStyle.BackColor = Color.SkyBlue;

                }
                else
                {
                    dataGridView1DisplaySchedule.Rows[counter].DefaultCellStyle.BackColor = Color.Green;

                }

                counter++;

            }
        }

        public void InitializeMyComponent()
        {
            dataGridView1DisplaySchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            textBoxDoing.ReadOnly = true;
            textBoxDone.ReadOnly = true;
            textBoxUpcoming.ReadOnly = true;
            textBoxTotalBookings.ReadOnly = true;
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
