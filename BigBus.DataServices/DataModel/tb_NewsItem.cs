namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_NewsItem")]
    public partial class NewsItem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MicroSite_Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Headline { get; set; }

        [Column(TypeName = "ntext")]
        public string Body { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? PublishDate { get; set; }

        public bool IsLive { get; set; }

        public bool IsMainDisplayItem { get; set; }
    }
}
