namespace AVKBookingSystem
{
    partial class BookAppointment
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
            this.listBoxServiceName = new System.Windows.Forms.ListBox();
            this.listBoxStaffName = new System.Windows.Forms.ListBox();
            this.dataGridViewBookingDetails = new System.Windows.Forms.DataGridView();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonBookAppointment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelSuccessDisplay = new System.Windows.Forms.Label();
            this.bobsSalonDataBaseDataSet = new AVKBookingSystem.BobsSalonDataBaseDataSet();
            this.bookingDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingDetailsTableAdapter = new AVKBookingSystem.BobsSalonDataBaseDataSetTableAdapters.BookingDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bobsSalonDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxServiceName
            // 
            this.listBoxServiceName.FormattingEnabled = true;
            this.listBoxServiceName.ItemHeight = 20;
            this.listBoxServiceName.Location = new System.Drawing.Point(66, 59);
            this.listBoxServiceName.Name = "listBoxServiceName";
            this.listBoxServiceName.Size = new System.Drawing.Size(160, 224);
            this.listBoxServiceName.TabIndex = 0;
            // 
            // listBoxStaffName
            // 
            this.listBoxStaffName.FormattingEnabled = true;
            this.listBoxStaffName.ItemHeight = 20;
            this.listBoxStaffName.Location = new System.Drawing.Point(272, 59);
            this.listBoxStaffName.Name = "listBoxStaffName";
            this.listBoxStaffName.Size = new System.Drawing.Size(165, 224);
            this.listBoxStaffName.TabIndex = 1;
            // 
            // dataGridViewBookingDetails
            // 
            this.dataGridViewBookingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingDetails.Location = new System.Drawing.Point(32, 347);
            this.dataGridViewBookingDetails.Name = "dataGridViewBookingDetails";
            this.dataGridViewBookingDetails.RowTemplate.Height = 28;
            this.dataGridViewBookingDetails.Size = new System.Drawing.Size(1297, 173);
            this.dataGridViewBookingDetails.TabIndex = 2;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Location = new System.Drawing.Point(457, 134);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerTime.TabIndex = 6;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(457, 59);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDate.TabIndex = 7;
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(951, 61);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(188, 26);
            this.textBoxPhoneNum.TabIndex = 8;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(951, 102);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(188, 26);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(951, 142);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(188, 26);
            this.textBoxLastName.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(951, 189);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(188, 26);
            this.textBoxEmail.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(830, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(859, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(859, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(897, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClient.Location = new System.Drawing.Point(989, 237);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(150, 46);
            this.buttonAddClient.TabIndex = 16;
            this.buttonAddClient.Text = "Add new client";
            this.buttonAddClient.UseVisualStyleBackColor = false;
            // 
            // buttonBookAppointment
            // 
            this.buttonBookAppointment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBookAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookAppointment.Location = new System.Drawing.Point(457, 220);
            this.buttonBookAppointment.Name = "buttonBookAppointment";
            this.buttonBookAppointment.Size = new System.Drawing.Size(207, 63);
            this.buttonBookAppointment.TabIndex = 17;
            this.buttonBookAppointment.Text = "Book Appointment";
            this.buttonBookAppointment.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Select Service";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Select Staff";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Pick Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Pick Time";
            // 
            // labelSuccessDisplay
            // 
            this.labelSuccessDisplay.AutoSize = true;
            this.labelSuccessDisplay.Location = new System.Drawing.Point(830, 9);
            this.labelSuccessDisplay.Name = "labelSuccessDisplay";
            this.labelSuccessDisplay.Size = new System.Drawing.Size(0, 20);
            this.labelSuccessDisplay.TabIndex = 22;
            // 
            // bobsSalonDataBaseDataSet
            // 
            this.bobsSalonDataBaseDataSet.DataSetName = "BobsSalonDataBaseDataSet";
            this.bobsSalonDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingDetailsBindingSource
            // 
            this.bookingDetailsBindingSource.DataMember = "BookingDetails";
            this.bookingDetailsBindingSource.DataSource = this.bobsSalonDataBaseDataSet;
            // 
            // bookingDetailsTableAdapter
            // 
            this.bookingDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // BookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 558);
            this.Controls.Add(this.labelSuccessDisplay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBookAppointment);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxPhoneNum);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.dataGridViewBookingDetails);
            this.Controls.Add(this.listBoxStaffName);
            this.Controls.Add(this.listBoxServiceName);
            this.Name = "BookAppointment";
            this.Text = "BookAppointment";
            this.Load += new System.EventHandler(this.BookAppointment_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bobsSalonDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxServiceName;
        private System.Windows.Forms.ListBox listBoxStaffName;
        private System.Windows.Forms.DataGridView dataGridViewBookingDetails;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonBookAppointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelSuccessDisplay;
        private BobsSalonDataBaseDataSet bobsSalonDataBaseDataSet;
        private System.Windows.Forms.BindingSource bookingDetailsBindingSource;
        private BobsSalonDataBaseDataSetTableAdapters.BookingDetailsTableAdapter bookingDetailsTableAdapter;
    }
}