namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_GoogleCode")]
    public partial class GoogleCode
    {
        public Guid Id { get; set; }

        [StringLength(500)]
        public string Code_Function { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateModified { get; set; }

        [Column(TypeName = "ntext")]
        public string Optimisation_Default_Head { get; set; }

        [Column(TypeName = "ntext")]
        public string Optimisation_Default_Footer { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "ntext")]
        public string Test_Page_Header { get; set; }

        [Column(TypeName = "ntext")]
        public string Test_Page_Footer { get; set; }
    }
}
