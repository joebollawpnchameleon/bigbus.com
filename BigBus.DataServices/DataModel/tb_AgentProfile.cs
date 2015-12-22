namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_AgentProfile")]
    public partial class AgentProfile
    {
        public AgentProfile()
        {
            User = new HashSet<User>();
        }

        [StringLength(50)]
        public string Id { get; set; }

        public Guid CreatedBy_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy_Name { get; set; }

        public Guid ModifiedBy_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ModifiedBy_Name { get; set; }

        public Guid? AccountManager_Id { get; set; }

        [StringLength(50)]
        public string AccountManager_Name { get; set; }

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
