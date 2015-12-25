namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_HTMLMetaTag")]
    public class HtmlMetaTag
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string PageType { get; set; }

        [StringLength(100)]
        public string PageIdentifier { get; set; }

        [StringLength(100)]
        public string MetaTag { get; set; }

        [StringLength(255)]
        public string Value { get; set; }
    }
}
