namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_PasswordResetRequest")]
    public partial class PasswordResetRequest
    {
        public Guid Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UtcDateCreated { get; set; }

        public Guid User_Id { get; set; }

        public bool Completed { get; set; }

        [StringLength(50)]
        public string UserType { get; set; }
    }
}
