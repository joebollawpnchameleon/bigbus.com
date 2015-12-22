namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_HomePageData")]
    public partial class HomePageData
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime UtcDateCreated { get; set; }

        [Required]
        [StringLength(50)]
        public string MicroSite_Id { get; set; }

        [Required]
        [StringLength(3)]
        public string Language_Id { get; set; }

        public Guid? TopImage_Id { get; set; }

        public Guid? ExploreImageLeft_Id { get; set; }

        public Guid? ExploreImageMiddle_Id { get; set; }

        public Guid? ExploreImageRight_Id { get; set; }
    }
}
