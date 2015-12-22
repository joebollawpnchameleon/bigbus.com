namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AccountManager_MicroSite")]
    public partial class AccountManagerMicroSite
    {
        public Guid Id { get; set; }

        public Guid AccountManager_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Microsite_Id { get; set; }

        public virtual AccountManager AccountManager { get; set; }

        public virtual MicroSite MicroSite { get; set; }
    }
}
