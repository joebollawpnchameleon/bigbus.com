namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Orderline")]
    public partial class Orderline
    {
        public Guid Id { get; set; }

        public Guid? Order_Id { get; set; }

        public Guid? Ticket_Id { get; set; }

        public bool? FixedDateTicket { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TicketDate { get; set; }

        [StringLength(50)]
        public string TicketType { get; set; }

        public int? TicketQuantity { get; set; }

        public decimal? TicketCost { get; set; }

        [StringLength(20)]
        public string Promotion_Id { get; set; }

        [StringLength(10)]
        public string Promotion_Value { get; set; }

        public decimal? GrossOrderLineValue { get; set; }

        public decimal? NettOrderLineValue { get; set; }

        [StringLength(10)]
        public string DepartureTimeHour { get; set; }

        [StringLength(10)]
        public string DepartureTimeMinute { get; set; }

        [StringLength(100)]
        public string DeparturePoint { get; set; }

        [StringLength(100)]
        public string Microsite_Id { get; set; }

        [StringLength(50)]
        public string TicketTOrA { get; set; }

        [StringLength(50)]
        public string AttractionName { get; set; }

        [StringLength(50)]
        public string GeneratedBarcode { get; set; }

        public bool? IsPromotionTicket { get; set; }

        [StringLength(50)]
        public string PromotionType { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TicketRedeemedDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TicketAttractionDate { get; set; }

        [StringLength(10)]
        public string TicketAttractionTimeHour { get; set; }

        [StringLength(10)]
        public string TicketAttractionTimeMin { get; set; }

        [StringLength(10)]
        public string AttractionTimeSection { get; set; }

        public virtual Order Order { get; set; }
    }
}
