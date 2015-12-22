namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Phrase_Language")]
    public partial class Phrase_Language
    {
        public Guid Id { get; set; }

        [StringLength(250)]
        public string Phrase_Id { get; set; }

        [StringLength(3)]
        public string Language_Id { get; set; }

        [StringLength(500)]
        public string Translation { get; set; }

        public virtual Language Language { get; set; }

        public virtual Phrase Phrase { get; set; }
    }
}
