namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Route")]
    public partial class Route
    {
        public Route()
        {
            Route_Language = new HashSet<Route_Language>();
            Route_Stop = new HashSet<Route_Stop>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string MicroSite_Id { get; set; }

        [StringLength(50)]
        public string Admin_Name { get; set; }

        public int? Position { get; set; }

        public Guid? Ticket_Id { get; set; }

        public Guid? ImageMetaData_Id { get; set; }

        public virtual MicroSite MicroSite { get; set; }

        public virtual ICollection<Route_Language> Route_Language { get; set; }

        public virtual ICollection<Route_Stop> Route_Stop { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
