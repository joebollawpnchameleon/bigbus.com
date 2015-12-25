namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_ThingsToDoItem")]
    public class ThingsToDoItem
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? UtcDateCreated { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(100)]
        [Column("Microsite_Id")]
        public string MicrositeId { get; set; }

        [Column("ImageMetaData_Id")]
        public Guid? ImageMetaDataId { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(500)]
        public string ReadMoreText { get; set; }
    }
}
