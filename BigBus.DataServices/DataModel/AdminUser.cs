namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AdminUser")]
    public class AdminUser
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public string PasswordHash { get; set; }

        public int PasswordVersion { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public bool Enabled { get; set; }

        [StringLength(50)]
        [Column("CreatedBy_Id")]
        public string CreatedById { get; set; }

        [StringLength(50)]
        [Column("EnabledBy_Id")]
        public string EnabledById { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }
    }
}
