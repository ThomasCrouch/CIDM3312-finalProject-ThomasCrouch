using System.ComponentModel.DataAnnotations;

namespace finalProject_ThomasCrouch.Models
{
    public class Prison
    {
        public int PrisonID {get; set;} // primary key

        [Required]
        [Display(Name = "Name")]
        [StringLength(75, MinimumLength = 3)]
        public string PrisonName {get; set;} = string.Empty;
        
        [Required]
        [Display(Name = "Address")]
        [StringLength(100, MinimumLength = 3)]
        public string PrisonAddress {get; set;} = string.Empty;

        [Required]
        [Display(Name = "Warden")]
        [StringLength(75)]
        public string WardenName {get; set;} = string.Empty;
        
        [Display(Name = "Employed Guards")]
        [Required]
        [Range(10, 150)]
        public int GuardsEmployed {get; set;}

        [Display(Name = "Security Level")]
        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string SecurityLevel {get; set;} = string.Empty;

        [Display(Name = "Opened on")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOpened {get; set;}

        public List<Prisoner> Prisoners {get; set;} = new List<Prisoner>(); // nav property
    }
}