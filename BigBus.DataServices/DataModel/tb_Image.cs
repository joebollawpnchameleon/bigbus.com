namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Image")]
    public partial class Image
    {
        public Guid Id { get; set; }

        [Column(TypeName = "image")]
        public byte[] Data { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public Guid? xImageMetadata_Id { get; set; }

        public Guid? xImageFolder_Id { get; set; }

        [StringLength(200)]
        public string xTags { get; set; }

        public virtual ImageFolder ImageFolder { get; set; }

        public virtual ImageMetaData ImageMetaData { get; set; }
    }
}
