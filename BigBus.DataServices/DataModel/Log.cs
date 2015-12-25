namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Log")]
    public class Log
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Level { get; set; }

        [StringLength(4095)]
        public string Message { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedOn { get; set; }

        [StringLength(36)]
        public string Logger { get; set; }
    }
}
