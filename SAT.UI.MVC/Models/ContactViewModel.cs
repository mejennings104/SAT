using System.ComponentModel.DataAnnotations;

namespace SAT.UI.MVC.Models
{    
    public class ContactViewModel
    {
        [Required(ErrorMessage = "*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*")]
      
        [EmailAddress(ErrorMessage = "*Must be a valid email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}