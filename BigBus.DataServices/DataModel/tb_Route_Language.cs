namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Route_Language")]
    public partial class Route_Language
    {
        public Guid Id { get; set; }

        public Guid? Route_Id { get; set; }

        [StringLength(3)]
        public string Language_id { get; set; }

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
