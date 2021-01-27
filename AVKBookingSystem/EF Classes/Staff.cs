namespace AVKBookingSystem.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            BookingDetails = new HashSet<BookingDetail>();
            Staff_Time_Tracker = new HashSet<Staff_Time_Tracker>();
        }

        [Key]
        public int Staff_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Staff_Phone_Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Staff_First_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Staff_Last_Name { get; set; }

        [StringLength(50)]
        public string Staff_Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff_Time_Tracker> Staff_Time_Tracker { get; set; }
    }
}
