using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class HardwareModel
    {
        public int HardwareModelID { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Hardware model must have between 3 and 40 characters")]
        [Display(Name = "HardwareModel Name")]
        public string Name { get; set; }
    }
}