using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required,MaxLength(100)]
        public string FisrtName { get; set; }
        [Required, MaxLength(100)]
        public string LastName { get; set; }
        public string AccountStatus { get; set; }
    }
}
