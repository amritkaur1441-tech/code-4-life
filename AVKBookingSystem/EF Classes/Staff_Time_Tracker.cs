namespace AVKBookingSystem.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Staff_Time_Tracker
    {
        [Key]
        public int TrackId { get; set; }

        public int Staff_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Staff_Time_IN { get; set; }

        [StringLength(50)]
        public string Staff_Time_Out { get; set; }

        public decimal? Staff_Hours { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int? Status { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
