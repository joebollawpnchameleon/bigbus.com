//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BigBus.DataServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Language
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Language()
        {
            this.tb_MicroSite_Language = new HashSet<tb_MicroSite_Language>();
            this.tb_NavigationItem_Language = new HashSet<tb_NavigationItem_Language>();
            this.tb_Phrase_Language = new HashSet<tb_Phrase_Language>();
            this.tb_PlaceOfInterest_Language = new HashSet<tb_PlaceOfInterest_Language>();
            this.tb_Route_Language = new HashSet<tb_Route_Language>();
            this.tb_SiteText_Language = new HashSet<tb_SiteText_Language>();
            this.tb_Stop_Language = new HashSet<tb_Stop_Language>();
        }
    
        public string Id { get; set; }
        public string FullName { get; set; }
        public string PreferedFallback_Id { get; set; }
        public string shortcode { get; set; }
        public string LocalName { get; set; }
        public string Iso639Dash1Code { get; set; }
        public string PayPalLanguageCodeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_MicroSite_Language> tb_MicroSite_Language { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_NavigationItem_Language> tb_NavigationItem_Language { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Phrase_Language> tb_Phrase_Language { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_PlaceOfInterest_Language> tb_PlaceOfInterest_Language { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Route_Language> tb_Route_Language { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SiteText_Language> tb_SiteText_Language { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Stop_Language> tb_Stop_Language { get; set; }
    }
}