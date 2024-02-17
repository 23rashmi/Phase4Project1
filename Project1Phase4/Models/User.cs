using System.ComponentModel.DataAnnotations;

namespace Project1Phase4.Models
{
    public class User
    {
        [Required(ErrorMessage ="Username is required")]
        public string? Username { get; set; }


        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string? Email {  get; set; } 
    }
}
