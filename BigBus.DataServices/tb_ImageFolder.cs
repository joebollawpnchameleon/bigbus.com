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
    
    public partial class tb_ImageFolder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_ImageFolder()
        {
            this.tb_Image = new HashSet<tb_Image>();
            this.tb_ImageFolder1 = new HashSet<tb_ImageFolder>();
        }
    
        public System.Guid Id { get; set; }
        public string FolderName { get; set; }
        public Nullable<System.Guid> ParentFolder_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Image> tb_Image { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ImageFolder> tb_ImageFolder1 { get; set; }
        public virtual tb_ImageFolder tb_ImageFolder2 { get; set; }
    }
}
