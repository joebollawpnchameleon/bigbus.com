namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_NewsletterStaticSection")]
    public partial class NewsletterStaticSection
    {
        public Guid Id { get; set; }

        [Column(TypeName = "ntext")]
        public string Header { get; set; }

        [Column(TypeName = "ntext")]
        public string Footer { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Section_Begin { get; set; }

        [Column(TypeName = "ntext")]
        public string MainHeading_Begin { get; set; }

        [Column(TypeName = "ntext")]
        public string MainHeading_End { get; set; }

        [Column(TypeName = "ntext")]
        public string InThisIssue_Begin { get; set; }

        [Column(TypeName = "ntext")]
        public string InThisIssue_Separator { get; set; }

        [Column(TypeName = "ntext")]
        public string InThisIssue_End { get; set; }

        [Column(TypeName = "ntext")]
        public string Section_End { get; set; }

        [Column(TypeName = "ntext")]
        public string SampleTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string SampleContent { get; set; }

        [Column(TypeName = "ntext")]
        public string SampleInThisIssue { get; set; }

        [Column(TypeName = "ntext")]
        public string SampleInThisIssueList { get; set; }
    }
}
