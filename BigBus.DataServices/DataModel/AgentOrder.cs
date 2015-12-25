namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AgentOrder")]
    public class AgentOrder
    {
        public Guid Id { get; set; }

        [Column("Agent_Id")]
        public Guid AgentId { get; set; }

        [Column("Order_Id")]
        public Guid OrderId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Order_Ref")]
        public string OrderRef { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Microsite_Id")]
        public string MicrositeId { get; set; }

        [Column("Currency_Id")]
        public Guid CurrencyId { get; set; }

        [Column("AdultTicket_Id")]
        public Guid? AdultTicketId { get; set; }

        public int AdultTicketQuantity { get; set; }

        public decimal AdultTicketCost { get; set; }

        [Column("ChildTicket_Id")]
        public Guid? ChildTicketId { get; set; }

        public int ChildTicketQuantity { get; set; }

        public decimal ChildTicketCost { get; set; }

        [Column("FamilyTicket_Id")]
        public Guid? FamilyTicketId { get; set; }

        public int FamilyTicketQuantity { get; set; }

        public decimal FamilyTicketCost { get; set; }

        public decimal OrderTotal { get; set; }

        public decimal CommissionTotal { get; set; }

        public bool CommissionRaised { get; set; }

        public bool CommissionPaid { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public Guid? CommissionRaisedById { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CommissionRaisedDate { get; set; }

        public Guid? CommissionPaidById { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CommissionPaidDate { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderTypeTorA { get; set; }

        [Required]
        [StringLength(50)]
        public string CommissionPaidByName { get; set; }

        [Required]
        [StringLength(50)]
        public string CommissionRaisedByName { get; set; }

        [StringLength(250)]
        public string RefundReason { get; set; }

        public bool IsCashSale { get; set; }

        public bool IsRemittanceSale { get; set; }

        public bool IsTradeTicketSale { get; set; }

        [Column("InfantTicket_Id")]
        public Guid? InfantTicketId { get; set; }

        public int InfantTicketQuantity { get; set; }

        public decimal InfantTicketCost { get; set; }
    }
}
