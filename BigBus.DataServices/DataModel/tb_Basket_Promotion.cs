namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Basket_Promotion")]
    public partial class BasketPromotion
    {
        public Guid Id { get; set; }

        public Guid? Basket_Id { get; set; }

        [StringLength(50)]
        public string Promotion_Id { get; set; }

        public bool PromotionApplied { get; set; }

        public virtual Basket Basket { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
}
