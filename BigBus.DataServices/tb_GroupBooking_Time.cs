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
    
    public partial class tb_GroupBooking_Time
    {
        public System.Guid Id { get; set; }
        public System.Guid GroupBooking_Id { get; set; }
        public int AvailableHour { get; set; }
        public int AvailableMinute { get; set; }
    
        public virtual tb_GroupBooking tb_GroupBooking { get; set; }
    }
}