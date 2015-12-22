namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_BasketLine")]
    public partial class BasketLine
    {
        public Guid Id { get; set; }

        public Guid? Basket_Id { get; set; }

        public Guid? Ticket_Id { get; set; }

        public bool? FixedDateTicket { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TicketDate { get; set; }

        [StringLength(50)]
        public string TicketType { get; set; }

        public int? TicketQuantity { get; set; }

        [StringLength(20)]
        public string Promotion_Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateAdded { get; set; }

        [StringLength(10)]
        public string DepartureTimeHour { get; set; }

        [StringLength(10)]
        public string DepartureTimeMinute { get; set; }

        [StringLength(100)]
        public string DeparturePoint { get; set; }

        public bool IsPromotionTicket { get; set; }

        public bool PromotionTicketRemoved { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TicketAttractionDate { get; set; }

        [StringLength(10)]
        public string TicketAttractionTimeHour { get; set; }

        [StringLength(10)]
        public string TicketAttractionTimeMin { get; set; }

        [StringLength(10)]
        public string AttractionTimeSection { get; set; }
    }
}
