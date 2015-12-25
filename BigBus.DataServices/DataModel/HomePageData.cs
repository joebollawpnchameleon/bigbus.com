namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_HomePageData")]
    public class HomePageData
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime UtcDateCreated { get; set; }

        [Required]
        [StringLength(50)]
        [Column("MicroSite_Id")]
        public string MicroSiteId { get; set; }

        [Required]
        [StringLength(3)]
        [Column("Language_Id")]
        public string LanguageId { get; set; }

        [Column("TopImage_Id")]
        public Guid? TopImageId { get; set; }

        [Column("ExploreImageLeft_Id")]
        public Guid? ExploreImageLeftId { get; set; }

        [Column("ExploreImageMiddle_Id")]
        public Guid? ExploreImageMiddleId { get; set; }

        [Column("ExploreImageRight_Id")]
        public Guid? ExploreImageRightId { get; set; }
    }
}
