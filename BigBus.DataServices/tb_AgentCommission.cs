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
    
    public partial class tb_AgentCommission
    {
        public System.Guid Id { get; set; }
        public System.Guid Agent_Id { get; set; }
        public System.Guid Ticket_Id { get; set; }
        public System.Guid Currency_Id { get; set; }
        public string TicketType { get; set; }
        public decimal Commission { get; set; }
        public bool Enabled { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool IsCashSale { get; set; }
    
        public virtual tb_User tb_User { get; set; }
        public virtual tb_Currency tb_Currency { get; set; }
        public virtual tb_Ticket tb_Ticket { get; set; }
    }
}