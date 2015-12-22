namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_SiteText")]
    public partial class SiteText
    {
        public SiteText()
        {
            SiteText_Language = new HashSet<SiteText_Language>();
        }

        [StringLength(100)]
        public string Id { get; set; }

        [StringLength(100)]
        public string CleanUpRule { get; set; }

        public virtual ICollection<SiteText_Language> SiteText_Language { get; set; }
    }
}
