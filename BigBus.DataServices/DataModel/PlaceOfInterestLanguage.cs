namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_PlaceOfInterest_Language")]
    public class PlaceOfInterestLanguage
    {
        public Guid Id { get; set; }

        [Column("PlaceOfInterest_Id")]
        public Guid? PlaceOfInterestId { get; set; }

        [StringLength(3)]
        [Column("Language_Id")]
        public string LanguageId { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public bool IsLiveVersion { get; set; }

        public virtual Language Language { get; set; }

        public virtual PlaceOfInterest PlaceOfInterest { get; set; }
    }
}
