namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Language")]
    public class Language
    {
        public Language()
        {
            MicroSiteLanguage = new HashSet<MicroSiteLanguage>();
            NavigationItemLanguage = new HashSet<NavigationItemLanguage>();
            PhraseLanguage = new HashSet<PhraseLanguage>();
            PlaceOfInterestLanguage = new HashSet<PlaceOfInterestLanguage>();
            RouteLanguage = new HashSet<RouteLanguage>();
            SiteTextLanguage = new HashSet<SiteTextLanguage>();
            StopLanguage = new HashSet<StopLanguage>();
        }

        [StringLength(3)]
        public string Id { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(3)]
        [Column("PreferedFallback_Id")]
        public string PreferedFallbackId { get; set; }

        [StringLength(10)]
        [Column("shortcode")]
        public string ShortCode { get; set; }

        [StringLength(500)]
        public string LocalName { get; set; }

        [StringLength(10)]
        public string Iso639Dash1Code { get; set; }

        [StringLength(8)]
        public string PayPalLanguageCodeId { get; set; }

        [Column("MicroSite_Language")]
        public virtual ICollection<MicroSiteLanguage> MicroSiteLanguage { get; set; }

        [Column("NavigationItem_Language")]
        public virtual ICollection<NavigationItemLanguage> NavigationItemLanguage { get; set; }

        [Column("Phrase_Language")]
        public virtual ICollection<PhraseLanguage> PhraseLanguage { get; set; }

        [Column("PlaceOfInterest_Language")]
        public virtual ICollection<PlaceOfInterestLanguage> PlaceOfInterestLanguage { get; set; }

        public virtual ICollection<RouteLanguage> RouteLanguage { get; set; }

        public virtual ICollection<SiteTextLanguage> SiteTextLanguage { get; set; }

        public virtual ICollection<StopLanguage> StopLanguage { get; set; }
    }
}
