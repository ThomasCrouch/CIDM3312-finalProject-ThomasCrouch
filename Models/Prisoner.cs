using System.ComponentModel.DataAnnotations;

namespace finalProject_ThomasCrouch.Models
{
    public class Prisoner
    {
        public int PrisonerID {get; set;} // primary key

        [Required]
        [Display(Name = "Name")]
        [StringLength(75, MinimumLength = 1)]
        public string PrisonerName {get; set;} = string.Empty;

        [Required]
        [Display(Name = "Convicted of")]
        [StringLength(250)]
        public string ConvictedCrimes {get; set;} = string.Empty;
        
        [Required]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime DateOfRelease {get; set;}

        public int PrisonID {get; set;} // foreign key to link prisoners to their respective prison

        public Prison? Prison {get; set;} // nav property
    }
}