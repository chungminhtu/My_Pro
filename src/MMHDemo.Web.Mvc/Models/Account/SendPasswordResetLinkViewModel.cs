using System.ComponentModel.DataAnnotations;

namespace MMHDemo.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}