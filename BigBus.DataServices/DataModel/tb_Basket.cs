namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Basket")]
    public partial class Basket
    {
        public Basket()
        {
            BasketPromotion = new HashSet<BasketPromotion>();
        }

        public Guid Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public Guid? User_Id { get; set; }

        public Guid? Currency_Id { get; set; }

        public decimal Total { get; set; }

        [StringLength(100)]
        public string LeadTravelerName { get; set; }

        [StringLength(100)]
        public string GiftTravelerName { get; set; }

        [StringLength(500)]
        public string ExternalBarcode { get; set; }

        [StringLength(100)]
        public string ExternalOrderId { get; set; }

        public decimal? DiscountValue { get; set; }

        public virtual ICollection<BasketPromotion> BasketPromotion { get; set; }
    }
}
