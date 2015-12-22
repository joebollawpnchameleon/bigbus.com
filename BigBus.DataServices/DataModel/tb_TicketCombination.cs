namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_TicketCombination")]
    public partial class TicketCombination
    {
        public Guid Id { get; set; }

        public Guid ParentTicket_Id { get; set; }

        public Guid TourTicket_Id { get; set; }

        public Guid AttractionTicket_Id { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
