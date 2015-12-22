namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Stop")]
    public partial class Stop
    {
        public Stop()
        {
            GroupBookingStop = new HashSet<GroupBookingStop>();
            PlaceOfInterest_Stop = new HashSet<PlaceOfInterest_Stop>();
            Route_Stop = new HashSet<Route_Stop>();
            Stop_Language = new HashSet<Stop_Language>();
        }

        public Guid Id { get; set; }

        [StringLength(500)]
        public string ExistingSiteText { get; set; }

        public int? TempId { get; set; }

        [StringLength(100)]
        public string StopName { get; set; }

        [Required]
        [StringLength(50)]
        public string MicroSite_Id { get; set; }

        public virtual ICollection<GroupBookingStop> GroupBookingStop { get; set; }

        public virtual ICollection<PlaceOfInterest_Stop> PlaceOfInterest_Stop { get; set; }

        public virtual ICollection<Route_Stop> Route_Stop { get; set; }

        public virtual ICollection<Stop_Language> Stop_Language { get; set; }
    }
}
