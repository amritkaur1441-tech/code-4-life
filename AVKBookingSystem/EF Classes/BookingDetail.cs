namespace AVKBookingSystem.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookingDetail
    {
        [Key]
        public int Booking_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Client_PhoneNumber { get; set; }

        public int Service_ID { get; set; }

        public int Staff_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Service_Date { get; set; }

        public DateTime Service_StartTime { get; set; }

        public DateTime Service_EndTime { get; set; }

        public virtual Client Client { get; set; }

        public virtual Service Service { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
