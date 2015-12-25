namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Transaction_Address")]
    public partial class TransactionAddress
    {
        public Guid Id { get; set; }

        public int? OrderNumber { get; set; }

        [StringLength(50)]
        [Column("Order_Id")]
        public string OrderId { get; set; }

        [StringLength(100)]
        [Column("PayflowUtiliy_OrderId")]
        public string PayflowUtiliyOrderId { get; set; }

        [StringLength(100)]
        [Column("BillTo_FirstName")]
        public string BillToFirstName { get; set; }

        [StringLength(100)]
        [Column("BillTo_LastName")]
        public string BillToLastName { get; set; }

        [StringLength(500)]
        [Column("BillTo_Street")]
        public string BillToStreet { get; set; }

        [StringLength(255)]
        [Column("BillTo_Address1")]
        public string BillToAddress1 { get; set; }

        [StringLength(255)]
        [Column("BillTo_Address2")]
        public string BillToAddress2 { get; set; }

        [StringLength(100)]
        [Column("BillTo_City")]
        public string BillToCity { get; set; }

        [StringLength(100)]
        [Column("BillTo_Zip")]
        public string BillToZip { get; set; }

        [StringLength(100)]
        [Column("BillTo_PostCode")]
        public string BillToPostCode { get; set; }

        [StringLength(100)]
        [Column("BillTo_State")]
        public string BillToState { get; set; }

        [StringLength(100)]
        [Column("BillTo_Country")]
        public string BillToCountry { get; set; }

        [StringLength(100)]
        [Column("ShipTo_FirstName")]
        public string ShipToFirstName { get; set; }

        [StringLength(100)]
        [Column("ShipTo_LastName")]
        public string ShipToLastName { get; set; }

        [StringLength(500)]
        [Column("ShipTo_Street")]
        public string ShipToStreet { get; set; }

        [StringLength(255)]
        [Column("ShipTo_Address1")]
        public string ShipToAddress1 { get; set; }

        [StringLength(255)]
        [Column("ShipTo_Address2")]
        public string ShipToAddress2 { get; set; }

        [StringLength(100)]
        [Column("ShipTo_City")]
        public string ShipToCity { get; set; }

        [StringLength(100)]
        [Column("ShipTo_Zip")]
        public string ShipToZip { get; set; }

        [StringLength(100)]
        [Column("ShipTo_State")]
        public string ShipToState { get; set; }

        [StringLength(100)]
        [Column("ShipTo_PostCode")]
        public string ShipToPostCode { get; set; }

        [StringLength(100)]
        [Column("ShipTo_Country")]
        public string ShipToCountry { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(100)]
        [Column("Session_Id")]
        public string SessionId { get; set; }

        [StringLength(500)]
        public string Email { get; set; }
    }
}
