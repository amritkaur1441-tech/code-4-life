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
    /*****************
       The Main Page
     ****************/
    public partial class FirstLoginPage : Form
    {
        BobsSalonEntities context;

        public FirstLoginPage()
        {
            InitializeComponent();
            context = new BobsSalonEntities();
            //action event handlers for various button clicks
            buttonStaff_ClientSearch.Click += ButtonStaffSearch_Click;
            buttonLogOut.Click += ButtonLogOut_Click;
            buttonBookAppointment.Click += ButtonBookAppointment_Click;
            buttonTimeInOut.Click += ButtonTimeInOut_Click;
            buttonLookup.Click += ButtonStaffStats_Click;
            buttonManagerLogin.Click += ButtonManagerLogin_Click1;
            this.Load += FirstLoginPage_Load;

        }

        private void FirstLoginPage_Load(object sender, EventArgs e)
        {
            SeedData();
        }

        private void ButtonManagerLogin_Click1(object sender, EventArgs e)
        {
            ManagerHome managerHome = new ManagerHome();
            managerHome.ShowDialog();

        }

        private void ButtonStaffStats_Click(object sender, EventArgs e)
        {
           LookUpSchedule staffstats = new LookUpSchedule();
           staffstats.ShowDialog();
        }

        /****************************************************************
         Displaying various forms on each button click that coresponts it
        ***************************************************************/
        private void ButtonTimeInOut_Click(object sender, EventArgs e)
        {
            TimeIN_OUT_Page timeInOut = new TimeIN_OUT_Page();
            timeInOut.ShowDialog();
        }

        private void ButtonBookAppointment_Click(object sender, EventArgs e)
        {
            BookAppointment bookAppointment = new BookAppointment();
            bookAppointment.ShowDialog();
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void ButtonStaffSearch_Click(object sender, EventArgs e)
        {
            SearchStaff_ClientForm serchStaff = new SearchStaff_ClientForm();
            serchStaff.ShowDialog();
        }


         public void SeedData()
        {
            try
            {

                context.Clients.Load();
                context.Staffs.Load();
                context.Staff_Time_Tracker.Load();
                context.Services.Load();
                context.BookingDetails.Load();

                context.Database.Log = (s => Debug.Write(s));

                context.Clients.Local.Clear();
                context.SaveChanges();


                List<Client> clientList = new List<Client>()
                  {
                               new Client {  Client_Phone_Num="7782885224",Client_First_Name="Alisha",Client_Last_Name="Lalhal",Client_Email="alishalalhal@gmail.com" },
                               new Client {  Client_Phone_Num="7782885112",Client_First_Name="John",Client_Last_Name="Smith",Client_Email="JohnSmith121@gmail.com" },
                               new Client {  Client_Phone_Num="7782885664",Client_First_Name="Ankita",Client_Last_Name="Chaudhary",Client_Email="Ankitachau133@gmail.com" },
                               new Client {  Client_Phone_Num="7782885221",Client_First_Name="Neal",Client_Last_Name="o'brian",Client_Email="nealBrian@gmail.com" },
                               new Client {  Client_Phone_Num="7782882112",Client_First_Name="Amy",Client_Last_Name="Kaura",Client_Email="amykaura@gmail.com" },
                               new Client {  Client_Phone_Num="6049287378",Client_First_Name="Jessica",Client_Last_Name="Day",Client_Email="jessicad@gmail.com" },
                               new Client {  Client_Phone_Num="6042885224",Client_First_Name="Nick",Client_Last_Name="Miller",Client_Email="nickmiller122@gmail.com" },
                               new Client {  Client_Phone_Num="6042883224",Client_First_Name="Winston",Client_Last_Name="Bishop",Client_Email="winstonBishop@gmail.com" },
                               new Client {  Client_Phone_Num="6042831224",Client_First_Name="Noel",Client_Last_Name="Noel",Client_Email="NoelMac@gmail.com" },
                               new Client {  Client_Phone_Num="5782392343",Client_First_Name="Amrita",Client_Last_Name="Banerjee",Client_Email="AmritBanerjee@gmail.com" },

                           };
                context.Clients.AddRange(clientList);
                context.SaveChanges();


                context.Staffs.Local.Clear();
                context.SaveChanges();

                context.Staff_Time_Tracker.Local.Clear();
                context.SaveChanges();



                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Staff', RESEED, 0)");
                context.SaveChanges();

                List<Staff> staffList = new List<Staff>() {
                new Staff {  Staff_Phone_Number="7782885224",Staff_First_Name="Amrit",Staff_Last_Name="Kaur",Staff_Email="AmritKaur1441@gmail.com" },
                new Staff {  Staff_Phone_Number="6045321162",Staff_First_Name="Vishali",Staff_Last_Name="Kaur",Staff_Email="Vishali12@gmail.com" },
                new Staff {  Staff_Phone_Number="1238682655",Staff_First_Name="Karan",Staff_Last_Name="Singh",Staff_Email="Karan551@gmail.com" },
                new Staff {  Staff_Phone_Number="3049920992",Staff_First_Name="Gurdeep",Staff_Last_Name="Singh",Staff_Email="Gurdeep901@gmail.com" },
                new Staff {  Staff_Phone_Number="2073910292",Staff_First_Name="Gagan",Staff_Last_Name="Singh",Staff_Email="GaganSingh@info.com" },
                new Staff {  Staff_Phone_Number="6046273829",Staff_First_Name="Mani",Staff_Last_Name="Singh",Staff_Email="ManiSingh@gmail.com" },
                new Staff {  Staff_Phone_Number="7783920193",Staff_First_Name="Mandeep",Staff_Last_Name="Singh",Staff_Email="Mandeep1771@gmail.com" },
                new Staff {  Staff_Phone_Number="7782910029",Staff_First_Name="Sukhpreet",Staff_Last_Name="Kaur",Staff_Email="SukhKaur@yahoo.com" },
                new Staff {  Staff_Phone_Number="7782911928",Staff_First_Name="Manmeet",Staff_Last_Name="Kaur",Staff_Email="abc@gmail.com" },
                new Staff {  Staff_Phone_Number="6046282930",Staff_First_Name="Lisa",Staff_Last_Name="Haiden",Staff_Email="xyz@gmail.com" },

            };
                context.Staffs.AddRange(staffList);
                context.SaveChanges();

                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Staff_Time_Tracker', RESEED, 0)");
                context.SaveChanges();

                context.Services.Load();
                context.Services.Local.Clear();

                context.SaveChanges();
                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Services', RESEED, 0)");
                context.SaveChanges();


                List<Service> serviceList = new List<Service>()
            {
                new Service{ Service_Name="Men's Haircut", Service_Price=15.00m, Service_TimeTaken=20},
                new Service{ Service_Name="Men's Haircut and beard", Service_Price=26.00m, Service_TimeTaken=30},
                new Service{ Service_Name="Kid's Haircut", Service_Price=10.00m, Service_TimeTaken=15},
                new Service{ Service_Name="Women's Simple Trim", Service_Price=15.00m, Service_TimeTaken=20},
                new Service{ Service_Name="Women's Layers Cut", Service_Price=30.00m, Service_TimeTaken=45},
                new Service{ Service_Name="Pedicure", Service_Price=30.00m, Service_TimeTaken=30},


            };
                context.Services.AddRange(serviceList);
                context.SaveChanges();

                context.BookingDetails.Load();

                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('BookingDetails', RESEED, 0)");
                context.SaveChanges();
                    context.BookingDetails.Local.Clear();
                     context.SaveChanges();

                     context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('BookingDetails', RESEED, 0)");
                     context.SaveChanges();

                     List<BookingDetail> bookingDataList = new List<BookingDetail>()
                 {
                     new BookingDetail{Client_PhoneNumber=clientList[0].Client_Phone_Num, Service_ID=serviceList[0].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-20),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-20), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[0].Client_Phone_Num, Service_ID=serviceList[0].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-30),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-30), Service_EndTime=DateTime.Now.AddHours(-1.2)},
                     new BookingDetail{Client_PhoneNumber=clientList[0].Client_Phone_Num, Service_ID=serviceList[0].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-40),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-40), Service_EndTime=DateTime.Now.AddHours(-1.2)},
                     new BookingDetail{Client_PhoneNumber=clientList[0].Client_Phone_Num, Service_ID=serviceList[0].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-31),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-31), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[0].Client_Phone_Num, Service_ID=serviceList[0].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-42),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-42), Service_EndTime=DateTime.Now.AddHours(-1.2)},
                     new BookingDetail{Client_PhoneNumber=clientList[0].Client_Phone_Num, Service_ID=serviceList[0].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(15),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(15), Service_EndTime=DateTime.Now.AddHours(-1.2)},
                     new BookingDetail{Client_PhoneNumber=clientList[0].Client_Phone_Num, Service_ID=serviceList[0].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(30),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(30), Service_EndTime=DateTime.Now.AddHours(-1.2)},

                     new BookingDetail{Client_PhoneNumber=clientList[1].Client_Phone_Num, Service_ID=serviceList[1].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-20),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-20), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[1].Client_Phone_Num, Service_ID=serviceList[1].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-4),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-4), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[1].Client_Phone_Num, Service_ID=serviceList[1].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-70),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-70), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[1].Client_Phone_Num, Service_ID=serviceList[1].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-8),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-8), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[1].Client_Phone_Num, Service_ID=serviceList[1].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(10),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(10), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[1].Client_Phone_Num, Service_ID=serviceList[1].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(20),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(20), Service_EndTime=DateTime.Now.AddHours(-1)},


                     new BookingDetail{Client_PhoneNumber=clientList[2].Client_Phone_Num, Service_ID=serviceList[2].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(11),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(11), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[2].Client_Phone_Num, Service_ID=serviceList[2].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(29),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(29), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[2].Client_Phone_Num, Service_ID=serviceList[2].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-20),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-20), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[2].Client_Phone_Num, Service_ID=serviceList[2].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-40),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-40), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[2].Client_Phone_Num, Service_ID=serviceList[2].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-30),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-30), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[2].Client_Phone_Num, Service_ID=serviceList[2].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-21),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-21), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[2].Client_Phone_Num, Service_ID=serviceList[2].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-22),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-22), Service_EndTime=DateTime.Now.AddHours(-1)},


                     new BookingDetail{Client_PhoneNumber=clientList[3].Client_Phone_Num, Service_ID=serviceList[3].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-9),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-9), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[3].Client_Phone_Num, Service_ID=serviceList[3].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-6),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-6), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[3].Client_Phone_Num, Service_ID=serviceList[3].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-50),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-50), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[3].Client_Phone_Num, Service_ID=serviceList[3].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-56),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-56), Service_EndTime=DateTime.Now.AddHours(-1)},
                     new BookingDetail{Client_PhoneNumber=clientList[3].Client_Phone_Num, Service_ID=serviceList[3].Service_ID, Service_Date=DateTime.Today.AddYears(-1).AddDays(-23),Staff_ID=staffList[0].Staff_ID,Service_StartTime=DateTime.Now.AddYears(-1).AddDays(-23), Service_EndTime=DateTime.Now.AddHours(-1)},



                };
                     context.BookingDetails.AddRange(bookingDataList);
                     context.SaveChanges();

                context.Staff_Time_Tracker.Local.Clear();
                context.SaveChanges();

                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Staff_Time_Tracker', RESEED, 0)");
                context.SaveChanges();

                List<Staff_Time_Tracker> staffTimeTracerList = new List<Staff_Time_Tracker>()
                {
                    new Staff_Time_Tracker{Staff_ID=staffList[0].Staff_ID,Staff_Time_IN ="4", Staff_Time_Out="5", Staff_Hours=1.0m,Date= DateTime.Today, Status=1 },
                    new Staff_Time_Tracker{Staff_ID=staffList[0].Staff_ID,Staff_Time_IN ="4", Staff_Time_Out="5", Staff_Hours=1.0m,Date= DateTime.Today, Status=1 },
                    new Staff_Time_Tracker{Staff_ID=staffList[0].Staff_ID,Staff_Time_IN ="4", Staff_Time_Out="5", Staff_Hours=1.0m,Date= DateTime.Today, Status=1 },
                    new Staff_Time_Tracker{Staff_ID=staffList[0].Staff_ID,Staff_Time_IN ="4", Staff_Time_Out="5", Staff_Hours=1.0m,Date= DateTime.Today, Status=1 },


                    new Staff_Time_Tracker{Staff_ID=staffList[1].Staff_ID,Staff_Time_IN ="3", Staff_Time_Out="5", Staff_Hours=2.0m,Date= DateTime.Today, Status=1 },
                    new Staff_Time_Tracker{Staff_ID=staffList[1].Staff_ID,Staff_Time_IN ="3", Staff_Time_Out="5", Staff_Hours=2.0m,Date= DateTime.Today, Status=1 },
                    new Staff_Time_Tracker{Staff_ID=staffList[1].Staff_ID,Staff_Time_IN ="3", Staff_Time_Out="5", Staff_Hours=2.0m,Date= DateTime.Today, Status=1 },
                    new Staff_Time_Tracker{Staff_ID=staffList[1].Staff_ID,Staff_Time_IN ="3", Staff_Time_Out="5", Staff_Hours=2.0m,Date= DateTime.Today, Status=1 },

                    new Staff_Time_Tracker{Staff_ID=staffList[2].Staff_ID,Staff_Time_IN ="3", Staff_Time_Out="6", Staff_Hours=3.0m,Date= DateTime.Today, Status=1 },
                    new Staff_Time_Tracker{Staff_ID=staffList[2].Staff_ID,Staff_Time_IN ="3", Staff_Time_Out="6", Staff_Hours=3.0m,Date= DateTime.Today, Status=1 },
                    new Staff_Time_Tracker{Staff_ID=staffList[2].Staff_ID,Staff_Time_IN ="3", Staff_Time_Out="6", Staff_Hours=3.0m,Date= DateTime.Today, Status=1 },
                    new Staff_Time_Tracker{Staff_ID=staffList[2].Staff_ID,Staff_Time_IN ="3", Staff_Time_Out="6", Staff_Hours=3.0m,Date= DateTime.Today, Status=1 },

                };
                context.Staff_Time_Tracker.AddRange(staffTimeTracerList);
                context.SaveChanges();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);

            }

        }
    }
}
