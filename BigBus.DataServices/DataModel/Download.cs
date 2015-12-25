namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Download")]
    public class Download
    {
        [StringLength(100)]
        public string Id { get; set; }

        [Column(TypeName = "image")]
        public byte[] Data { get; set; }

        [StringLength(50)]
        public string Type { get; set; }
    }
}
