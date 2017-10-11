using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class HardwareModel
    {
        public int HardwareModelID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Hardware model must have between 3 and 30 characters")]
        [Display(Name = "HardwareModel Name")]
        public string Name { get; set; }
    }
}