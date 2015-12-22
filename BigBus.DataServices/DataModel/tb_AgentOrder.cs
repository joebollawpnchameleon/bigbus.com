namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AgentOrder")]
    public partial class AgentOrder
    {
        public Guid Id { get; set; }

        public Guid Agent_Id { get; set; }

        public Guid Order_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Order_Ref { get; set; }

        [Required]
        [StringLength(50)]
        public string Microsite_Id { get; set; }

        public Guid Currency_Id { get; set; }

        public Guid? AdultTicket_Id { get; set; }

        public int AdultTicketQuantity { get; set; }

        public decimal AdultTicketCost { get; set; }

        public Guid? ChildTicket_Id { get; set; }

        public int ChildTicketQuantity { get; set; }

        public decimal ChildTicketCost { get; set; }

        public Guid? FamilyTicket_Id { get; set; }

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

        public Guid? InfantTicket_Id { get; set; }

        public int InfantTicketQuantity { get; set; }

        public decimal InfantTicketCost { get; set; }
    }
}
