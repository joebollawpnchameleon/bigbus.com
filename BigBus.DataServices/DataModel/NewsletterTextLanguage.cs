namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_NewsletterText_Language")]
    public class NewsletterTextLanguage
    {
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ident { get; set; }

        [StringLength(100)]
        [Column("Newsletter_Id")]
        public string NewsletterId { get; set; }

        [StringLength(100)]
        [Column("NewsletterText_Id")]
        public string NewsletterTextId { get; set; }

        [Column(TypeName = "ntext")]
        public string LiveText { get; set; }

        [Column(TypeName = "ntext")]
        public string DraftText { get; set; }

        [StringLength(3)]
        [Column("Language_Id")]
        public string LanguageId { get; set; }

        public virtual NewsletterTextLanguage NewsletterTextLanguage1 { get; set; }

        public virtual NewsletterTextLanguage NewsletterTextLanguage2 { get; set; }
    }
}
