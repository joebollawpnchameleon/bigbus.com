namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_DownloadFolder")]
    public class DownloadFolder
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string FolderName { get; set; }

        [Column("ParentFolder_Id")]
        public Guid? ParentFolderId { get; set; }
    }
}
