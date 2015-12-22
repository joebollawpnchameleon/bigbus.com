namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_DownloadMetaData")]
    public partial class DownloadMetaData
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public long FileSize { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string AltText { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [StringLength(100)]
        public string Download_Id { get; set; }

        [StringLength(200)]
        public string Tags { get; set; }

        public Guid? DownloadFolder_Id { get; set; }
    }
}
