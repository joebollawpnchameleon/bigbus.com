namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Ticket_Language")]
    public partial class Ticket_Language
    {
        public Guid Id { get; set; }

        public Guid? Ticket_Id { get; set; }

        [StringLength(3)]
        public string Language_Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public bool IsLiveVersion { get; set; }

        [Column(TypeName = "ntext")]
        public string SalesText { get; set; }

        [StringLength(250)]
        public string CarouselDescription { get; set; }
    }
}
