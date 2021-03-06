using System;
using System.ComponentModel.DataAnnotations;

namespace API.Resources
{
    public class RegisterResource
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }
        public string KnownAs { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
    }
}