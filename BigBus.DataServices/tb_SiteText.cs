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
    
    public partial class tb_SiteText
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_SiteText()
        {
            this.tb_SiteText_Language = new HashSet<tb_SiteText_Language>();
        }
    
        public string Id { get; set; }
        public string CleanUpRule { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SiteText_Language> tb_SiteText_Language { get; set; }
    }
}