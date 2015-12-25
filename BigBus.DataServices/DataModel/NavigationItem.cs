namespace BigBus.DataServices.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_NavigationItem")]
    public class NavigationItem
    {
        public NavigationItem()
        {
            NavigationItemLanguage = new HashSet<NavigationItemLanguage>();
        }

        public Guid Id { get; set; }

        [Column("Navigation_Id")]
        public Guid? NavigationId { get; set; }

        public int? Position { get; set; }

        [StringLength(255)]
        public string ServerURL { get; set; }

        [Column("Parent_Id")]
        public Guid? ParentId { get; set; }

        [StringLength(255)]
        public string URL { get; set; }

        public virtual Navigation Navigation { get; set; }

        public virtual ICollection<NavigationItemLanguage> NavigationItemLanguage { get; set; }
    }
}
