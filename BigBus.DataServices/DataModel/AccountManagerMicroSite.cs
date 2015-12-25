namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AccountManager_MicroSite")]
    public class AccountManagerMicroSite
    {
        public Guid Id { get; set; }

        [Column("AccountManager_Id")]
        public Guid AccountManagerId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Microsite_Id")]
        public string MicrositeId { get; set; }

        public virtual AccountManager AccountManager { get; set; }

        public virtual MicroSite MicroSite { get; set; }
    }
}
