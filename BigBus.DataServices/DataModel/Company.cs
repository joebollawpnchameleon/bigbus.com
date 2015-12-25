namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Company")]
    public class Company
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string IATANumber { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string FaxNumber { get; set; }

        [StringLength(150)]
        public string WebsiteURL { get; set; }

        public decimal Discount { get; set; }

        [Column("AccountManager_Id")]
        public Guid? AccountManagerId { get; set; }

        [Required]
        [StringLength(1)]
        public string DiscountType { get; set; }

        public decimal DiscountDollar { get; set; }

        public decimal DiscountEuro { get; set; }

        public decimal DiscountPound { get; set; }

        [StringLength(255)]
        public string AddressLine1 { get; set; }

        [StringLength(255)]
        public string AddressLine2 { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(15)]
        public string PostCode { get; set; }

        [StringLength(100)]
        public string StateProvince { get; set; }

        [StringLength(100)]
        [Column("Country_Id")]
        public string CountryId { get; set; }

        public virtual User User { get; set; }
    }
}
