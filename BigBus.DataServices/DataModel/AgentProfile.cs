namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AgentProfile")]
    public class AgentProfile
    {
        public AgentProfile()
        {
            User = new HashSet<User>();
        }

        [StringLength(50)]
        public string Id { get; set; }

        [Column("CreatedBy_Id")]
        public Guid CreatedById { get; set; }

        [Required]
        [StringLength(50)]
        [Column("CreatedBy_Name")]
        public string CreatedByName { get; set; }

        [Column("ModifiedBy_Id")]
        public Guid ModifiedById { get; set; }

        [Required]
        [StringLength(50)]
        [Column("ModifiedBy_Name")]
        public string ModifiedByName { get; set; }

        [Column("AccountManager_Id")]
        public Guid? AccountManagerId { get; set; }

        [StringLength(50)]
        [Column("AccountManager_Name")]
        public string AccountManagerName { get; set; }

        public bool Enabled { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateLastModified { get; set; }

        public bool RequiresPasswordToViewAccountHistory { get; set; }

        [StringLength(400)]
        public string AccountHistoryPassword { get; set; }

        public string AccountHistoryPasswordHash { get; set; }

        public int AccountHistoryPasswordVersion { get; set; }

        public virtual AccountManager AccountManager { get; set; }

        public virtual AccountManager AccountManager1 { get; set; }

        public virtual AccountManager AccountManager2 { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
