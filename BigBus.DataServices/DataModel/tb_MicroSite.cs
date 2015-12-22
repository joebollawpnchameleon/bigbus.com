namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_MicroSite")]
    public partial class MicroSite
    {
        public MicroSite()
        {
            AccountManagerMicroSite = new HashSet<AccountManagerMicroSite>();
            Barcode = new HashSet<Barcode>();
            MicroSiteLanguage = new HashSet<MicroSite_Language>();
            Navigation = new HashSet<Navigation>();
            Route = new HashSet<Route>();
        }

        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(3)]
        public string Language_Id { get; set; }

        [StringLength(50)]
        public string Currency_Id { get; set; }

        public Guid? RedTour_Id { get; set; }

        public Guid? BlueTour_Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public Guid? HomeOfferImage_Id { get; set; }

        [StringLength(15)]
        public string Mode { get; set; }

        public bool MultilingualActive { get; set; }

        public int? DisplayOrder { get; set; }

        public int Offer_Id { get; set; }

        [StringLength(150)]
        public string DotNetTimeZone { get; set; }

        [StringLength(150)]
        public string DotNetTimeZoneStandardName { get; set; }

        [StringLength(300)]
        public string ContactDetails { get; set; }

        [StringLength(300)]
        public string ContactNumber { get; set; }

        public bool CollectTickets { get; set; }

        public string CollectTicketsDetails { get; set; }

        public bool IsUS { get; set; }

        public bool UseQR { get; set; }

        [StringLength(500)]
        public string RefundEmail { get; set; }

        public bool ShowTrustPilotCode { get; set; }

        [StringLength(150)]
        public string TrustPilotUrl { get; set; }

        [StringLength(10)]
        public string AffiliateWindowMerchantId { get; set; }

        [StringLength(50)]
        public string AffiliateWindowTourCommissionLabel { get; set; }

        [StringLength(50)]
        public string AffiliateWindowAttractionCommissionLabel { get; set; }

        public int? ViatorWidgetDestinationId { get; set; }

        [StringLength(50)]
        public string GoogleRemarketingConversionId { get; set; }

        [StringLength(50)]
        public string GoogleRemarketingConversionLabel { get; set; }

        public bool ECRVersion2Enabled { get; set; }

        public bool IsActiveAgentTandC { get; set; }

        public int EcrVersionId { get; set; }

        public virtual ICollection<AccountManagerMicroSite> AccountManagerMicroSite { get; set; }

        public virtual ICollection<Barcode> Barcode { get; set; }

        public virtual ICollection<MicroSite_Language> MicroSiteLanguage { get; set; }

        public virtual ICollection<Navigation> Navigation { get; set; }

        public virtual ICollection<Route> Route { get; set; }
    }
}
