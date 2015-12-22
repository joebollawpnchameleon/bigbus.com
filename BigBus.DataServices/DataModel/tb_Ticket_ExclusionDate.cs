namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Ticket_ExclusionDate")]
    public partial class Ticket_ExclusionDate
    {
        public Guid Id { get; set; }

        public Guid Ticket_Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ExclusionDate { get; set; }

        [Required]
        [StringLength(50)]
        public string AdminUser_Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public bool ExcludeGroup { get; set; }
    }
}
