namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_SiteText")]
    public class SiteText
    {
        public SiteText()
        {
            SiteTextLanguage = new HashSet<SiteTextLanguage>();
        }

        [StringLength(100)]
        public string Id { get; set; }

        [StringLength(100)]
        public string CleanUpRule { get; set; }

        public virtual ICollection<SiteTextLanguage> SiteTextLanguage { get; set; }
    }
}
