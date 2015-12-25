namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Phrase")]
    public class Phrase
    {
        public Phrase()
        {
            PhraseLanguage = new HashSet<PhraseLanguage>();
        }

        [StringLength(250)]
        public string Id { get; set; }

        public virtual ICollection<PhraseLanguage> PhraseLanguage { get; set; }
    }
}
