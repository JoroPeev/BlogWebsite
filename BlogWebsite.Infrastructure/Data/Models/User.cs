using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static BlogWebsite.Infrastructure.Data.Constants.Constants;

namespace BlogWebsite.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(FirstNameMax)]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(LastNameMax)]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(RaitingMax)]
        public int Raiting { get; set; }


    }
}
