namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_GroupBooking_Stop")]
    public class GroupBookingStop
    {
        public Guid Id { get; set; }

        [Column("GroupBooking_Id")]
        public Guid GroupBookingId { get; set; }

        [Column("Stop_Id")]
        public Guid StopId { get; set; }

        public virtual GroupBooking GroupBooking { get; set; }

        public virtual Stop Stop { get; set; }
    }
}
