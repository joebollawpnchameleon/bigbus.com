namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_PlaceOfInterest")]
    public partial class PlaceOfInterest
    {
        public PlaceOfInterest()
        {
            PlaceOfInterest_Language = new HashSet<PlaceOfInterest_Language>();
            PlaceOfInterest_Stop = new HashSet<PlaceOfInterest_Stop>();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public Guid? Ticket_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string MicroSite_Id { get; set; }

        public virtual ICollection<PlaceOfInterest_Language> PlaceOfInterest_Language { get; set; }

        public virtual ICollection<PlaceOfInterest_Stop> PlaceOfInterest_Stop { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
