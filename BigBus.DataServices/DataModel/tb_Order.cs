namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Order")]
    public partial class Order
    {
        public Order()
        {
            Orderline = new HashSet<Orderline>();
        }

        public Guid Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public Guid? User_Id { get; set; }

        [StringLength(500)]
        public string eMailAddress { get; set; }

        public Guid? Currency_Id { get; set; }

        public decimal? Total { get; set; }

        public bool? OpenForPrinting { get; set; }

        [StringLength(50)]
        public string PaymentMethod { get; set; }

        [StringLength(200)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string LeadTravelerName { get; set; }

        public Guid? Company_Id { get; set; }

        public decimal? AgentDiscount { get; set; }

        public int? TotalQuantity { get; set; }

        [StringLength(4)]
        public string CCLast4Digits { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderNumber { get; set; }

        [Required]
        [StringLength(3)]
        public string Language_Id { get; set; }

        [StringLength(100)]
        public string GiftTravelerName { get; set; }

        public bool NotificationEmailSent { get; set; }

        public bool ShowGoogleCode { get; set; }

        public int? NumbViewPDF { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DatePDFLastViewed { get; set; }

        [StringLength(100)]
        public string Centinel_OrderId { get; set; }

        [StringLength(100)]
        public string Centinel_TransactionId { get; set; }

        [StringLength(100)]
        public string Centinel_Enrolled { get; set; }

        [StringLength(100)]
        public string Centinel_ErrorNo { get; set; }

        [StringLength(1000)]
        public string Centinel_ErrorDesc { get; set; }

        [StringLength(100)]
        public string Centinel_ECI { get; set; }

        [StringLength(1000)]
        public string Centinel_ACSURL { get; set; }

        [StringLength(1000)]
        public string Centinel_PAYLOAD { get; set; }

        [StringLength(100)]
        public string Centinel_PIType { get; set; }

        [StringLength(100)]
        public string Centinel_TransactionType { get; set; }

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

        [StringLength(1000)]
        public string Message { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateModified { get; set; }

        [StringLength(50)]
        public string AgentRef { get; set; }

        [StringLength(50)]
        public string ClientIp { get; set; }

        public Guid? PaymentTransaction_Id { get; set; }

        [StringLength(11)]
        public string AuthCodeNumber { get; set; }

        public bool OrderConfirmationViewed { get; set; }

        public bool SentQrCodeToMobile { get; set; }

        public string QrCodeUniqueHash { get; set; }

        public bool IsMobileAppOrder { get; set; }

        public Guid? Basket_Id { get; set; }

        public Guid? Session_Id { get; set; }

        [StringLength(50)]
        public string WorldPayMerchantId { get; set; }

        [StringLength(50)]
        public string GatewayReference { get; set; }

        [StringLength(150)]
        public string NameOnCard { get; set; }

        [StringLength(150)]
        public string PayPal_Token { get; set; }

        [StringLength(150)]
        public string PayPal_Order_Id { get; set; }

        [StringLength(150)]
        public string PayPal_Payer_Id { get; set; }

        [StringLength(1500)]
        public string EcrBookingBarCode { get; set; }

        [StringLength(1500)]
        public string EcrBookingShortReference { get; set; }

        [StringLength(1500)]
        public string EcrSupplierConfirmationNumber { get; set; }

        [StringLength(500)]
        public string ExternalBarcode { get; set; }

        [StringLength(100)]
        public string ExternalOrderId { get; set; }

        public virtual ICollection<Orderline> Orderline { get; set; }
    }
}
