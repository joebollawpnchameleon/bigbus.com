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
    
    public partial class tb_BasketLine
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> Basket_Id { get; set; }
        public Nullable<System.Guid> Ticket_Id { get; set; }
        public Nullable<bool> FixedDateTicket { get; set; }
        public Nullable<System.DateTime> TicketDate { get; set; }
        public string TicketType { get; set; }
        public Nullable<int> TicketQuantity { get; set; }
        public string Promotion_Id { get; set; }
        public System.DateTime DateAdded { get; set; }
        public string DepartureTimeHour { get; set; }
        public string DepartureTimeMinute { get; set; }
        public string DeparturePoint { get; set; }
        public bool IsPromotionTicket { get; set; }
        public bool PromotionTicketRemoved { get; set; }
        public Nullable<System.DateTime> TicketAttractionDate { get; set; }
        public string TicketAttractionTimeHour { get; set; }
        public string TicketAttractionTimeMin { get; set; }
        public string AttractionTimeSection { get; set; }
    }
}