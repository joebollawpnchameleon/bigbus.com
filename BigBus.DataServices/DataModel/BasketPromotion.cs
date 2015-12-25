namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Basket_Promotion")]
    public class BasketPromotion
    {
        public Guid Id { get; set; }

        [Column("Basket_Id")]
        public Guid? BasketId { get; set; }

        [StringLength(50)]
        [Column("Promotion_Id")]
        public string PromotionId { get; set; }

        public bool PromotionApplied { get; set; }

        public virtual Basket Basket { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
}
