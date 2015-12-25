namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_MultiTicket_Promotion")]
    public class MultiTicketPromotion
    {
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ident { get; set; }

        [StringLength(50)]
        [Column("Promotion_Id")]
        public string PromotionId { get; set; }

        [StringLength(100)]
        [Column("Ticket_Id")]
        public string TicketId { get; set; }

        [StringLength(100)]
        [Column("Ticket_Name")]
        public string TicketName { get; set; }

        [StringLength(50)]
        [Column("iDex")]
        public string IDex { get; set; }

        [StringLength(50)]
        public string Checked { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }
    }
}
