namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_GoogleCode")]
    public class GoogleCode
    {
        public Guid Id { get; set; }

        [StringLength(500)]
        [Column("Code_Function")]
        public string CodeFunction { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateModified { get; set; }

        [Column("Optimisation_Default_Head", TypeName = "ntext")]
        public string OptimisationDefaultHead { get; set; }

        [Column("Optimisation_Default_Footer", TypeName = "ntext")]
        public string OptimisationDefaultFooter { get; set; }

        public bool IsActive { get; set; }

        [Column("Test_Page_Header", TypeName = "ntext")]
        public string TestPageHeader { get; set; }

        [Column("Test_Page_Footer", TypeName = "ntext")]
        public string TestPageFooter { get; set; }
    }
}
