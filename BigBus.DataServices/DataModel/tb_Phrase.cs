namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Phrase")]
    public partial class Phrase
    {
        public Phrase()
        {
            Phrase_Language = new HashSet<Phrase_Language>();
        }

        [StringLength(250)]
        public string Id { get; set; }

        public virtual ICollection<Phrase_Language> Phrase_Language { get; set; }
    }
}
