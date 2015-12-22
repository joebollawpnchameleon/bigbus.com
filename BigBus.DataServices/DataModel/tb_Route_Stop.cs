namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Route_Stop")]
    public partial class Route_Stop
    {
        public Guid Id { get; set; }

        public Guid? Route_Id { get; set; }

        public Guid? Stop_Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Position { get; set; }

        [StringLength(50)]
        public string FirstBus { get; set; }

        public bool InUse { get; set; }

        public virtual Route Route { get; set; }

        public virtual Stop Stop { get; set; }
    }
}
