using System.ComponentModel.DataAnnotations;

namespace DIGIKYC.Model.SignUp
{
    public class Register
    {

        [Required(ErrorMessage = "User name is required")]
        public string? MobileNo { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }
        


    }
}

