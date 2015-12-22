namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_GroupBooking_Time")]
    public partial class GroupBookingTime
    {
        public Guid Id { get; set; }

        public Guid GroupBooking_Id { get; set; }

        public int AvailableHour { get; set; }

        public int AvailableMinute { get; set; }

        public virtual GroupBooking GroupBooking { get; set; }
    }
}
