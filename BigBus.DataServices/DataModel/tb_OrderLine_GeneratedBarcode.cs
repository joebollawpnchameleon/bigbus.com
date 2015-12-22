namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_OrderLine_GeneratedBarcode")]
    public partial class OrderLine_GeneratedBarcode
    {
        public Guid Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public Guid? OrderLine_Id { get; set; }

        [StringLength(50)]
        public string GeneratedBarcode { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? RedeemedDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? RefundDate { get; set; }

        [StringLength(50)]
        public string RefundReason { get; set; }

        [StringLength(256)]
        public string Comments { get; set; }
    }
}