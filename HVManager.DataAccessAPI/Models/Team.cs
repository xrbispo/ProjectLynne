using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class Team
    {
        public int TeamID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Team name must have between 5 and 30 characters")]
        [Display(Name = "Team Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "E-mail address invalid")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "E-mail address must have between 10 and 50 characters")]
        [Display(Name = "Team e-mail address")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Manager name must have between 4 and 20 characters. Use same name of his/her e-mail address")]
        [Display(Name = "Manager Name")]
        public string Manager { get; set; }
    }
}