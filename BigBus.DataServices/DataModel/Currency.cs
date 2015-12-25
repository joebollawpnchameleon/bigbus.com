namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Currency")]
    public class Currency
    {
        public Currency()
        {
            AgentCommission = new HashSet<AgentCommission>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(4)]
        public string ISOCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(5)]
        public string Symbol { get; set; }

        [StringLength(5)]
        public string IsoNumericCode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QrId { get; set; }

        public virtual ICollection<AgentCommission> AgentCommission { get; set; }
    }
}
