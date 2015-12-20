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
    
    public partial class tb_Promotion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Promotion()
        {
            this.tb_Basket_Promotion = new HashSet<tb_Basket_Promotion>();
        }
    
        public string Id { get; set; }
        public Nullable<System.Guid> OfferTicket_Id { get; set; }
        public Nullable<System.Guid> DiscountedTicket_Id { get; set; }
        public Nullable<decimal> PercentageValue { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public string PromotionType { get; set; }
        public string MicroSite_Id { get; set; }
        public string OfferTicket_Type { get; set; }
        public Nullable<int> OfferTicketPurchaseAmount { get; set; }
        public string DiscountedTicket_Type { get; set; }
        public Nullable<int> DiscountedTicketReceiveAmount { get; set; }
        public Nullable<decimal> DollarDiscountValue { get; set; }
        public Nullable<decimal> EuroDiscountValue { get; set; }
        public Nullable<decimal> PoundDiscountValue { get; set; }
        public string OfferTicket_Message { get; set; }
        public string TicketDateType { get; set; }
        public Nullable<decimal> AEDDiscountValue { get; set; }
        public Nullable<decimal> HKDDiscountValue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Basket_Promotion> tb_Basket_Promotion { get; set; }
    }
}