namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Language")]
    public partial class Language
    {
        public Language()
        {
            MicroSite_Language = new HashSet<MicroSite_Language>();
            NavigationItem_Language = new HashSet<NavigationItem_Language>();
            Phrase_Language = new HashSet<Phrase_Language>();
            PlaceOfInterest_Language = new HashSet<PlaceOfInterest_Language>();
            Route_Language = new HashSet<Route_Language>();
            SiteText_Language = new HashSet<SiteText_Language>();
            Stop_Language = new HashSet<Stop_Language>();
        }

        [StringLength(3)]
        public string Id { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(3)]
        public string PreferedFallback_Id { get; set; }

        [StringLength(10)]
        public string shortcode { get; set; }

        [StringLength(500)]
        public string LocalName { get; set; }

        [StringLength(10)]
        public string Iso639Dash1Code { get; set; }

        [StringLength(8)]
        public string PayPalLanguageCodeId { get; set; }

        public virtual ICollection<MicroSite_Language> MicroSite_Language { get; set; }

        public virtual ICollection<NavigationItem_Language> NavigationItem_Language { get; set; }

        public virtual ICollection<Phrase_Language> Phrase_Language { get; set; }

        public virtual ICollection<PlaceOfInterest_Language> PlaceOfInterest_Language { get; set; }

        public virtual ICollection<Route_Language> Route_Language { get; set; }

        public virtual ICollection<SiteText_Language> SiteText_Language { get; set; }

        public virtual ICollection<Stop_Language> Stop_Language { get; set; }
    }
}
