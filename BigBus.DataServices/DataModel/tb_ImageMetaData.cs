namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_ImageMetaData")]
    public partial class ImageMetaData
    {
        public ImageMetaData()
        {
            Image = new HashSet<Image>();
        }

        public Guid Id { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        [StringLength(500)]
        public string AltText { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public Guid? Image_Id { get; set; }

        [StringLength(200)]
        public string Tags { get; set; }

        public Guid? ImageFolder_Id { get; set; }

        public virtual ICollection<Image> Image { get; set; }
    }
}
