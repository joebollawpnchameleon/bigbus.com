namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_NavigationItem_Language")]
    public class NavigationItemLanguage
    {
        public Guid Id { get; set; }

        [Column("NavigationItem_Id")]
        public Guid? NavigationItemId { get; set; }

        [StringLength(3)]
        [Column("Language_Id")]
        public string LanguageId { get; set; }

        [StringLength(50)]
        public string Text { get; set; }

        public virtual Language Language { get; set; }

        public virtual NavigationItem NavigationItem { get; set; }
    }
}
