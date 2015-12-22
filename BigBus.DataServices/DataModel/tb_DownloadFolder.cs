namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_DownloadFolder")]
    public partial class DownloadFolder
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string FolderName { get; set; }

        public Guid? ParentFolder_Id { get; set; }
    }
}
