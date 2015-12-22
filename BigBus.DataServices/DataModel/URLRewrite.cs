namespace BigBus.DataServices.DataModel
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tb_URLRewrite")]
    public class UrlRewrite
    {
        [Required]
        [StringLength(200)]
        [Column("FriendlyURL")]
        public string FriendlyUrl { get; set; }

        [Key]
        [StringLength(255)]
        public string RewriteTo { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public Guid Id { get; set; }
    }
}
