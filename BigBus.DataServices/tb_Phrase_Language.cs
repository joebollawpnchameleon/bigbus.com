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
    
    public partial class tb_Phrase_Language
    {
        public System.Guid Id { get; set; }
        public string Phrase_Id { get; set; }
        public string Language_Id { get; set; }
        public string Translation { get; set; }
    
        public virtual tb_Language tb_Language { get; set; }
        public virtual tb_Phrase tb_Phrase { get; set; }
    }
}
