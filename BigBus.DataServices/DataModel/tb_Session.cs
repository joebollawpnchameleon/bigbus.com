namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Session")]
    public partial class Session
    {
        public Guid Id { get; set; }

        public Guid? PaymentTransaction_Id { get; set; }

        public Guid? Basket_Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public Guid? User_Id { get; set; }

        public Guid? AgentManagerId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateToExpire { get; set; }

        [StringLength(50)]
        public string Currency_Id { get; set; }

        [StringLength(100)]
        public string PayPal_Order_Id { get; set; }

        [StringLength(100)]
        public string PayPal_Token { get; set; }

        [StringLength(100)]
        public string PayPal_Payer_Id { get; set; }

        [StringLength(100)]
        public string Centinel_OrderId { get; set; }

        [StringLength(100)]
        public string Centinel_TransactionId { get; set; }

        [StringLength(100)]
        public string Centinel_Enrolled { get; set; }

        [StringLength(100)]
        public string Centinel_ErrorNo { get; set; }

        [Column(TypeName = "ntext")]
        public string Centinel_ErrorDesc { get; set; }

        [StringLength(100)]
        public string Centinel_ECI { get; set; }

        [StringLength(500)]
        public string Centinel_ACSURL { get; set; }

        [Column(TypeName = "ntext")]
        public string Centinel_PAYLOAD { get; set; }

        [StringLength(100)]
        public string Centinel_PIType { get; set; }

        [StringLength(100)]
        public string Centinel_TransactionType { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateModified { get; set; }

        [Column(TypeName = "ntext")]
        public string Message { get; set; }

        [StringLength(100)]
        public string Centinel_PAResStatus { get; set; }

        [StringLength(100)]
        public string Centinel_SignatureVerification { get; set; }

        [StringLength(1000)]
        public string Centinel_TermURL { get; set; }

        [StringLength(100)]
        public string Centinel_XID { get; set; }

        [StringLength(100)]
        public string Centinel_CAVV { get; set; }

        [StringLength(50)]
        public string Centinel_DIG { get; set; }

        public bool IsMobileAppSession { get; set; }

        public bool InCheckoutProccess { get; set; }

        public bool InOrderCreationProcess { get; set; }

        public bool AgentUseCustomersAddress { get; set; }

        public Guid? AgentFakeUser_Id { get; set; }

        public bool AgentIsTradeTicketSale { get; set; }

        [StringLength(50)]
        public string AgentNameToPrintOnTicket { get; set; }

        public bool InPaypalCheckoutProcess { get; set; }

        public bool BookingTimesNeedsConfirming { get; set; }
    }
}
