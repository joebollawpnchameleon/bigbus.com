namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_GroupBooking_Stop")]
    public partial class GroupBookingStop
    {
        public Guid Id { get; set; }

        public Guid GroupBooking_Id { get; set; }

        public Guid Stop_Id { get; set; }

        public virtual GroupBooking GroupBooking { get; set; }

        public virtual Stop Stop { get; set; }
    }
}
