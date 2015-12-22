namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_PlaceOfInterest_Language")]
    public partial class PlaceOfInterest_Language
    {
        public Guid Id { get; set; }

        public Guid? PlaceOfInterest_Id { get; set; }

        [StringLength(3)]
        public string Language_Id { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public bool IsLiveVersion { get; set; }

        public virtual Language Language { get; set; }

        public virtual PlaceOfInterest PlaceOfInterest { get; set; }
    }
}
