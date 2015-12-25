namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_PasswordAdminResetRequest")]
    public class PasswordAdminResetRequest
    {
        public Guid Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UtcDateCreated { get; set; }

        [Required]
        [StringLength(500)]
        [Column("User_Id")]
        public string UserId { get; set; }

        public bool Completed { get; set; }
    }
}
