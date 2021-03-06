namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AdminSession")]
    public class AdminSession
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        [Column("AdminUser_Id")]
        public string AdminUserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [StringLength(50)]
        public string AdminMode { get; set; }
    }
}
