namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_TicketApi")]
    public partial class TicketApi
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ApiName { get; set; }

        [Required]
        [StringLength(255)]
        public string AssemblyName { get; set; }

        [Required]
        [StringLength(100)]
        public string ClassName { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
