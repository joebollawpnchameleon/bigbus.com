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
    
    public partial class tb_DownloadMetaData
    {
        public System.Guid Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public long FileSize { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string AltText { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string Download_Id { get; set; }
        public string Tags { get; set; }
        public Nullable<System.Guid> DownloadFolder_Id { get; set; }
    }
}