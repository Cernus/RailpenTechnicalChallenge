using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Railpen.Data.ViewModels
{
    public class QuoteVM
    {
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        [DisplayName("Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }

        public string Company { get; set; }

        public QuoteVM()
        {
            Name = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            Company = string.Empty;
        }
    }
}
