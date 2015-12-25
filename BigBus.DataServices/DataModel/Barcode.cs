namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Barcode")]
    public class Barcode
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        [Column("Microsite_Id")]
        public string MicrositeId { get; set; }

        [StringLength(50)]
        [Column("Ticket_Type")]
        public string TicketType { get; set; }

        [StringLength(6)]
        public string BarcodePrefix { get; set; }

        public int? NextAvailableBarcode { get; set; }

        public int NextAvailableDrBarcode { get; set; }

        [StringLength(50)]
        [Column("Ticket_TicketType")]
        public string TicketTicketType { get; set; }

        [Column("Ticket_Id")]
        public Guid? TicketId { get; set; }

        public virtual MicroSite MicroSite { get; set; }
    }
}
