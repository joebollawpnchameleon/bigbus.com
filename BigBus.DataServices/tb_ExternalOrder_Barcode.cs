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
    
    public partial class tb_ExternalOrder_Barcode
    {
        public System.Guid Id { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string Barcode { get; set; }
        public string CustomerTypeName { get; set; }
        public string PackageId { get; set; }
        public string EventId { get; set; }
        public System.DateTime EventDate { get; set; }
        public string EventTime { get; set; }
        public string VendorId { get; set; }
        public string ExternalOrderId { get; set; }
        public int CustomerTypeId { get; set; }
    }
}
