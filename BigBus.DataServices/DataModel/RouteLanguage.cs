namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Route_Language")]
    public class RouteLanguage
    {
        public Guid Id { get; set; }

        [Column("Route_Id")]
        public Guid? RouteId { get; set; }

        [StringLength(3)]
        [Column("Language_id")]
        public string Languageid { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string Summary { get; set; }

        public virtual Language Language { get; set; }

        public virtual Route Route { get; set; }
    }
}
