namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_CustomPage_Language")]
    public partial class CustomPageLanguage
    {
        public Guid Id { get; set; }

        public Guid CustomPage_Id { get; set; }

        [Required]
        [StringLength(3)]
        public string Language_Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Body { get; set; }

        public bool IsLive { get; set; }

        [Column(TypeName = "ntext")]
        public string SideBarText { get; set; }

        [Column(TypeName = "ntext")]
        public string Introduction { get; set; }
    }
}
