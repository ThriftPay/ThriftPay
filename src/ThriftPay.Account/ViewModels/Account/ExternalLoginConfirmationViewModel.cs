using System.ComponentModel.DataAnnotations;

namespace ThriftPay.Account.ViewModels.Account {
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
