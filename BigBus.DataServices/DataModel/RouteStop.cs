namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Route_Stop")]
    public class RouteStop
    {
        public Guid Id { get; set; }

        [Column("Route_Id")]
        public Guid? RouteId { get; set; }

        [Column("Stop_Id")]
        public Guid? StopId { get; set; }

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
