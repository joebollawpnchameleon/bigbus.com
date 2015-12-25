namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Stop")]
    public class Stop
    {
        public Stop()
        {
            GroupBookingStop = new HashSet<GroupBookingStop>();
            PlaceOfInterestStop = new HashSet<PlaceOfInterestStop>();
            RouteStop = new HashSet<RouteStop>();
            StopLanguage = new HashSet<StopLanguage>();
        }

        public Guid Id { get; set; }

        [StringLength(500)]
        public string ExistingSiteText { get; set; }

        public int? TempId { get; set; }

        [StringLength(100)]
        public string StopName { get; set; }

        [Required]
        [StringLength(50)]
        [Column("MicroSite_Id")]
        public string MicroSiteId { get; set; }

        public virtual ICollection<GroupBookingStop> GroupBookingStop { get; set; }

        [Column("PlaceOfInterest_Stop")]
        public virtual ICollection<PlaceOfInterestStop> PlaceOfInterestStop { get; set; }

        [Column("Route_Stop")]
        public virtual ICollection<RouteStop> RouteStop { get; set; }

        public virtual ICollection<StopLanguage> StopLanguage { get; set; }
    }
}
