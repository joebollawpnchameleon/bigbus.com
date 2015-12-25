namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tb_Ticket")]
    public class Ticket
    {
        public Ticket()
        {
            AgentCommission = new HashSet<AgentCommission>();
            PlaceOfInterest = new HashSet<PlaceOfInterest>();
            Route = new HashSet<Route>();
            TicketExclusionWeekday = new HashSet<TicketExclusionWeekday>();
            TicketCost = new HashSet<TicketCost>();
            TicketCostVariation = new HashSet<TicketCostVariation>();
        }

        public Guid Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }

        [Required]
        [StringLength(50)]
        public string TicketType { get; set; }

        [Column("ImageMetaData_Id")]
        public Guid? ImageMetaDataId { get; set; }

        [StringLength(50)]
        [Column("MicroSite_Id")]
        public string MicroSiteId { get; set; }

        [Column("SmallImageMetaData_Id")]
        public Guid? SmallImageMetaDataId { get; set; }

        [StringLength(120)]
        public string Name { get; set; }

        public bool Enabled { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column("TicketImageMetaData_Id")]
        public Guid? TicketImageMetaDataId { get; set; }

        public bool TicketImageEnabled { get; set; }

        [StringLength(40)]
        public string TicketTextTopLine { get; set; }

        [StringLength(40)]
        public string TicketTextMiddleLine { get; set; }

        [StringLength(40)]
        public string TicketTextBottomLine { get; set; }

        public int? AttractionDisplayOrder { get; set; }

        public bool AdultTicketEnabled { get; set; }

        public bool ChildTicketEnabled { get; set; }

        public bool FamilyTicketEnabled { get; set; }

        public bool ConcessionTicketEnabled { get; set; }

        public bool GroupAdultTicketEnabled { get; set; }

        public bool GroupChildTicketEnabled { get; set; }

        public bool? IsPackage { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public bool EnabledForAgents { get; set; }

        public bool HasMobile { get; set; }

        [StringLength(130)]
        public string TicketTextLine2 { get; set; }

        [StringLength(130)]
        public string TicketTextLine3 { get; set; }

        public bool AgentsOnly { get; set; }

        public bool IsRemittanceTicket { get; set; }

        [Column("CarouselImageMetaData_Id")]
        public Guid? CarouselImageMetaDataId { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsTradeTicket { get; set; }

        public bool LimitFutureDatePurchase { get; set; }

        public int FutureDatePurchaseDayAmount { get; set; }

        public bool HasMobileAgent { get; set; }

        public Guid? AttractionApi { get; set; }

        public bool InfantTicketEnabled { get; set; }

        public bool GroupInfantTicketEnabled { get; set; }

        [StringLength(100)]
        public string EcrProductCode { get; set; }

        [StringLength(30)]
        public string EcrProductDuration { get; set; }

        public virtual ICollection<AgentCommission> AgentCommission { get; set; }

        public virtual ICollection<PlaceOfInterest> PlaceOfInterest { get; set; }

        public virtual ICollection<Route> Route { get; set; }

        public virtual ICollection<TicketExclusionWeekday> TicketExclusionWeekday { get; set; }

        public virtual ICollection<TicketCost> TicketCost { get; set; }

        public virtual ICollection<TicketCostVariation> TicketCostVariation { get; set; }
    }
}
