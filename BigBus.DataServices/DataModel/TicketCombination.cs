namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_TicketCombination")]
    public class TicketCombination
    {
        public Guid Id { get; set; }

        [Column("ParentTicket_Id")]
        public Guid ParentTicketId { get; set; }

        [Column("TourTicket_Id")]
        public Guid TourTicketId { get; set; }

        [Column("AttractionTicket_Id")]
        public Guid AttractionTicketId { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
