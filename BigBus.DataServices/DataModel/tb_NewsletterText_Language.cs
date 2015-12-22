namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_NewsletterText_Language")]
    public partial class NewsletterText_Language
    {
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ident { get; set; }

        [StringLength(100)]
        public string Newsletter_Id { get; set; }

        [StringLength(100)]
        public string NewsletterText_Id { get; set; }

        [Column(TypeName = "ntext")]
        public string LiveText { get; set; }

        [Column(TypeName = "ntext")]
        public string DraftText { get; set; }

        [StringLength(3)]
        public string Language_Id { get; set; }

        public virtual NewsletterText_Language NewsletterText_Language1 { get; set; }

        public virtual NewsletterText_Language NewsletterText_Language2 { get; set; }
    }
}
