namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_PlaceOfInterest_Stop")]
    public class PlaceOfInterestStop
    {
        public Guid Id { get; set; }

        [Column("PlaceOfInterest_Id")]
        public Guid? PlaceOfInterestId { get; set; }

        [Column("Stop_Id")]
        public Guid? StopId { get; set; }

        public virtual PlaceOfInterest PlaceOfInterest { get; set; }

        public virtual Stop Stop { get; set; }
    }
}
