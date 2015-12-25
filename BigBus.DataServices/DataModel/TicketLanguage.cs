namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Ticket_Language")]
    public class TicketLanguage
    {
        public Guid Id { get; set; }

        [Column("Ticket_Id")]
        public Guid? TicketId { get; set; }

        [StringLength(3)]
        [Column("Language_Id")]
        public string LanguageId { get; set; }

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
