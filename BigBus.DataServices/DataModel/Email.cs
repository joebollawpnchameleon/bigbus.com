namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Email")]
    public class Email
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string FromAddress { get; set; }

        [StringLength(100)]
        public string ReplyToAddress { get; set; }

        [Column(TypeName = "ntext")]
        public string ToAddresses { get; set; }

        [Column(TypeName = "ntext")]
        public string CCAddresses { get; set; }

        [Column(TypeName = "ntext")]
        public string BCCAddresses { get; set; }

        [StringLength(120)]
        public string Subject { get; set; }

        [Column(TypeName = "ntext")]
        public string HTMLBody { get; set; }

        [Column(TypeName = "ntext")]
        public string TextBody { get; set; }

        public int PriorityLevel { get; set; }

        public bool ReadyToSend { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateFirstAttempted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateSent { get; set; }
    }
}
