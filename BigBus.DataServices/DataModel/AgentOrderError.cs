namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AgentOrderError")]
    public class AgentOrderError
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string IpAddress { get; set; }

        [StringLength(1000)]
        public string DeviceAgent { get; set; }

        [StringLength(250)]
        public string DeviceBrowser { get; set; }

        public DateTime DateSubmitted { get; set; }

        [Required]
        [StringLength(50)]
        public string AgentRef { get; set; }

        [StringLength(150)]
        public string AgentEmail { get; set; }

        [StringLength(150)]
        public string CustomerName { get; set; }

        public DateTime OrderDate { get; set; }

        [StringLength(50)]
        public string ApproximateTime { get; set; }

        [Required]
        [StringLength(4000)]
        public string Description { get; set; }
    }
}
