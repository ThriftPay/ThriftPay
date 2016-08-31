using System.ComponentModel.DataAnnotations;

namespace ThriftPay.Account.ViewModels.Account {
    public class ForgotPasswordViewModel {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
