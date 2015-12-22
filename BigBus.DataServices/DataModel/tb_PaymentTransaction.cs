namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_PaymentTransaction")]
    public partial class PaymentTransaction
    {
        public Guid Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [StringLength(150)]
        public string GatewayReference { get; set; }

        [StringLength(50)]
        public string GatewayName { get; set; }

        [StringLength(150)]
        public string GatewaySessionId { get; set; }

        [StringLength(500)]
        public string AquirerResponse { get; set; }

        [StringLength(150)]
        public string CVCResponse { get; set; }

        [StringLength(150)]
        public string AVSResponse { get; set; }

        [StringLength(500)]
        public string ErrorCode { get; set; }

        [StringLength(500)]
        public string ErrorMessage { get; set; }

        public bool FailedValidation { get; set; }

        public byte[] EncryptedDetail { get; set; }

        [StringLength(500)]
        public string GatewayCookie { get; set; }

        [StringLength(2000)]
        public string IssuerUrl { get; set; }

        [StringLength(1000)]
        public string GatewayEchoData { get; set; }

        [StringLength(1000)]
        public string IssuerPaRequest { get; set; }

        [StringLength(50)]
        public string TransactionType { get; set; }

        [StringLength(36)]
        public string CardType { get; set; }

        public decimal? Amount { get; set; }
    }
}
