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
    
    public partial class tb_Currency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Currency()
        {
            this.tb_AgentCommission = new HashSet<tb_AgentCommission>();
        }
    
        public System.Guid Id { get; set; }
        public string ISOCode { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string IsoNumericCode { get; set; }
        public int QrId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_AgentCommission> tb_AgentCommission { get; set; }
    }
}
