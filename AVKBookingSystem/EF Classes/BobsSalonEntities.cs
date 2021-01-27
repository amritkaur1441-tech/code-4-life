namespace AVKBookingSystem.EF_Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BobsSalonEntities : DbContext
    {
        public BobsSalonEntities()
            : base("name=BobsSalonConnection")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Staff_Time_Tracker> Staff_Time_Tracker { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingDetail>()
                .Property(e => e.Client_PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_Phone_Num)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.BookingDetails)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.Client_PhoneNumber);

            modelBuilder.Entity<Service>()
                .Property(e => e.Service_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Staff_Phone_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Staff_First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Staff_Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Staff_Email)
                .IsUnicode(false);

            modelBuilder.Entity<Staff_Time_Tracker>()
                .Property(e => e.Staff_Time_IN)
                .IsUnicode(false);

            modelBuilder.Entity<Staff_Time_Tracker>()
                .Property(e => e.Staff_Time_Out)
                .IsUnicode(false);
        }
    }
}
