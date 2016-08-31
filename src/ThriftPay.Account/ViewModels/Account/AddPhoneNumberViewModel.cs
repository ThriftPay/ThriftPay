using System.ComponentModel.DataAnnotations;

namespace ThriftPay.Account.ViewModels.Account {
    public class AddPhoneNumberViewModel {
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
