using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class Client
    {

        [Required]
        [StringLength(6, MinimumLength = 6)]
        [RegularExpression(@"\S*(\S *([a-zA-Z]\S*[0-9])|([0-9]\S*[a zA Z]))\S*",ErrorMessage = "Client ID must have at least 1 number and 1 letter")]
        public string ClientID { get; set; }

        [Required]
        [StringLength(90, MinimumLength = 3)]
        [Display(Name = "Client Name")]
        public string Name { get; set; }

    }
}