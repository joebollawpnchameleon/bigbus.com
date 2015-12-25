namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BigBusDataModelContext : DbContext
    {
        public BigBusDataModelContext()
            : base("name=BigBusDataModelConn")
        {
        }

        public virtual DbSet<AccountManager> AccountManager { get; set; }
        public virtual DbSet<AccountManagerMicroSite> AccountManagerMicroSite { get; set; }
        public virtual DbSet<AdminLog> AdminLog { get; set; }
        public virtual DbSet<AdminSession> AdminSession { get; set; }
        public virtual DbSet<AdminUser> AdminUser { get; set; }
        public virtual DbSet<AgentCashSale> AgentCashSale { get; set; }
        public virtual DbSet<AgentCommission> AgentCommission { get; set; }
        public virtual DbSet<AgentOrder> AgentOrder { get; set; }
        public virtual DbSet<AgentOrderError> AgentOrderError { get; set; }
        public virtual DbSet<AgentProfile> AgentProfile { get; set; }
        public virtual DbSet<Barcode> Barcode { get; set; }
        public virtual DbSet<Basket> Basket { get; set; }
        public virtual DbSet<BasketPromotion> BasketPromotion { get; set; }
        public virtual DbSet<BasketLine> BasketLine { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<ContactData> ContactData { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CustomPage> CustomPage { get; set; }
        public virtual DbSet<CustomPageLanguage> CustomPageLanguage { get; set; }
        public virtual DbSet<Download> Download { get; set; }
        public virtual DbSet<DownloadFolder> DownloadFolder { get; set; }
        public virtual DbSet<DownloadMetaData> DownloadMetaData { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<ExternalOrderBarcode> ExternalOrderBarcode { get; set; }
        public virtual DbSet<GalleryImage> GalleryImage { get; set; }
        public virtual DbSet<GoogleCode> GoogleCode { get; set; }
        public virtual DbSet<GroupBooking> GroupBooking { get; set; }
        public virtual DbSet<GroupBookingStop> GroupBookingStop { get; set; }
        public virtual DbSet<GroupBookingTime> GroupBookingTime { get; set; }
        public virtual DbSet<HomePageData> HomePageData { get; set; }
        public virtual DbSet<HtmlMetaTag> HtmlMetaTag { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<ImageFolder> ImageFolder { get; set; }
        public virtual DbSet<ImageMetaData> ImageMetaData { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<MicroSite> MicroSite { get; set; }
        public virtual DbSet<MicroSiteLanguage> MicroSiteLanguage { get; set; }
        public virtual DbSet<MultiTicketPromotion> MultiTicketPromotion { get; set; }
        public virtual DbSet<Navigation> Navigation { get; set; }
        public virtual DbSet<NavigationItem> NavigationItem { get; set; }
        public virtual DbSet<NavigationItemLanguage> NavigationItemLanguage { get; set; }
        public virtual DbSet<NewsItem> NewsItem { get; set; }
        public virtual DbSet<Newsletter> Newsletter { get; set; }
        public virtual DbSet<NewsletterComposite> NewsletterComposite { get; set; }
        public virtual DbSet<NewsletterStaticSection> NewsletterStaticSection { get; set; }
        public virtual DbSet<NewsletterText> NewsletterText { get; set; }
        public virtual DbSet<NewsletterTextLanguage> NewsletterTextLanguage { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Orderline> Orderline { get; set; }
        public virtual DbSet<OrderLineGeneratedBarcode> OrderLineGeneratedBarcode { get; set; }
        public virtual DbSet<PasswordAdminResetRequest> PasswordAdminResetRequest { get; set; }
        public virtual DbSet<PasswordResetRequest> PasswordResetRequest { get; set; }
        public virtual DbSet<PaymentTransaction> PaymentTransaction { get; set; }
        public virtual DbSet<Phrase> Phrase { get; set; }
        public virtual DbSet<PhraseLanguage> PhraseLanguage { get; set; }
        public virtual DbSet<PlaceOfInterest> PlaceOfInterest { get; set; }
        public virtual DbSet<PlaceOfInterestLanguage> PlaceOfInterestLanguage { get; set; }
        public virtual DbSet<PlaceOfInterestStop> PlaceOfInterestStop { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<PromotionDiscountedTicket> PromotionDiscountedTicket { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<RouteLanguage> RouteLanguage { get; set; }
        public virtual DbSet<RouteStop> RouteStop { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<SiteText> SiteText { get; set; }
        public virtual DbSet<SiteTextLanguage> SiteTextLanguage { get; set; }
        public virtual DbSet<Stop> Stop { get; set; }
        public virtual DbSet<StopLanguage> StopLanguage { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<ThingsToDoItem> ThingsToDoItem { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<TicketExclusionDate> TicketExclusionDate { get; set; }
        public virtual DbSet<TicketExclusionWeekday> TicketExclusionWeekday { get; set; }
        public virtual DbSet<TicketLanguage> TicketLanguage { get; set; }
        public virtual DbSet<TicketApi> TicketApi { get; set; }
        public virtual DbSet<TicketCombination> TicketCombination { get; set; }
        public virtual DbSet<TicketCost> TicketCost { get; set; }
        public virtual DbSet<TicketCostVariation> TicketCostVariation { get; set; }
        public virtual DbSet<TourAnimationContent> TourAnimationContent { get; set; }
        public virtual DbSet<TransactionAddress> TransactionAddress { get; set; }
        public virtual DbSet<TransactionAddressPaypal> TransactionAddressPaypal { get; set; }
        public virtual DbSet<UrlRewrite> UrlRewrite { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<DiallingCode> DiallingCode { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountManager>()
                .HasMany(e => e.AccountManagerMicroSite)
                .WithRequired(e => e.AccountManager)
                .HasForeignKey(e => e.AccountManagerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccountManager>()
                .HasMany(e => e.AgentProfile)
                .WithRequired(e => e.AccountManager)
                .HasForeignKey(e => e.CreatedById)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccountManager>()
                .HasMany(e => e.AgentProfile1)
                .WithRequired(e => e.AccountManager1)
                .HasForeignKey(e => e.ModifiedById)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccountManager>()
                .HasMany(e => e.AgentProfile2)
                .WithOptional(e => e.AccountManager2)
                .HasForeignKey(e => e.AccountManagerId);

            modelBuilder.Entity<AgentCashSale>()
                .Property(e => e.CreditLimit)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AgentCashSale>()
                .Property(e => e.BalanceAlertLimit)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AgentCashSale>()
                .Property(e => e.CurrentBalance)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AgentCashSale>()
                .Property(e => e.CurrentTotal)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AgentCommission>()
                .Property(e => e.Commission)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AgentOrder>()
                .Property(e => e.OrderRef)
                .IsUnicode(false);

            modelBuilder.Entity<AgentOrder>()
                .Property(e => e.AdultTicketCost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AgentOrder>()
                .Property(e => e.ChildTicketCost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AgentOrder>()
                .Property(e => e.FamilyTicketCost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AgentOrder>()
                .Property(e => e.OrderTotal)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AgentOrder>()
                .Property(e => e.CommissionTotal)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AgentOrder>()
                .Property(e => e.OrderTypeTorA)
                .IsUnicode(false);

            modelBuilder.Entity<AgentOrder>()
                .Property(e => e.CommissionPaidByName)
                .IsUnicode(false);

            modelBuilder.Entity<AgentOrder>()
                .Property(e => e.CommissionRaisedByName)
                .IsUnicode(false);

            modelBuilder.Entity<AgentOrder>()
                .Property(e => e.InfantTicketCost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AgentOrderError>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<AgentProfile>()
                .HasMany(e => e.User)
                .WithOptional(e => e.AgentProfile)
                .HasForeignKey(e => e.AgentProfileId);

            modelBuilder.Entity<Basket>()
                .Property(e => e.DiscountValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Basket>()
                .HasMany(e => e.BasketPromotion)
                .WithOptional(e => e.Basket)
                .HasForeignKey(e => e.BasketId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.AgentCommission)
                .WithRequired(e => e.Currency)
                .HasForeignKey(e => e.CurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomPageLanguage>()
                .Property(e => e.LanguageId)
                .IsFixedLength();

            modelBuilder.Entity<GroupBooking>()
                .HasMany(e => e.GroupBookingStop)
                .WithRequired(e => e.GroupBooking)
                .HasForeignKey(e => e.GroupBookingId);

            modelBuilder.Entity<GroupBooking>()
                .HasMany(e => e.GroupBookingTime)
                .WithRequired(e => e.GroupBooking)
                .HasForeignKey(e => e.GroupBookingId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ImageFolder>()
                .HasMany(e => e.Image)
                .WithOptional(e => e.ImageFolder)
                .HasForeignKey(e => e.ImageFolderId);

            modelBuilder.Entity<ImageFolder>()
                .HasMany(e => e.ImageFolder1)
                .WithOptional(e => e.ImageFolder2)
                .HasForeignKey(e => e.ParentFolderId);

            modelBuilder.Entity<ImageMetaData>()
                .HasMany(e => e.Image)
                .WithOptional(e => e.ImageMetaData)
                .HasForeignKey(e => e.ImageMetadataId);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.MicroSiteLanguage)
                .WithOptional(e => e.Language)
                .HasForeignKey(e => e.LanguageId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Language>()
                .HasMany(e => e.NavigationItemLanguage)
                .WithOptional(e => e.Language)
                .HasForeignKey(e => e.LanguageId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Language>()
                .HasMany(e => e.PhraseLanguage)
                .WithOptional(e => e.Language)
                .HasForeignKey(e => e.LanguageId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Language>()
                .HasMany(e => e.PlaceOfInterestLanguage)
                .WithOptional(e => e.Language)
                .HasForeignKey(e => e.LanguageId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Language>()
                .HasMany(e => e.RouteLanguage)
                .WithOptional(e => e.Language)
                .HasForeignKey(e => e.Languageid)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Language>()
                .HasMany(e => e.SiteTextLanguage)
                .WithRequired(e => e.Language)
                .HasForeignKey(e => e.LanguageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.StopLanguage)
                .WithOptional(e => e.Language)
                .HasForeignKey(e => e.LanguageId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Log>()
                .Property(e => e.Level)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Logger)
                .IsUnicode(false);

            modelBuilder.Entity<MicroSite>()
                .Property(e => e.LanguageId)
                .IsFixedLength();

            modelBuilder.Entity<MicroSite>()
                .HasMany(e => e.AccountManagerMicroSite)
                .WithRequired(e => e.MicroSite)
                .HasForeignKey(e => e.MicrositeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MicroSite>()
                .HasMany(e => e.Barcode)
                .WithOptional(e => e.MicroSite)
                .HasForeignKey(e => e.MicrositeId);

            modelBuilder.Entity<MicroSite>()
                .HasMany(e => e.MicroSiteLanguage)
                .WithOptional(e => e.MicroSite)
                .HasForeignKey(e => e.MicroSiteId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MicroSite>()
                .HasMany(e => e.Navigation)
                .WithOptional(e => e.MicroSite)
                .HasForeignKey(e => e.MicroSiteId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MicroSite>()
                .HasMany(e => e.Route)
                .WithRequired(e => e.MicroSite)
                .HasForeignKey(e => e.MicroSiteId);

            modelBuilder.Entity<Navigation>()
                .HasMany(e => e.NavigationItem)
                .WithOptional(e => e.Navigation)
                .HasForeignKey(e => e.NavigationId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NavigationItem>()
                .HasMany(e => e.NavigationItemLanguage)
                .WithOptional(e => e.NavigationItem)
                .HasForeignKey(e => e.NavigationItemId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NewsletterTextLanguage>()
                .Property(e => e.LanguageId)
                .IsFixedLength();

            modelBuilder.Entity<NewsletterTextLanguage>()
                .HasOptional(e => e.NewsletterTextLanguage1)
                .WithRequired(e => e.NewsletterTextLanguage2);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Orderline)
                .WithOptional(e => e.Order)
                .HasForeignKey(e => e.OrderId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Phrase>()
                .HasMany(e => e.PhraseLanguage)
                .WithOptional(e => e.Phrase)
                .HasForeignKey(e => e.PhraseId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PlaceOfInterest>()
                .HasMany(e => e.PlaceOfInterestLanguage)
                .WithOptional(e => e.PlaceOfInterest)
                .HasForeignKey(e => e.PlaceOfInterestId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PlaceOfInterest>()
                .HasMany(e => e.PlaceOfInterestStop)
                .WithOptional(e => e.PlaceOfInterest)
                .HasForeignKey(e => e.PlaceOfInterestId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Promotion>()
                .HasMany(e => e.BasketPromotion)
                .WithOptional(e => e.Promotion)
                .HasForeignKey(e => e.PromotionId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Route>()
                .HasMany(e => e.RouteLanguage)
                .WithOptional(e => e.Route)
                .HasForeignKey(e => e.RouteId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Route>()
                .HasMany(e => e.RouteStop)
                .WithOptional(e => e.Route)
                .HasForeignKey(e => e.RouteId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteText>()
                .HasMany(e => e.SiteTextLanguage)
                .WithRequired(e => e.SiteText)
                .HasForeignKey(e => e.SiteTextId);

            modelBuilder.Entity<Stop>()
                .HasMany(e => e.GroupBookingStop)
                .WithRequired(e => e.Stop)
                .HasForeignKey(e => e.StopId);

            modelBuilder.Entity<Stop>()
                .HasMany(e => e.PlaceOfInterestStop)
                .WithOptional(e => e.Stop)
                .HasForeignKey(e => e.StopId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Stop>()
                .HasMany(e => e.RouteStop)
                .WithOptional(e => e.Stop)
                .HasForeignKey(e => e.StopId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Stop>()
                .HasMany(e => e.StopLanguage)
                .WithOptional(e => e.Stop)
                .HasForeignKey(e => e.StopId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Ticket>()
                .HasMany(e => e.AgentCommission)
                .WithRequired(e => e.Ticket)
                .HasForeignKey(e => e.TicketId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .HasMany(e => e.PlaceOfInterest)
                .WithOptional(e => e.Ticket)
                .HasForeignKey(e => e.TicketId);

            modelBuilder.Entity<Ticket>()
                .HasMany(e => e.Route)
                .WithOptional(e => e.Ticket)
                .HasForeignKey(e => e.TicketId);

            modelBuilder.Entity<Ticket>()
                .HasMany(e => e.TicketExclusionWeekday)
                .WithRequired(e => e.Ticket)
                .HasForeignKey(e => e.TicketId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .HasMany(e => e.TicketCost)
                .WithOptional(e => e.Ticket)
                .HasForeignKey(e => e.TicketId);

            modelBuilder.Entity<Ticket>()
                .HasMany(e => e.TicketCostVariation)
                .WithOptional(e => e.Ticket)
                .HasForeignKey(e => e.TicketId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TicketLanguage>()
                .Property(e => e.LanguageId)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.LanguageId)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.AgentCommission)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.AgentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Company)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.AccountManagerId);

            modelBuilder.Entity<DiallingCode>()
                .Property(e => e.Id)
                .IsUnicode(false);
        }
    }
}
