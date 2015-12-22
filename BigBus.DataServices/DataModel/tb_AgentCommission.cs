namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AgentCommission")]
    public partial class AgentCommission
    {
        public Guid Id { get; set; }

        public Guid Agent_Id { get; set; }

        public Guid Ticket_Id { get; set; }

        public Guid Currency_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TicketType { get; set; }

        public decimal Commission { get; set; }

        public bool Enabled { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public bool IsCashSale { get; set; }

        public virtual User User { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
