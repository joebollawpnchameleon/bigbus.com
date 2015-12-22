namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Transaction_AddressPaypal")]
    public partial class Transaction_AddressPaypal
    {
        public Guid Id { get; set; }

        public int? OrderNumber { get; set; }

        [StringLength(50)]
        public string Order_Id { get; set; }

        [StringLength(100)]
        public string PayflowUtiliy_OrderId { get; set; }

        [StringLength(100)]
        public string BillTo_FirstName { get; set; }

        [StringLength(100)]
        public string BillTo_LastName { get; set; }

        [StringLength(500)]
        public string BillTo_Street { get; set; }

        [StringLength(255)]
        public string BillTo_Address1 { get; set; }

        [StringLength(255)]
        public string BillTo_Address2 { get; set; }

        [StringLength(100)]
        public string BillTo_City { get; set; }

        [StringLength(100)]
        public string BillTo_Zip { get; set; }

        [StringLength(100)]
        public string BillTo_PostCode { get; set; }

        [StringLength(100)]
        public string BillTo_State { get; set; }

        [StringLength(100)]
        public string BillTo_Country { get; set; }

        [StringLength(100)]
        public string ShipTo_FirstName { get; set; }

        [StringLength(100)]
        public string ShipTo_LastName { get; set; }

        [StringLength(500)]
        public string ShipTo_Street { get; set; }

        [StringLength(255)]
        public string ShipTo_Address1 { get; set; }

        [StringLength(255)]
        public string ShipTo_Address2 { get; set; }

        [StringLength(100)]
        public string ShipTo_City { get; set; }

        [StringLength(100)]
        public string ShipTo_Zip { get; set; }

        [StringLength(100)]
        public string ShipTo_State { get; set; }

        [StringLength(100)]
        public string ShipTo_PostCode { get; set; }

        [StringLength(100)]
        public string ShipTo_Country { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Session_Id { get; set; }

        [StringLength(100)]
        public string User_Id { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(100)]
        public string PayPal_OrderId { get; set; }

        [StringLength(100)]
        public string PayPal_Token { get; set; }

        [StringLength(100)]
        public string PayPal_PayerId { get; set; }

        [StringLength(100)]
        public string Basket_Id { get; set; }
    }
}
