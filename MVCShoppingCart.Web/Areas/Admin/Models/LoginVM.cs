using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace MVCShoppingCart.Web.Areas.Admin.Models
{
    public class LoginVM
    {

        [Required(ErrorMessage = "User Name is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email address is not valid")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
    }
}
