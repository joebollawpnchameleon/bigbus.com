namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    
    [Table("tb_AccountManager")]
    public partial class AccountManager
    {
        public AccountManager()
        {
            AccountManagerMicroSite = new HashSet<AccountManagerMicroSite>();
            AgentProfile = new HashSet<AgentProfile>();
            AgentProfile1 = new HashSet<AgentProfile>();
            AgentProfile2 = new HashSet<AgentProfile>();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public string PasswordHash { get; set; }

        public int PasswordVersion { get; set; }

        [Required]
        [StringLength(70)]
        public string FullName { get; set; }

        [Required]
        [StringLength(500)]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy_Id { get; set; }

        public bool Enabled { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        [StringLength(300)]
        public string ContactTel { get; set; }

        public bool SuperManager { get; set; }

        public virtual ICollection<AccountManagerMicroSite> AccountManagerMicroSite { get; set; }

        public virtual ICollection<AgentProfile> AgentProfile { get; set; }

        public virtual ICollection<AgentProfile> AgentProfile1 { get; set; }

        public virtual ICollection<AgentProfile> AgentProfile2 { get; set; }
    }
}
