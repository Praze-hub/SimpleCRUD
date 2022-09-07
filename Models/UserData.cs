using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class UserData

    {  
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName {get; set;}
        [Required(ErrorMessage = "Last name is required")]
        public string LastName {get; set;}
        [Required(ErrorMessage = "Locaton is required")]
        public string Location {get; set;}
        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber {get; set;}
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = " Please enter a valid email address")]
        public string Email {get; set;}
    }
}