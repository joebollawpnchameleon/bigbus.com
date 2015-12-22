namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Promotion_DiscountedTicket")]
    public partial class Promotion_DiscountedTicket
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Promotion_Id { get; set; }

        [StringLength(50)]
        public string Ticket_Id { get; set; }

        [StringLength(50)]
        public string Quantity { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string iDex { get; set; }

        public bool? Enabled { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }
    }
}
