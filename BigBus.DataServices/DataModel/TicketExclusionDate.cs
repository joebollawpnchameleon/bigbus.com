namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Ticket_ExclusionDate")]
    public class TicketExclusionDate
    {
        public Guid Id { get; set; }

        [Column("Ticket_Id")]
        public Guid TicketId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ExclusionDate { get; set; }

        [Required]
        [StringLength(50)]
        [Column("AdminUser_Id")]
        public string AdminUserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public bool ExcludeGroup { get; set; }
    }
}
