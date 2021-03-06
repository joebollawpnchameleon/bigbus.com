namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_TourAnimationContent")]
    public partial class TourAnimationContent
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(150)]
        [Column("Content_Id")]
        public string ContentId { get; set; }

        [Required]
        [StringLength(250)]
        public string Header { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Content { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Image_Id")]
        public string ImageId { get; set; }

        public int Position { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public int AnimationType { get; set; }

        [Column("ImageMetaData_Id")]
        public Guid? ImageMetaDataId { get; set; }
    }
}
