namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_NavigationItem")]
    public partial class NavigationItem
    {
        public NavigationItem()
        {
            NavigationItem_Language = new HashSet<NavigationItem_Language>();
        }

        public Guid Id { get; set; }

        public Guid? Navigation_Id { get; set; }

        public int? Position { get; set; }

        [StringLength(255)]
        public string ServerURL { get; set; }

        public Guid? Parent_Id { get; set; }

        [StringLength(255)]
        public string URL { get; set; }

        public virtual Navigation Navigation { get; set; }

        public virtual ICollection<NavigationItem_Language> NavigationItem_Language { get; set; }
    }
}
