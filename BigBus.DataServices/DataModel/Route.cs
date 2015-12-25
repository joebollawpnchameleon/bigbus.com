namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Route")]
    public class Route
    {
        public Route()
        {
            RouteLanguage = new HashSet<RouteLanguage>();
            RouteStop = new HashSet<RouteStop>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("MicroSite_Id")]
        public string MicroSiteId { get; set; }

        [StringLength(50)]
        [Column("Admin_Name")]
        public string AdminName { get; set; }

        public int? Position { get; set; }

        [Column("Ticket_Id")]
        public Guid? TicketId { get; set; }

        [Column("ImageMetaData_Id")]
        public Guid? ImageMetaDataId { get; set; }

        public virtual MicroSite MicroSite { get; set; }

        [Column("Route_Language")]
        public virtual ICollection<RouteLanguage> RouteLanguage { get; set; }

        public virtual ICollection<RouteStop> RouteStop { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
