namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_ExternalOrder_Barcode")]
    public class ExternalOrderBarcode
    {
        public Guid Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [StringLength(100)]
        public string Barcode { get; set; }

        [StringLength(100)]
        public string CustomerTypeName { get; set; }

        [StringLength(10)]
        public string PackageId { get; set; }

        [StringLength(10)]
        public string EventId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EventDate { get; set; }

        [StringLength(30)]
        public string EventTime { get; set; }

        [StringLength(30)]
        public string VendorId { get; set; }

        [Required]
        [StringLength(100)]
        public string ExternalOrderId { get; set; }

        public int CustomerTypeId { get; set; }
    }
}
