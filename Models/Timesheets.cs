using System.ComponentModel.DataAnnotations;

namespace DemoForm.Models
{
    public class Timesheets
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "Date Worked")]
        public DateTime? DateWorked { get; set; }

        public string Notes { get; set; }

        public string Category { get; set; }

    }
}
