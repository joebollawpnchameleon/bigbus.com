
using System.ComponentModel.DataAnnotations;

namespace BigBus.Agent.Web.Models
{
    public class LoginMV
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public int UserType { get; set; }
        public string ReferringUrl { get; set; }
    }
}
