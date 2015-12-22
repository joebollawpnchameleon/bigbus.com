namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_MicroSite_Language")]
    public partial class MicroSite_Language
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string MicroSite_Id { get; set; }

        [StringLength(3)]
        public string Language_Id { get; set; }

        public virtual Language Language { get; set; }

        public virtual MicroSite MicroSite { get; set; }
    }
}
