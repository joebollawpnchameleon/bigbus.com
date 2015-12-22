namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_ContactData")]
    public partial class ContactData
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string MicroSite_Id { get; set; }

        [StringLength(50)]
        public string Page { get; set; }

        [StringLength(500)]
        public string Email { get; set; }
    }
}
