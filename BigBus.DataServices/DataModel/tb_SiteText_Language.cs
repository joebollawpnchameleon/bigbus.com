namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_SiteText_Language")]
    public partial class SiteText_Language
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string SiteText_Id { get; set; }

        [Required]
        [StringLength(3)]
        public string Language_Id { get; set; }

        [Column(TypeName = "ntext")]
        public string LiveText { get; set; }

        [Column(TypeName = "ntext")]
        public string DraftText { get; set; }

        public virtual Language Language { get; set; }

        public virtual SiteText SiteText { get; set; }
    }
}
