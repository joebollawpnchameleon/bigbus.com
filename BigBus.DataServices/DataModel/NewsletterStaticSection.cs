namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_NewsletterStaticSection")]
    public class NewsletterStaticSection
    {
        public Guid Id { get; set; }

        [Column(TypeName = "ntext")]
        public string Header { get; set; }

        [Column(TypeName = "ntext")]
        public string Footer { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [Column("Section_Begin", TypeName = "ntext")]
        public string SectionBegin { get; set; }

        [Column("MainHeading_Begin", TypeName = "ntext")]
        public string MainHeadingBegin { get; set; }

        [Column("MainHeading_End", TypeName = "ntext")]
        public string MainHeadingEnd { get; set; }

        [Column("InThisIssue_Begin", TypeName = "ntext")]
        public string InThisIssueBegin { get; set; }

        [Column("InThisIssue_Separator", TypeName = "ntext")]
        public string InThisIssueSeparator { get; set; }

        [Column("InThisIssue_End", TypeName = "ntext")]
        public string InThisIssueEnd { get; set; }

        [Column("Section_End", TypeName = "ntext")]
        public string SectionEnd { get; set; }

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
