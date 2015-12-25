namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_NewsletterComposite")]
    public class NewsletterComposite
    {
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ident { get; set; }

        [Column("Newsletter_Id")]
        public Guid? NewsletterId { get; set; }

        [Column(TypeName = "ntext")]
        public string Header { get; set; }

        [Column(TypeName = "ntext")]
        public string Footer { get; set; }

        [Column(TypeName = "ntext")]
        public string Body { get; set; }

        [Column(TypeName = "ntext")]
        public string Composite { get; set; }
    }
}
