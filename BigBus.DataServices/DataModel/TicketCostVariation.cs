namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_TicketCostVariation")]
    public class TicketCostVariation
    {
        public Guid Id { get; set; }

        [Column("Ticket_Id")]
        public Guid? TicketId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }

        public bool? DaySpecific { get; set; }

        public bool? ValidMonday { get; set; }

        public bool? ValidTuesday { get; set; }

        public bool? ValidWednesday { get; set; }

        public bool? ValidThursday { get; set; }

        public bool? ValidFriday { get; set; }

        public bool? ValidSaturday { get; set; }

        public bool? ValidSunday { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [StringLength(1)]
        public string VariationType { get; set; }

        public decimal? PercentageValue { get; set; }

        public decimal? DollarAdultTicketCost { get; set; }

        public decimal? DollarChildTicketCost { get; set; }

        public decimal? DollarFamilyTicketCost { get; set; }

        public decimal? DollarConcessionTicketCost { get; set; }

        public decimal? DollarGroupAdultTicketCost { get; set; }

        public decimal? DollarGroupChildTicketCost { get; set; }

        public decimal? EuroAdultTicketCost { get; set; }

        public decimal? EuroChildTicketCost { get; set; }

        public decimal? EuroFamilyTicketCost { get; set; }

        public decimal? EuroConcessionTicketCost { get; set; }

        public decimal? EuroGroupAdultTicketCost { get; set; }

        public decimal? EuroGroupChildTicketCost { get; set; }

        public decimal? PoundAdultTicketCost { get; set; }

        public decimal? PoundChildTicketCost { get; set; }

        public decimal? PoundFamilyTicketCost { get; set; }

        public decimal? PoundConcessionTicketCost { get; set; }

        public decimal? PoundGroupAdultTicketCost { get; set; }

        public decimal? PoundGroupChildTicketCost { get; set; }

        public bool? TimeSpecific { get; set; }

        public int? StartTimeHour { get; set; }

        public int? StartTimeMinute { get; set; }

        public int? EndTimeHour { get; set; }

        public int? EndTimeMinute { get; set; }

        public bool? Enabled { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public bool? PercentageAppliesToAll { get; set; }

        public decimal? PercentageAdult { get; set; }

        public decimal? PercentageChild { get; set; }

        public decimal? PercentageFamily { get; set; }

        public decimal? PercentageConcession { get; set; }

        public decimal? PercentageGroupAdult { get; set; }

        public decimal? PercentageGroupChild { get; set; }

        public decimal? AEDAdultTicketCost { get; set; }

        public decimal? AEDChildTicketCost { get; set; }

        public decimal? AEDFamilyTicketCost { get; set; }

        public decimal? AEDConcessionTicketCost { get; set; }

        public decimal? AEDGroupAdultTicketCost { get; set; }

        public decimal? AEDGroupChildTicketCost { get; set; }

        public decimal? HKDAdultTicketCost { get; set; }

        public decimal? HKDChildTicketCost { get; set; }

        public decimal? HKDFamilyTicketCost { get; set; }

        public decimal? HKDConcessionTicketCost { get; set; }

        public decimal? HKDGroupAdultTicketCost { get; set; }

        public decimal? HKDGroupChildTicketCost { get; set; }

        public decimal? DollarInfantTicketCost { get; set; }

        public decimal? EuroInfantTicketCost { get; set; }

        public decimal? PoundInfantTicketCost { get; set; }

        public decimal? PercentageInfant { get; set; }

        public decimal? AEDInfantTicketCost { get; set; }

        public decimal? HKDInfantTicketCost { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
