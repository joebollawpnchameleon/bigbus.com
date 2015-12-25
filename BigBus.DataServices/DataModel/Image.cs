namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Image")]
    public class Image
    {
        public Guid Id { get; set; }

        [Column(TypeName = "image")]
        public byte[] Data { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [Column("xImageMetadata_Id")]
        public Guid? ImageMetadataId { get; set; }

        [Column("xImageFolder_Id")]
        public Guid? ImageFolderId { get; set; }

        [StringLength(200)]
        [Column("xTags")]
        public string Tags { get; set; }

        public virtual ImageFolder ImageFolder { get; set; }

        public virtual ImageMetaData ImageMetaData { get; set; }
    }
}
