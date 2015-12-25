namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_PlaceOfInterest")]
    public class PlaceOfInterest
    {
        public PlaceOfInterest()
        {
            PlaceOfInterestLanguage = new HashSet<PlaceOfInterestLanguage>();
            PlaceOfInterestStop = new HashSet<PlaceOfInterestStop>();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column("Ticket_Id")]
        public Guid? TicketId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("MicroSite_Id")]
        public string MicroSiteId { get; set; }

        public virtual ICollection<PlaceOfInterestLanguage> PlaceOfInterestLanguage { get; set; }

        public virtual ICollection<PlaceOfInterestStop> PlaceOfInterestStop { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
