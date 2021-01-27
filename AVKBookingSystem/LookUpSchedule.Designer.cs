namespace AVKBookingSystem
{
    partial class LookUpSchedule
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1DisplaySchedule = new System.Windows.Forms.DataGridView();
            this.bookingDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bobsSalonDataBaseDataSet1 = new AVKBookingSystem.BobsSalonDataBaseDataSet1();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonLookUpSchedule = new System.Windows.Forms.Button();
            this.textBoxStaffId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTotalBookings = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookingDetailsTableAdapter = new AVKBookingSystem.BobsSalonDataBaseDataSet1TableAdapters.BookingDetailsTableAdapter();
            this.textBoxDone = new System.Windows.Forms.TextBox();
            this.textBoxDoing = new System.Windows.Forms.TextBox();
            this.textBoxUpcoming = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1DisplaySchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bobsSalonDataBaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1DisplaySchedule
            // 
            this.dataGridView1DisplaySchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1DisplaySchedule.Location = new System.Drawing.Point(25, 27);
            this.dataGridView1DisplaySchedule.Name = "dataGridView1DisplaySchedule";
            this.dataGridView1DisplaySchedule.RowTemplate.Height = 28;
            this.dataGridView1DisplaySchedule.Size = new System.Drawing.Size(1165, 360);
            this.dataGridView1DisplaySchedule.TabIndex = 0;
            // 
            // bookingDetailsBindingSource
            // 
            this.bookingDetailsBindingSource.DataMember = "BookingDetails";
            this.bookingDetailsBindingSource.DataSource = this.bobsSalonDataBaseDataSet1;
            // 
            // bobsSalonDataBaseDataSet1
            // 
            this.bobsSalonDataBaseDataSet1.DataSetName = "BobsSalonDataBaseDataSet1";
            this.bobsSalonDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(141, 474);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDate.TabIndex = 1;
            // 
            // buttonLookUpSchedule
            // 
            this.buttonLookUpSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLookUpSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLookUpSchedule.Location = new System.Drawing.Point(435, 474);
            this.buttonLookUpSchedule.Name = "buttonLookUpSchedule";
            this.buttonLookUpSchedule.Size = new System.Drawing.Size(283, 74);
            this.buttonLookUpSchedule.TabIndex = 2;
            this.buttonLookUpSchedule.Text = "Check Schedule";
            this.buttonLookUpSchedule.UseVisualStyleBackColor = false;
            // 
            // textBoxStaffId
            // 
            this.textBoxStaffId.Location = new System.Drawing.Point(141, 421);
            this.textBoxStaffId.Name = "textBoxStaffId";
            this.textBoxStaffId.Size = new System.Drawing.Size(200, 26);
            this.textBoxStaffId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Date";
            // 
            // textBoxTotalBookings
            // 
            this.textBoxTotalBookings.Location = new System.Drawing.Point(141, 528);
            this.textBoxTotalBookings.Name = "textBoxTotalBookings";
            this.textBoxTotalBookings.Size = new System.Drawing.Size(200, 26);
            this.textBoxTotalBookings.TabIndex = 6;
            this.textBoxTotalBookings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Bookings";
            // 
            // bookingDetailsTableAdapter
            // 
            this.bookingDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxDone
            // 
            this.textBoxDone.BackColor = System.Drawing.Color.Red;
            this.textBoxDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDone.Location = new System.Drawing.Point(850, 421);
            this.textBoxDone.Name = "textBoxDone";
            this.textBoxDone.Size = new System.Drawing.Size(218, 26);
            this.textBoxDone.TabIndex = 8;
            this.textBoxDone.Text = "Completed";
            this.textBoxDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDoing
            // 
            this.textBoxDoing.BackColor = System.Drawing.Color.Aqua;
            this.textBoxDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDoing.Location = new System.Drawing.Point(850, 468);
            this.textBoxDoing.Name = "textBoxDoing";
            this.textBoxDoing.Size = new System.Drawing.Size(218, 26);
            this.textBoxDoing.TabIndex = 9;
            this.textBoxDoing.Text = "In Progress";
            this.textBoxDoing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUpcoming
            // 
            this.textBoxUpcoming.BackColor = System.Drawing.Color.Green;
            this.textBoxUpcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpcoming.Location = new System.Drawing.Point(850, 522);
            this.textBoxUpcoming.Name = "textBoxUpcoming";
            this.textBoxUpcoming.Size = new System.Drawing.Size(218, 26);
            this.textBoxUpcoming.TabIndex = 10;
            this.textBoxUpcoming.Text = "Upcoming";
            this.textBoxUpcoming.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LookUpSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 588);
            this.Controls.Add(this.textBoxUpcoming);
            this.Controls.Add(this.textBoxDoing);
            this.Controls.Add(this.textBoxDone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTotalBookings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStaffId);
            this.Controls.Add(this.buttonLookUpSchedule);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.dataGridView1DisplaySchedule);
            this.Name = "LookUpSchedule";
            this.Text = "LookUpSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1DisplaySchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bobsSalonDataBaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1DisplaySchedule;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonLookUpSchedule;
        private System.Windows.Forms.TextBox textBoxStaffId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTotalBookings;
        private System.Windows.Forms.Label label3;
        private BobsSalonDataBaseDataSet1 bobsSalonDataBaseDataSet1;
        private System.Windows.Forms.BindingSource bookingDetailsBindingSource;
        private BobsSalonDataBaseDataSet1TableAdapters.BookingDetailsTableAdapter bookingDetailsTableAdapter;
        private System.Windows.Forms.TextBox textBoxDone;
        private System.Windows.Forms.TextBox textBoxDoing;
        private System.Windows.Forms.TextBox textBoxUpcoming;
    }
}