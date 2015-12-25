namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_SiteText_Language")]
    public class SiteTextLanguage
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("SiteText_Id")]
        public string SiteTextId { get; set; }

        [Required]
        [StringLength(3)]
        [Column("Language_Id")]
        public string LanguageId { get; set; }

        [Column(TypeName = "ntext")]
        public string LiveText { get; set; }

        [Column(TypeName = "ntext")]
        public string DraftText { get; set; }

        public virtual Language Language { get; set; }

        public virtual SiteText SiteText { get; set; }
    }
}
