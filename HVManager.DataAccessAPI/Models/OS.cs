using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class OS
    {
        public int OSID { get;  set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "O.S. name must have between 3 and 50 characters")]
        [Display(Name = "O.S. Name")]
        public string Name { get; set; }
    }
}
