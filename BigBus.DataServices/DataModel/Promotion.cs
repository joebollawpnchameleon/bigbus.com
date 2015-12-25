namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Promotion")]
    public class Promotion
    {
        public Promotion()
        {
            BasketPromotion = new HashSet<BasketPromotion>();
        }

        [StringLength(50)]
        public string Id { get; set; }

        [Column("OfferTicket_Id")]
        public Guid? OfferTicketId { get; set; }

        [Column("DiscountedTicket_Id")]
        public Guid? DiscountedTicketId { get; set; }

        public decimal? PercentageValue { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }

        public bool Enabled { get; set; }

        [StringLength(120)]
        public string Name { get; set; }

        [StringLength(50)]
        public string PromotionType { get; set; }

        [StringLength(50)]
        [Column("MicroSite_Id")]
        public string MicroSiteId { get; set; }

        [StringLength(20)]
        [Column("OfferTicket_Type")]
        public string OfferTicketType { get; set; }

        public int? OfferTicketPurchaseAmount { get; set; }

        [StringLength(20)]
        [Column("DiscountedTicket_Type")]
        public string DiscountedTicketType { get; set; }

        public int? DiscountedTicketReceiveAmount { get; set; }

        public decimal? DollarDiscountValue { get; set; }

        public decimal? EuroDiscountValue { get; set; }

        public decimal? PoundDiscountValue { get; set; }

        [StringLength(500)]
        [Column("OfferTicket_Message")]
        public string OfferTicketMessage { get; set; }

        [StringLength(50)]
        public string TicketDateType { get; set; }

        public decimal? AEDDiscountValue { get; set; }

        public decimal? HKDDiscountValue { get; set; }

        public virtual ICollection<BasketPromotion> BasketPromotion { get; set; }
    }
}
