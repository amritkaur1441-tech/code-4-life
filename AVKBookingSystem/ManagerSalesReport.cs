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
    public partial class ManagerSalesReport : Form
    {
        BobsSalonEntities context;
        DateTime date = DateTime.Today;

        public ManagerSalesReport()
        {
            InitializeComponent();
            InitializeMyComponents();
            context = new BobsSalonEntities();
            buttonCurrentYear.Click += ButtonCurrentYear_Click;
            buttonPrevYear.Click += ButtonPrevYear_Click;

        }

        private void ButtonPrevYear_Click(object sender, EventArgs e)
        {
            SalesReport(date.Year - 1);
         //   MessageBox.Show((date.Year - 1).ToString());
        }

        private void ButtonCurrentYear_Click(object sender, EventArgs e)
        {
            SalesReport(date.Year);
        }



        private void SalesReport(int year)
        {
            context.BookingDetails.Load();

            chartSalesSeries.Series["SeriesSales"].XValueMember = "Month";
            chartSalesSeries.Series["SeriesSales"].YValueMembers = "Sales";

            var querySalesReport = context.BookingDetails
                .Where(i => i.Service_Date.Year == year)
                 .GroupBy(i => i.Service_Date.Month )
                 .Select(i => new 
                 {
                     Sales = i.Sum(f=>f.Service.Service_Price),
                     Month = i.Key
                 }).ToList();
                
            chartSalesSeries.DataSource = querySalesReport;
            chartSalesSeries.DataBind();


        }

        public void InitializeMyComponents()
        {
            StringBuilder stringBuilder = new StringBuilder();

      
            stringBuilder.AppendLine("P");
            stringBuilder.AppendLine("R");
            stringBuilder.AppendLine("I");
            stringBuilder.AppendLine("C");
            stringBuilder.AppendLine("E");
            labelPrice.Text = (stringBuilder.ToString());


        }

    }
}
