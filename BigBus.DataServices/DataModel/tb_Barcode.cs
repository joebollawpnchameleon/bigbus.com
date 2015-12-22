namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Barcode")]
    public partial class Barcode
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Microsite_Id { get; set; }

        [StringLength(50)]
        public string Ticket_Type { get; set; }

        [StringLength(6)]
        public string BarcodePrefix { get; set; }

        public int? NextAvailableBarcode { get; set; }

        public int NextAvailableDrBarcode { get; set; }

        [StringLength(50)]
        public string Ticket_TicketType { get; set; }

        public Guid? Ticket_Id { get; set; }

        public virtual MicroSite MicroSite { get; set; }
    }
}
