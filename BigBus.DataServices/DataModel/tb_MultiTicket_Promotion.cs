namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_MultiTicket_Promotion")]
    public partial class MultiTicket_Promotion
    {
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ident { get; set; }

        [StringLength(50)]
        public string Promotion_Id { get; set; }

        [StringLength(100)]
        public string Ticket_Id { get; set; }

        [StringLength(100)]
        public string Ticket_Name { get; set; }

        [StringLength(50)]
        public string iDex { get; set; }

        [StringLength(50)]
        public string Checked { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }
    }
}
