namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_ImageFolder")]
    public class ImageFolder
    {
        public ImageFolder()
        {
            Image = new HashSet<Image>();
            ImageFolder1 = new HashSet<ImageFolder>();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string FolderName { get; set; }

        [Column("ParentFolder_Id")]
        public Guid? ParentFolderId { get; set; }

        public virtual ICollection<Image> Image { get; set; }

        public virtual ICollection<ImageFolder> ImageFolder1 { get; set; }

        public virtual ImageFolder ImageFolder2 { get; set; }
    }
}
