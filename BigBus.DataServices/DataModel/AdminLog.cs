namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AdminLog")]
    public class AdminLog
    {
        public Guid Id { get; set; }

        [Column("AdminSession_Id")]
        public Guid? AdminSessionId { get; set; }

        [StringLength(50)]
        [Column("AdminUser_Id")]
        public string AdminUserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [StringLength(50)]
        public string ActionType { get; set; }

        [Column(TypeName = "ntext")]
        public string ActionDetail { get; set; }
    }
}
