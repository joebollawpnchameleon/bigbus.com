namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Promotion")]
    public partial class Promotion
    {
        public Promotion()
        {
            BasketPromotion = new HashSet<BasketPromotion>();
        }

        [StringLength(50)]
        public string Id { get; set; }

        public Guid? OfferTicket_Id { get; set; }

        public Guid? DiscountedTicket_Id { get; set; }

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
        public string MicroSite_Id { get; set; }

        [StringLength(20)]
        public string OfferTicket_Type { get; set; }

        public int? OfferTicketPurchaseAmount { get; set; }

        [StringLength(20)]
        public string DiscountedTicket_Type { get; set; }

        public int? DiscountedTicketReceiveAmount { get; set; }

        public decimal? DollarDiscountValue { get; set; }

        public decimal? EuroDiscountValue { get; set; }

        public decimal? PoundDiscountValue { get; set; }

        [StringLength(500)]
        public string OfferTicket_Message { get; set; }

        [StringLength(50)]
        public string TicketDateType { get; set; }

        public decimal? AEDDiscountValue { get; set; }

        public decimal? HKDDiscountValue { get; set; }

        public virtual ICollection<BasketPromotion> BasketPromotion { get; set; }
    }
}
