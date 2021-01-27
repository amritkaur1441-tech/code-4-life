namespace AVKBookingSystem.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        [Key]
        [StringLength(50)]
        public string Client_Phone_Num { get; set; }

        [Required]
        [StringLength(50)]
        public string Client_First_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Client_Last_Name { get; set; }

        [StringLength(50)]
        public string Client_Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
