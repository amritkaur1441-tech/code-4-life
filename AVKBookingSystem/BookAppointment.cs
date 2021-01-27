using AVKBookingSystem.EF_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVKBookingSystem
{
    public partial class BookAppointment : Form
    {
        BobsSalonEntities context;

        public BookAppointment()
        {

            InitializeComponent();
            context = new BobsSalonEntities();
            this.Load += BookAppointment_Load;
            InitializeMyComponent();
            AutoCompletePhoneNumber();
            /*    DateTime timeValue = Convert.ToDateTime("01:00 PM");
                MessageBox.Show(timeValue.ToString("HH:mm")); */
            textBoxPhoneNum.KeyDown += TextBoxPhoneNum_KeyDown;
            buttonAddClient.Click += ButtonAddClient_Click;
            buttonBookAppointment.Click += ButtonBookAppointment_Click;
        }

        private void ButtonBookAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                context.BookingDetails.Load();
                context.SaveChanges();
                string serviceNametxt = listBoxServiceName.SelectedItem.ToString();
                string staffName = listBoxStaffName.SelectedItem.ToString();

                /*     string selectedDate = dateTimePickerDate.Value.ToString("yyyy-MM-dd");

                     DateTime iDate = DateTime.Parse(selectedDate);
                     string selectedTime = dateTimePickerTime.Value.ToString("HH:mm");
                     //            MessageBox.Show(selectedTime); 
                */


                 var serviceTime = context.Services
                                  .Where(s => s.Service_Name == serviceNametxt)
                                  .Select(s => s.Service_TimeTaken).FirstOrDefault().ToString();
                double serveTime = Convert.ToDouble(serviceTime);
                /*     MessageBox.Show(serviceTime);
                     DateTime oDate = DateTime.Parse(selectedTime);


                     string serviceEndTime = (oDate.AddMinutes(Convert.ToDouble(serviceTime)).ToString("HH:mm"));
                     DateTime eDate = DateTime.Parse(serviceEndTime); */


                DateTime myDate = dateTimePickerDate.Value.Date +
                                  dateTimePickerTime.Value.TimeOfDay;
                DateTime date =DateTime.Now;

               if (myDate < date)
                {
                    MessageBox.Show("Cannot book appointments in past!!!!!!!");
                    return;
                } 

                DateTime serviceEndTime = myDate.AddMinutes(serveTime);

                int serviceId = context.Services
                               .Where(s => s.Service_Name == serviceNametxt)
                               .Select(s => s.Service_ID).FirstOrDefault();


                int stafId = context.Staffs
                    .Where(x => x.Staff_First_Name == staffName)
                    .Select(x => x.Staff_ID).FirstOrDefault();

                var serviceEntimeCheck = from x in context.BookingDetails
                                         where x.Staff_ID == stafId
                                         && x.Service_Date.Day == myDate.Day
                                         && x.Service_Date.Month == myDate.Month
                                         && x.Service_Date.Year == myDate.Year
                                         && x.Service_StartTime <= myDate
                                         && x.Service_EndTime >= myDate
                                         select x.Service_EndTime;


                if (serviceEntimeCheck.Count() > 0)
                {
                    MessageBox.Show("This staff is busy at this time, Please book another staff");
                    return;
                }

                /*    List<BookingDetail> bookingDetailList = new List<BookingDetail>()
                    {
                       new BookingDetail{ Client_PhoneNumber=textBoxPhoneNum.Text, Service_ID=serviceId,Staff_ID=stafId,Service_Date=myDate,Service_StartTime=myDate,Service_EndTime= serviceEndTime }
                    };
                     context.BookingDetails.AddRange(bookingDetailList);*/

                BookingDetail booking = new BookingDetail { Client_PhoneNumber = textBoxPhoneNum.Text, Service_ID = serviceId, Staff_ID = stafId, Service_Date = myDate, Service_StartTime = myDate, Service_EndTime = serviceEndTime };
                context.BookingDetails.Add(booking);
                context.SaveChanges();
               int newPK = booking.Booking_ID;
                //MessageBox.Show(newPK.ToString());
                context.BookingDetails.Load();

                var bookingDetailsquery = context.BookingDetails
                    .Where(x=>x.Booking_ID>=newPK)
                    .Select(x => new BookingData
                    {
                        BookingID= x.Booking_ID,
                        ClientPhNum = x.Client_PhoneNumber,
                        ServiceName=x.Service.Service_Name,
                        StaffName=x.Staff.Staff_First_Name,
                        ServiceDate=x.Service_Date,
                        ServiceStartTime= x.Service_StartTime,
                        ServiceEndTime=x.Service_EndTime

                    }).ToList();

                dataGridViewBookingDetails.Refresh();
                dataGridViewBookingDetails.DataSource = bookingDetailsquery;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            context.Clients.Load();

            string clientFirstName = textBoxFirstName.Text;
            string clientLastName = textBoxLastName.Text;
            string clientEmail = textBoxEmail.Text;

            //     ***************** Insert All Validations here!!****************************
            //     ***************** Insert All Validations here!!****************************
            //     ***************** Insert All Validations here!!****************************
            //     ***************** Insert All Validations here!!****************************
            //     ***************** Insert All Validations here!!****************************
            //     ***************** Insert All Validations here!!****************************
            if (string.IsNullOrEmpty(clientFirstName))
            {
                MessageBox.Show("Client First Name cant be null");
                return;
            }

            List<Client> clientList = new List<Client>()
            {
                         new Client { Client_Phone_Num=textBoxPhoneNum.Text,Client_First_Name=clientFirstName,Client_Last_Name=clientLastName,Client_Email=clientEmail},
            };

            context.Clients.AddRange(clientList);
            context.SaveChanges();

            MessageBox.Show("New Client is added");
            context.Clients.Load();

        }

        private void TextBoxPhoneNum_KeyDown(object sender, KeyEventArgs e)
        {
            context.Clients.Load();

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string phoneNumberEnterered = textBoxPhoneNum.Text;
                    bool result = false;
                    var matchPhoneNumber = context.Clients
                        .Where(x => x.Client_Phone_Num == phoneNumberEnterered)
                        .Select(x => x.Client_Phone_Num);


                    if (matchPhoneNumber.Count() > 0)
                    {
                        result = true;

                    }

                    if (result)
                    {
                        AutoFillDetails(phoneNumberEnterered);
                    }
                    else
                    {
                        textBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxEmail.Text = "";
                        buttonAddClient.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        /*************************************************************************************
                   Method to automatically get the Client phone number if it is in database
         **************************************************************************************/
        private void AutoCompletePhoneNumber()
        {
            context.Clients.Load();
            textBoxPhoneNum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxPhoneNum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collectionPhoneNum = new AutoCompleteStringCollection();

            var name = from a in context.Clients
                       where a.Client_Phone_Num.StartsWith(textBoxPhoneNum.Text)
                       select a.Client_Phone_Num;

            collectionPhoneNum.AddRange(name.ToArray());

            textBoxPhoneNum.AutoCompleteCustomSource = collectionPhoneNum;
        }

        /****************************************************************
           Method to LOAD AND SEED data in local tables
         ***************************************************************/
        private void BookAppointment_Load(object sender, EventArgs e)
        {
            //
            context.Clients.Load();
            context.Staffs.Load();
            context.Staff_Time_Tracker.Load();
            context.Services.Load();
            context.BookingDetails.Load();

            context.Database.Log = (s => Debug.Write(s));

            //*******Calling SeedData method to get the data in local tables******** 
         // SeedData();
        }

        public void InitializeMyComponent()
        {
                dateTimePickerTime.ShowUpDown = true;
                dateTimePickerTime.CustomFormat = "HH:mm";
                dateTimePickerTime.Format = DateTimePickerFormat.Custom;
            dataGridViewBookingDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            buttonAddClient.Enabled = false;


            var serviceList = context.Services
                        .Select(s => s.Service_Name).Distinct().ToList();

            listBoxServiceName.DataSource = serviceList;

            var staffNameList = context.Staffs
                .Select(s => s.Staff_First_Name).ToList();

            listBoxStaffName.DataSource = staffNameList;

        }

        /****************************************************************
            Autofill method to get the data in client detail textboxes itself
          ***************************************************************/
        public void AutoFillDetails(string phoneNumber)
        {

            var clientDetails = context.Clients
                .Where(x => x.Client_Phone_Num == phoneNumber)
                .Select(x => x);

            foreach (Client c in clientDetails)
            {
                textBoxFirstName.Text = c.Client_First_Name;
                textBoxLastName.Text = c.Client_Last_Name;
                textBoxEmail.Text = c.Client_Email;

            }

        }
        /****************************************************************
             SeedData method to get the data in local tables
        ***************************************************************/
       

        private void BookAppointment_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bobsSalonDataBaseDataSet.BookingDetails' table. You can move, or remove it, as needed.
            this.bookingDetailsTableAdapter.Fill(this.bobsSalonDataBaseDataSet.BookingDetails);

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
