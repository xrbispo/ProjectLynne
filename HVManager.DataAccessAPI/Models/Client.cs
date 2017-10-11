using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class Client
    {

        [Required]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Client ID must have 6 characters that includes numbers and letters")]
        public string ClientID { get; set; }

        [Required]
        [StringLength(90, MinimumLength = 3, ErrorMessage = "Client name must have between 3 and 90 characters")]
        [Display(Name = "Client Name")]
        public string Name { get; set; }

    }
}