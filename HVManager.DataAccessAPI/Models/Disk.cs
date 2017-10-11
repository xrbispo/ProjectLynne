using System.ComponentModel.DataAnnotations;


namespace HVManager.DataAccessAPI.Models
{
    public class Disk
    {
        public int DiskID { get; set; }

        [Required]
        [Display(Name = "Size(GB)")]
        public int Size { get; set; }

        public BaseHost Host { get; set; }
    }
}
