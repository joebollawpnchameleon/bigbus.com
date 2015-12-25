namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Ticket_ExclusionWeekday")]
    public class TicketExclusionWeekday
    {
        public Guid Id { get; set; }

        [Column("Ticket_Id")]
        public Guid TicketId { get; set; }

        public bool ExcludeSundays { get; set; }

        public bool ExcludeMondays { get; set; }

        public bool ExcludeTuesdays { get; set; }

        public bool ExcludeWednesdays { get; set; }

        public bool ExcludeThursdays { get; set; }

        public bool ExcludeFridays { get; set; }

        public bool ExcludeSaturdays { get; set; }

        [Required]
        [StringLength(50)]
        [Column("AdminUser_Id")]
        public string AdminUserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
