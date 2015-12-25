namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_TicketCost")]
    public partial class TicketCost
    {
        public Guid Id { get; set; }

        [Column("Ticket_Id")]
        public Guid? TicketId { get; set; }

        [Column("Currency_Id")]
        public Guid? CurrencyId { get; set; }

        public decimal? AdultTicketCost { get; set; }

        public decimal? ChildTicketCost { get; set; }

        public decimal? FamilyTicketCost { get; set; }

        public decimal? ConcessionTicketCost { get; set; }

        public decimal? GroupAdultTicketCost { get; set; }

        public decimal? GroupChildTicketCost { get; set; }

        public decimal? AgentAdultTicketCost { get; set; }

        public decimal? AgentChildTicketCost { get; set; }

        public decimal? AgentFamilyTicketCost { get; set; }

        public decimal? AgentConcessionTicketCost { get; set; }

        public decimal? AgentGroupAdultTicketCost { get; set; }

        public decimal? AgentGroupChildTicketCost { get; set; }

        public decimal? InfantTicketCost { get; set; }

        public decimal? AgentInfantTicketCost { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
