namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Stop_Language")]
    public partial class Stop_Language
    {
        public Guid Id { get; set; }

        public Guid? Stop_Id { get; set; }

        [StringLength(3)]
        public string Language_Id { get; set; }

        [Column(TypeName = "ntext")]
        public string GeneralText { get; set; }

        [Column(TypeName = "ntext")]
        public string AdditionalText { get; set; }

        public bool IsLiveVersion { get; set; }

        public virtual Language Language { get; set; }

        public virtual Stop Stop { get; set; }
    }
}
