namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_NavigationItem_Language")]
    public partial class NavigationItem_Language
    {
        public Guid Id { get; set; }

        public Guid? NavigationItem_Id { get; set; }

        [StringLength(3)]
        public string Language_Id { get; set; }

        [StringLength(50)]
        public string Text { get; set; }

        public virtual Language Language { get; set; }

        public virtual NavigationItem NavigationItem { get; set; }
    }
}
