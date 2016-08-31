using System.ComponentModel.DataAnnotations;

namespace ThriftPay.Account.ViewModels.Account
{
    public class VerifyPhoneNumberViewModel {
        [Required]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
