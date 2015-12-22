namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AgentCashSale")]
    public partial class AgentCashSale
    {
        public Guid Id { get; set; }

        public Guid Agent_Id { get; set; }

        public int Pin { get; set; }

        public decimal CreditLimit { get; set; }

        public decimal BalanceAlertLimit { get; set; }

        public decimal CurrentBalance { get; set; }

        public decimal CurrentTotal { get; set; }
    }
}
