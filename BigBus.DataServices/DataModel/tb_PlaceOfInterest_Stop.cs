namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_PlaceOfInterest_Stop")]
    public partial class PlaceOfInterest_Stop
    {
        public Guid Id { get; set; }

        public Guid? PlaceOfInterest_Id { get; set; }

        public Guid? Stop_Id { get; set; }

        public virtual PlaceOfInterest PlaceOfInterest { get; set; }

        public virtual Stop Stop { get; set; }
    }
}
