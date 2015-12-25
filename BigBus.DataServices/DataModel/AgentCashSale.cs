namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AgentCashSale")]
    public class AgentCashSale
    {
        public Guid Id { get; set; }

        [Column("Agent_Id")]
        public Guid AgentId { get; set; }

        public int Pin { get; set; }

        public decimal CreditLimit { get; set; }

        public decimal BalanceAlertLimit { get; set; }

        public decimal CurrentBalance { get; set; }

        public decimal CurrentTotal { get; set; }
    }
}
