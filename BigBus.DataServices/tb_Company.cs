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
    
    public partial class tb_Company
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string IATANumber { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string WebsiteURL { get; set; }
        public decimal Discount { get; set; }
        public Nullable<System.Guid> AccountManager_Id { get; set; }
        public string DiscountType { get; set; }
        public decimal DiscountDollar { get; set; }
        public decimal DiscountEuro { get; set; }
        public decimal DiscountPound { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string StateProvince { get; set; }
        public string Country_Id { get; set; }
    
        public virtual tb_User tb_User { get; set; }
    }
}
