namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Newsletter")]
    public partial class Newsletter
    {
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ident { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateLastUpdated { get; set; }

        [StringLength(500)]
        public string Subject { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateSentToCustomer { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateSentToAgent { get; set; }

        public bool? ReadyToSend { get; set; }
    }
}
