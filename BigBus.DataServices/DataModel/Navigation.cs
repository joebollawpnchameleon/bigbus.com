namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Navigation")]
    public class Navigation
    {
        public Navigation()
        {
            NavigationItem = new HashSet<NavigationItem>();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        [Column("MicroSite_Id")]
        public string MicroSiteId { get; set; }

        [StringLength(50)]
        public string Section { get; set; }

        public virtual MicroSite MicroSite { get; set; }

        public virtual ICollection<NavigationItem> NavigationItem { get; set; }
    }
}
