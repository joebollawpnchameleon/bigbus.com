namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_GroupBooking")]
    public class GroupBooking
    {
        public GroupBooking()
        {
            GroupBookingStop = new HashSet<GroupBookingStop>();
            GroupBookingTime = new HashSet<GroupBookingTime>();
        }

        public Guid Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(50)]
        [Column("MicroSite_Id")]
        public string MicroSiteId { get; set; }

        public bool AvailableMonday { get; set; }

        public bool AvailableTuesday { get; set; }

        public bool AvailableWednesday { get; set; }

        public bool AvailableThursday { get; set; }

        public bool AvailableFriday { get; set; }

        public bool AvailableSaturday { get; set; }

        public bool AvailableSunday { get; set; }

        public bool Available0900 { get; set; }

        public bool Available1000 { get; set; }

        public bool Available1100 { get; set; }

        public bool Available1200 { get; set; }

        public bool Available1300 { get; set; }

        public bool Available1400 { get; set; }

        public bool Available1500 { get; set; }

        public bool Available1600 { get; set; }

        public bool Available1700 { get; set; }

        public bool Available1800 { get; set; }

        public bool IsLive { get; set; }

        [StringLength(50)]
        [Column("Ticket_Name")]
        public string TicketName { get; set; }

        [StringLength(50)]
        [Column("Ticket_Id")]
        public string TicketId { get; set; }

        public virtual ICollection<GroupBookingStop> GroupBookingStop { get; set; }

        public virtual ICollection<GroupBookingTime> GroupBookingTime { get; set; }
    }
}
