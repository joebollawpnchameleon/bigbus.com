namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_PasswordResetRequest")]
    public class PasswordResetRequest
    {
        public Guid Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UtcDateCreated { get; set; }

        [Column("User_Id")]
        public Guid UserId { get; set; }

        public bool Completed { get; set; }

        [StringLength(50)]
        public string UserType { get; set; }
    }
}
