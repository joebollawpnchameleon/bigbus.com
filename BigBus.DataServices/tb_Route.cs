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
    
    public partial class tb_Route
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Route()
        {
            this.tb_Route_Language = new HashSet<tb_Route_Language>();
            this.tb_Route_Stop = new HashSet<tb_Route_Stop>();
        }
    
        public System.Guid Id { get; set; }
        public string MicroSite_Id { get; set; }
        public string Admin_Name { get; set; }
        public Nullable<int> Position { get; set; }
        public Nullable<System.Guid> Ticket_Id { get; set; }
        public Nullable<System.Guid> ImageMetaData_Id { get; set; }
    
        public virtual tb_MicroSite tb_MicroSite { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Route_Language> tb_Route_Language { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Route_Stop> tb_Route_Stop { get; set; }
        public virtual tb_Ticket tb_Ticket { get; set; }
    }
}