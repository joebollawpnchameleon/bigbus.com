namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Tag")]
    public partial class Tag
    {
        [Key]
        [StringLength(50)]
        public string TagName { get; set; }
    }
}
