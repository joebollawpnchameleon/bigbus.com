namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_GalleryImage")]
    public partial class GalleryImage
    {
        [StringLength(150)]
        public string Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public Guid? ThumbnailImageMetaData_Id { get; set; }

        public Guid? ImageMetaData_Id { get; set; }
    }
}
